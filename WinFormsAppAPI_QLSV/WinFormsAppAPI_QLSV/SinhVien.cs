using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppAPI_QLSV
{
    public class SinhVien
    {
        private string? _id;
        private string? _ten;
        private string? _gioiTinh;
        private int _tuoi;
        private float _diemToan;
        private float _diemVan;
        private float _diemAnh;
        private float _diemTB;
        private string? _hocLuc;

        public string? Id { get => _id; set => _id = value; }
        public string? Ten { get => _ten; set => _ten = value; }
        public string? GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public int Tuoi { get => _tuoi; set => _tuoi = value; }
        public float DiemToan { get => _diemToan; set => _diemToan = value; }
        public float DiemVan { get => _diemVan; set => _diemVan = value; }
        public float DiemAnh { get => _diemAnh; set => _diemAnh = value; }
        public float DiemTB { get => _diemTB; set => _diemTB = value; }
        public string? HocLuc { get => _hocLuc; set => _hocLuc = value; }
    }
}
