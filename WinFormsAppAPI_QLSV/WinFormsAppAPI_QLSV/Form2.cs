using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppAPI_QLSV
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        public async void LoadData()
        {
            try
            {
                QuanLySinhVien qlsv = new QuanLySinhVien();
                string kq = await qlsv.GetProductAsync();
                DataTable? dt = new DataTable();
                dt = JsonConvert.DeserializeObject<DataTable>(kq);
                dgvHienSV.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvHienSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHienSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTimId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
