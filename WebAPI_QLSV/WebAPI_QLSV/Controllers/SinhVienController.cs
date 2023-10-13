using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace WebAPI_QLSV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SinhVienController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            Provider p = new Provider();
            DataTable dt = p.Select(CommandType.Text, "SELECT * FROM SINHVIEN");
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dt);
            return JSONString;
        }

        [HttpPost]
        public void Post([FromBody] SinhVien sv)
        {
            Provider p = new Provider();
            string query1 = " INSERT INTO SINHVIEN(ID,TEN,GIOITINH,TUOI,DIEMTOAN,DIEMVAN,DIEMANH,DIEMTB,HOCLUC) " +
                " VALUES(@ID,@TEN,@GIOITINH,@TUOI,@DIEMTOAN,@DIEMVAN,@DIEMANH,@DIEMTB,@HOCLUC) ";
            p.ExcuteNonQuery(CommandType.Text, query1,
                new SqlParameter { ParameterName = "@ID", Value = sv.Id },
                new SqlParameter { ParameterName = "@TEN", Value = sv.Ten },
                new SqlParameter { ParameterName = "@GIOITINH", Value = sv.GioiTinh },
                new SqlParameter { ParameterName = "@TUOI", Value = sv.Tuoi },
                new SqlParameter { ParameterName = "@DIEMTOAN", Value = sv.DiemToan },
                new SqlParameter { ParameterName = "@DIEMVAN", Value = sv.DiemVan },
                new SqlParameter { ParameterName = "@DIEMANH", Value = sv.DiemAnh },
                new SqlParameter { ParameterName = "@DIEMTB", Value = sv.DiemTB },
                new SqlParameter { ParameterName = "@HOCLUC", Value = sv.HocLuc });
        }

        [HttpPut]
        public void Update(string Id, [FromBody] SinhVien sv)
        {
            Provider p = new Provider();
            string query1 = "UPDATE SINHVIEN " +
                " SET TEN = @TEN, GIOITINH = @GIOITINH, TUOI = @TUOI, DIEMTOAN = @DIEMTOAN, DIEMVAN = @DIEMVAN, DIEMANH = @DIEMANH, DIEMTB = @DIEMTB, HOCLUC = @HOCLUC" +
                " WHERE ID = @ID";
            p.ExcuteNonQuery(CommandType.Text, query1,
                new SqlParameter { ParameterName = "@ID", Value = sv.Id },
                new SqlParameter { ParameterName = "@TEN", Value = sv.Ten },
                new SqlParameter { ParameterName = "@GIOITINH", Value = sv.GioiTinh },
                new SqlParameter { ParameterName = "@TUOI", Value = sv.Tuoi },
                new SqlParameter { ParameterName = "@DIEMTOAN", Value = sv.DiemToan },
                new SqlParameter { ParameterName = "@DIEMVAN", Value = sv.DiemVan },
                new SqlParameter { ParameterName = "@DIEMANH", Value = sv.DiemAnh },
                new SqlParameter { ParameterName = "@DIEMTB", Value = sv.DiemTB },
                new SqlParameter { ParameterName = "@HOCLUC", Value = sv.HocLuc });
        }

        [HttpDelete]
        public int Delete(string id)
        {
            Provider p = new Provider();
            int nRow = 0;
            String query = "DELETE FROM SINHVIEN WHERE ID = @ID";
            nRow = p.ExcuteNonQuery(CommandType.Text, query,
                new SqlParameter { ParameterName = "@ID", Value = id });
            return nRow;
        }

        [HttpGet("{id}")]
        public IActionResult GetId(string id)
        {
            Provider p = new Provider();
            DataTable dt = p.Select(CommandType.Text, "SELECT * FROM SINHVIEN WHERE ID = @Id", 
                new SqlParameter("@Id", id));
            if (dt.Rows.Count > 0)
            {
                string JSONString = JsonConvert.SerializeObject(dt);
                return Ok(JSONString);
            }
            else
            {
                return NotFound();
            }
        }
    }

}