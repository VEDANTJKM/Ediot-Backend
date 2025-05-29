using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;


namespace Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpicorDataController : ControllerBase
    {
        private readonly string connectionString = "Server=tcp:sswhite.database.windows.net,1433;Database=ITEIndia;User Id=ssw-ad;Password=ahbarp#6008_ss;MultipleActiveResultSets=True;TrustServerCertificate=True";
        private readonly string connectionString1 = "Server=Erpgcc-read00.epicorsaas.com,63424;Database=SaaS1143_62653;User Id=C62653RO;Password=4Tf~Qc0%6URLrz;MultipleActiveResultSets=True;TrustServerCertificate=True";

        private (string TypeCode, string ClassID, string Header) GetTypeMetadata(string type)
        {
            return type switch
            {
                "AssemblyCNCPart" => ("P", "ASPC", "Assembly Spares CNC"),
                "CuttingToolsCNC" => ("P", "CT", "Cutting Tools CNC"),
                "Electrical" => ("P", "ELEC", "Electricals"),
                "Fasteners" => ("P", "FAST", "Fasteners"), 
                "Gauges" => ("P", "GUAG", "Gauges"),
                "Housekeeping" => ("P", "HKEP", "House Keeping"),
                "ManufacturingCNCPart" => ("M", "FGC", "Finished Good CNC"),
                "ManufacturingFlexPart" => ("M", "FGF", "Finished Good Flex"),
                "PackingMaterial" => ("P", "PM", "Packing Material"),
                "RawMaterialCNC" => ("P", "RMC", "Raw Material CNC"),
                "RawMaterialFlex" => ("P", "RMF", "Raw Material Flex"),
                "SafetyEquipment" => ("P", "SAFE", "Safety Equipment"),
                "SparesAll" => ("P", "SPA", "Spares All"),
                "SparesCNC" => ("P", "SPC", "Spares CNC"),
                "SparesFlex" => ("P", "SPF", "Spares Flex"),
                "Stationary" => ("P", "STAT", "Stationary"),
                "ToolHolderCNC" => ("P", "THLD", "Tool Holder CNC"),
                _ => ("", "", "")
            };
        }

        [HttpGet]
        public IActionResult GetEpicorData([FromQuery] string type, [FromQuery] string search)
        {
            var (typeCode, classID, header) = GetTypeMetadata(type);
            if (string.IsNullOrEmpty(typeCode)) return BadRequest("Invalid type");

            var query = "SELECT * FROM Epicor_Part_Library WHERE TypeCode=@TypeCode AND ClassID=@ClassID AND Company='SN' AND InActive=0";
            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " AND (PartNum LIKE @Search OR PartDescription LIKE @Search)";
            }

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TypeCode", typeCode);
            cmd.Parameters.AddWithValue("@ClassID", classID);
            if (!string.IsNullOrWhiteSpace(search))
                cmd.Parameters.AddWithValue("@Search", $"%{search}%");

            var dt = new DataTable();
            new SqlDataAdapter(cmd).Fill(dt);
            return Ok(new { Header = header, Data = dt });
        }

        [HttpGet("count")]
        public IActionResult GetCount([FromQuery] string type, [FromQuery] string search)
        {
            var (typeCode, classID, _) = GetTypeMetadata(type);
            if (string.IsNullOrEmpty(typeCode)) return BadRequest("Invalid type");

            var query = @"SELECT COUNT(PartNum) FROM Epicor_Part_Library 
                          WHERE TypeCode=@TypeCode AND ClassID=@ClassID AND Company='SN' AND InActive=0";
            if (!string.IsNullOrWhiteSpace(search))
                query += " AND (PartNum LIKE @Search OR PartDescription LIKE @Search)";

            using var conn = new SqlConnection(connectionString1);
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TypeCode", typeCode);
            cmd.Parameters.AddWithValue("@ClassID", classID);
            if (!string.IsNullOrWhiteSpace(search))
                cmd.Parameters.AddWithValue("@Search", $"%{search}%");

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return Ok(count);
        }

        [HttpGet("warehouse/{partnum}")]
        public IActionResult GetWarehouse(string partnum)
        {
            return GetSingleValue(partnum, "SELECT WarehouseCode FROM PartBin WHERE PartNum = @PartNum", "WarehouseCode");
        }

        [HttpGet("onhandqty/{partnum}")]
        public IActionResult GetOnHandQty(string partnum)
        {
            return GetSingleValue(partnum, "SELECT OnhandQty FROM PartBin WHERE PartNum = @PartNum", "OnhandQty");
        }

        [HttpGet("bin/{partnum}")]
        public IActionResult GetBinNo(string partnum)
        {
            return GetSingleValue(partnum, "SELECT BinNum FROM PartBin WHERE PartNum = @PartNum", "BinNum");
        }

        private IActionResult GetSingleValue(string partnum, string query, string field)
        {
            if (string.IsNullOrWhiteSpace(partnum)) return BadRequest("Part number required.");

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PartNum", partnum);
            conn.Open();
            var result = cmd.ExecuteScalar();
            return result != null ? Ok(result.ToString()) : NotFound();
        }




        [HttpGet("cuttingtools")]
        public IActionResult GetCuttingToolsData([FromQuery] string search = "")
        {
            var query = @"
SELECT 
    lib.PartNum,
    lib.PartDescription,
    lib.ClassID,
    lib.TypeCode,
    lib.UnitPrice,
    lib.UOM AS UOM,
    bin.WarehouseCode,
    bin.BinNum,
    bin.OnHandQty
FROM Epicor_Part_Library lib
LEFT JOIN dbo.PartBin bin ON lib.PartNum = bin.PartNum
WHERE lib.TypeCode = 'P' AND lib.ClassID = 'CT' AND lib.Company = 'SN' AND lib.InActive = 0";

            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " AND (lib.PartNum LIKE @Search OR lib.PartDescription LIKE @Search)";
            }

            using var conn = new SqlConnection(connectionString1);
            using var cmd = new SqlCommand(query, conn);
            if (!string.IsNullOrWhiteSpace(search))
                cmd.Parameters.AddWithValue("@Search", $"%{search}%");

            var dt = new DataTable();
            new SqlDataAdapter(cmd).Fill(dt);

            var data = dt.AsEnumerable().Select(row => new
            {
                PartNum = row["PartNum"]?.ToString(),
                PartDescription = row["PartDescription"]?.ToString(),
                Type = "CuttingToolsCNC",
                Warhouse = row["WarehouseCode"]?.ToString(),
                Bin = row["BinNum"]?.ToString(),
                OnHand = row["OnhandQty"] != DBNull.Value ? Convert.ToDecimal(row["OnhandQty"]) : 0,
                UnitPrice = row["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(row["UnitPrice"]) : 0,
                UOM = row["UOM"]?.ToString()
            }).ToList();

            return Ok(data);
        }



    }



}

