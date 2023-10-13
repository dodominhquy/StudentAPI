using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace WinFormsAppAPI_QLSV
{
    public class QuanLySinhVien
    {
        HttpClient client = new HttpClient();
        string path = "https://localhost:7164/SinhVien";

        public async Task<string> GetProductAsync()
        {
            string product = "";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsStringAsync();
            }
            return product;
        }

        public async Task<int> CreateProductAsync(SinhVien sv)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    path, sv);
                if (response.IsSuccessStatusCode)
                    return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public async Task<int> DeleteProductAsync(string id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(
                    path + $"?Id={id}");
                if (response.IsSuccessStatusCode)
                    return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public async Task<int> UpdateProductAsync(SinhVien sv)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                path + $"?Id={sv.Id}", sv);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                    return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

    }
}
