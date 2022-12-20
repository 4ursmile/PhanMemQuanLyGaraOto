using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {
       public async Task<List<CustomBaoCao>> GetBaoCaosAsync(int thang, int nam)
        {
            try
            {
                using (var db = new GARAOTOEntities())
                {
                    decimal Total = (decimal)await db.PHIEUSUACHUAs.Where(j => j.NGAYLAP.Value.Month == thang && j.NGAYLAP.Value.Year == nam).SumAsync(a => a.TONGTIEN);
                    var baocao = await Task.Run(() => db.GETCHITIETBAOCAO(thang, nam).Select(a => new CustomBaoCao
                    {
                        tenHangXe = a.TENHIEUXE,
                        soLuotSua = a.SOLUOTSUA,
                        tongTien = a.THANHTIEN,
                        tyLe = Convert.ToDouble(a.THANHTIEN / Total) * 100
                    }).ToList<CustomBaoCao>());                  
                    return baocao;
                }
            } catch
            {
                return new List<CustomBaoCao>();
            }
        }
        public async Task<List<GETBAOCAOTON_Result>> GETBAOCAOTONsAsync(int thang, int nam)
        {
            try
            {
                using (var db = new GARAOTOEntities())
                {
                    List<GETBAOCAOTON_Result> results = await Task.Run(() => db.GETBAOCAOTON(thang, nam).ToList<GETBAOCAOTON_Result>());
                    return results;
                }
            }
            catch
            {
                return new List<GETBAOCAOTON_Result>();
            }
        }
    }

}
