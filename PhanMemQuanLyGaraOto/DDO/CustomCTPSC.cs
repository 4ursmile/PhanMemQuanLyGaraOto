using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyGaraOto.DDO
{
    public class CustomCTPSC
    {
        public int MACTPSC { get; set; }
        public Nullable<int> MAPHIEU { get; set; }
        public Nullable<int> MANDTC { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<decimal> TIENCONG { get; set; }
        public Nullable<int> MAPHUTUNG { get; set; }
        public string TENPHUTUNG { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<decimal> DONGIA { get; set; }
        public Nullable<decimal> THANHTIEN { get; set; }
    }
}
