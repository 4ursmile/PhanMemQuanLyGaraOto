using PhanMemQuanLyGaraOto.Model;
using System;

namespace PhanMemQuanLyGaraOto.DDO
{
    public class REMCheckCar
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarNumber { get; set; }
        public string CarOwnerName { get; set; }
        public string CarOwnerTele { get; set; }
        public DateTime DateIn { get; set; }
        public decimal DebtMoney { get; set; }
        public short? TinhTrang { get; set; }
    }
}
