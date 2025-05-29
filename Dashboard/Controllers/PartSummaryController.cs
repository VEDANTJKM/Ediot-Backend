using Dashboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartSummaryController : ControllerBase
    {
        private readonly IConfiguration _config;

        public PartSummaryController(IConfiguration config)
        {
            _config = config;
        }

        private readonly Dictionary<string, string> _classNameMap = new()
        {
            { "ASPC", "Assembly Spares CNC" },
            { "CT", "Cutting Tools" },
            { "ELEC", "Electrical" },
            { "FAST", "Fasteners" },
            { "RMC", "Raw Material CNC" },
            { "RMF", "Raw Material Flex" },
            { "FGF", "Finished Good Flex" },
            { "FGC", "Finished Goods CNC" },
            { "GUAG", "Gauges" },
            { "PM", "Packing Material" },
            { "HKEP", "House Keeping" },
            { "SAFE", "Safety Equipment" },
            { "SPC", "Spares CNC" },
            { "SPF", "Spares Flex" },
             { "SPA", "Spares All" },
            { "STAT", "Stationery" },
            { "THLD", "Tool Holders" }
        };

        [HttpGet("GetDashboardData")]
       
        public async Task<IActionResult> GetDashboardData()
        {
            var result = new List<PartSummary>();
            var connStr = _config.GetConnectionString("CS");

            using (var conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();

                using (var cmd = new SqlCommand(@"
            SELECT 
                ClassID,
                COUNT(PartNum) AS TotalParts,
                SUM(ISNULL(UnitPrice, 0)) AS TotalPrice,
                SUM(ISNULL(OnHandQty_SN, 0)) AS TotalOnHandQty
            FROM Epicor_Part_Library 
            WHERE Company = 'SN' AND InActive = 0
            GROUP BY ClassID", conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var classId = reader.GetString(0);
                            if (_classNameMap.TryGetValue(classId, out string categoryName))
                            {
                                var partSummary = new PartSummary
                                {
                                    Category = categoryName,
                                    TotalParts = reader.GetInt32(1),
                                    TotalPrice = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                                    TotalOnHandQty = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
                                };
                                result.Add(partSummary);
                            }
                        }
                    }
                }
            }

            return Ok(result);
        }
    }
}