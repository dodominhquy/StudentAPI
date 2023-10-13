using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms;

namespace WinFormsAppAPI_QLSV
{
    public partial class Form1 : Form
    {
        SinhVien? rowSelected = new SinhVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            try
            {
                QuanLySinhVien qlsv = new QuanLySinhVien();
                string kq = await qlsv.GetProductAsync();
                DataTable? dt = new DataTable();
                dt = JsonConvert.DeserializeObject<DataTable>(kq);
                dgvDSSV.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        public SinhVien getForm()
        {
            SinhVien sv = new SinhVien();
            sv.Id = tbId.Text;
            sv.Ten = tbTen.Text;
            sv.GioiTinh = tbGioiTinh.Text;
            sv.Tuoi = Convert.ToInt32(tbTuoi.Text);
            sv.DiemToan = (float)Double.Parse(tbDiemToan.Text);
            sv.DiemVan = (float)Double.Parse(tbDiemVan.Text);
            sv.DiemAnh = (float)Double.Parse(tbDiemAnh.Text);
            sv.DiemTB = (float)Double.Parse(tbDiemTB.Text);
            sv.HocLuc = tbHocLuc.Text;
            return sv;
        }

        private void setForm(SinhVien? sv)
        {
            if (sv != null)
            {
                tbId.Text = sv.Id;
                tbTen.Text = sv.Ten;
                tbGioiTinh.Text = sv.GioiTinh;
                tbTuoi.Text = sv.Tuoi.ToString();
                tbDiemToan.Text = sv.DiemToan.ToString();
                tbDiemVan.Text = sv.DiemVan.ToString();
                tbDiemAnh.Text = sv.DiemAnh.ToString();
                tbDiemTB.Text = sv.DiemTB.ToString();
                tbHocLuc.Text = sv.HocLuc;

            }
            else
            {
                tbId.Text = "";
                tbTen.Text = "";
                tbGioiTinh.Text = "";
                tbTuoi.Text = "";
                tbDiemToan.Text = "";
                tbDiemVan.Text = "";
                tbDiemAnh.Text = "";
                tbDiemTB.Text = "";
                tbHocLuc.Text = "";
            }
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dgv_row = dgvDSSV.Rows[index];
            rowSelected = new SinhVien();
            rowSelected.Id = dgv_row.Cells[0].Value.ToString();
            rowSelected.Ten = dgv_row.Cells[1].Value.ToString();
            rowSelected.GioiTinh = dgv_row.Cells[2].Value.ToString();
            rowSelected.Tuoi = Convert.ToInt32(dgv_row.Cells[3].Value.ToString());
            rowSelected.DiemToan = (float)Convert.ToDouble(dgv_row.Cells[4].Value.ToString());
            rowSelected.DiemVan = (float)Convert.ToDouble(dgv_row.Cells[5].Value.ToString());
            rowSelected.DiemAnh = (float)Convert.ToDouble(dgv_row.Cells[6].Value.ToString());
            rowSelected.DiemTB = (float)Convert.ToDouble(dgv_row.Cells[7].Value.ToString());
            rowSelected.HocLuc = dgv_row.Cells[8].Value.ToString();
            setForm(rowSelected);
        }

        private async void btnThem_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = getForm();
                QuanLySinhVien qlsv = new QuanLySinhVien();
                var kq = await qlsv.CreateProductAsync(sv);
                if (kq > 0)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = getForm();
                QuanLySinhVien qlsv = new QuanLySinhVien();
                var kq = await qlsv.UpdateProductAsync(sv);
                if (kq > 0)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien qlsv = new QuanLySinhVien();
                var kq = await qlsv.DeleteProductAsync(rowSelected.Id);
                if (kq > 0)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}