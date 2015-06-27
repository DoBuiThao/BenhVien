using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BenhNhan
    {
        private string _MaBenhNhan;
        private string _TenBenhNhan;
        private string _CMND;
        private string _NgaySinh;
        private string _DiaChi;
        private string _SDT;
        private string _MaPhongKham;
        public string MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }

        public string TenBenhNhan
        {
            get { return _TenBenhNhan; }
            set { _TenBenhNhan = value; }
        }

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public string MaPhongKham
        {
            get { return _MaPhongKham; }
            set { _MaPhongKham = value; }
        }

    }
}
