using PhanMemQuanLyGaraOto.Model;
using System;

namespace PhanMemQuanLyGaraOto.DDO
{
    public class REMCheckCar
    {
        public int CarId { get; set; }
        public int CarBrandID { get; set; }
        public string CarBrand { get; set; }
        public string CarNumber { get; set; }
        public string CarOwnerName { get; set; }
        public string CarOwnerTele { get; set; }
        public int CarOwnerCarID { get; set; }
        public DateTime DateIn { get; set; }
        public decimal DebtMoney { get; set; }


        public REMCheckCar(XE xe, CHUXE cx, HIEUXE hx)
        {
            CarId = xe.MAXE;
            CarNumber = xe.BIENXO;
            if (hx != null)
            {
                CarBrandID = hx.MAHIEUXE;
                CarBrand = hx.TENHIEUXE;
            }
            if (cx != null)
            {
                CarOwnerName = cx.TENCHUXE;
                CarOwnerCarID = (int)xe.MACHUXE;
                CarOwnerTele = cx.DIENTHOAI;
            }
            DebtMoney = (decimal)xe.TONGNO;
            DateIn = (DateTime)xe.NGAYTIEPNHAN;

        }
    }
}
