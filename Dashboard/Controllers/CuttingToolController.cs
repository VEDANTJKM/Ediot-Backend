using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuttingToolController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CuttingToolController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Accept optional classId as a query parameter
        [HttpGet("GetCuttingTools")]
        public async Task<IActionResult> GetCuttingTools([FromQuery] string? classId = null)
        {
            string baseQuery = @"SELECT    PartNum, PartDescription, TypeCode, Warehouse, BinNo, OnHandQty_SN, UnitPrice, UOM
                                 FROM Epicor_Part_Library 
                                 WHERE Company = 'SN' AND Inactive = 0";

            if (!string.IsNullOrEmpty(classId))
            {
                baseQuery += " AND ClassID = @ClassID";
            }

            List<Cuttingtool> tools = new List<Cuttingtool>();
            using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("cs")))
            using (SqlCommand cmd = new SqlCommand(baseQuery, conn))
            {
                if (!string.IsNullOrEmpty(classId))
                {
                    cmd.Parameters.AddWithValue("@ClassID", classId);
                }

                await conn.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        tools.Add(new Cuttingtool
                        {
                            PartNum = reader["PartNum"].ToString(),
                            PartDescription = reader["PartDescription"].ToString(),
                            Type = reader["TypeCode"].ToString(),
                            Warehouse = reader["Warehouse"].ToString(),
                            Bin = reader["BinNo"].ToString(),
                            OnHandQty = reader["OnHandQty_SN"] != DBNull.Value ? Convert.ToInt32(reader["OnHandQty_SN"]) : 0,
                            UnitPrice = reader["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(reader["UnitPrice"]) : 0,
                            UOM = reader["UOM"].ToString()
                        });
                    }
                }
            }

            return Ok(tools);
        }
    }
}
