using PhanMemQuanLyGaraOto.Class;
using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.Model;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class PolicyForm : Form
    {
        public PolicyForm()
        {
            InitializeComponent();
            initValue();
            SwitchStateControl(UniversalUser.Ins.account.TYPE < 2);
        }
        void SwitchStateControl(bool state = false)
        {
            foreach (Control control in ControlPanel.Controls)
            {
                control.Enabled = state;
            }
        }
        void initValue()
        {
            nudMaxFixTimes.Controls[0].Visible = false;
            nudProfitRate.Controls[0].Visible = false;
            thuVuotChi = DataProvider.Instance.getBoolInOverOut();
            soXeSuaChuaToiDa = DataProvider.Instance.getSoXeSuaChuaToiDa();
            tyLeGiaPhuTungBanRa = DataProvider.Instance.getTyLeLinhKienBanRa();
            nudMaxFixTimes.Value = (int)soXeSuaChuaToiDa.GIATRI;
            nudProfitRate.Value = (int)tyLeGiaPhuTungBanRa.GIATRI;
            if (thuVuotChi.GIATRI == 0)
            {
                btbToggleChange.CheckState = CheckState.Unchecked;
                lblState.Text = "Không cho phép";
            }  else
            {
                btbToggleChange.CheckState = CheckState.Checked;
                lblState.Text = "Cho phép";
            }
            toggleNotiData.CheckState = CheckState.Checked;
            toggleNotiGeneRal.CheckState = CheckState.Checked;
        }
        void DiposeToRoot(Control k)
        {
            if (k == null) return;
            foreach (Control e in k.Controls)
            {
                e.Dispose();

                DiposeToRoot(e);
            }
            k.Dispose();
        }
        private void PolicyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiposeToRoot(this);
        }
        public THAMSO thuVuotChi;
        public THAMSO soXeSuaChuaToiDa;
        public THAMSO tyLeGiaPhuTungBanRa;
        private void btbToggleChange_Click(object sender, System.EventArgs e)
        {

        }

        private void btbMaxFixChange_Click(object sender, System.EventArgs e)
        {
            if (MesseageBoxStatic.MessageBoxQuestion($"Bạn có muốn thay đổi số lần sửa xe tối đa từ {soXeSuaChuaToiDa.GIATRI} thành {(int)nudMaxFixTimes.Value} hay không?") == DialogResult.Yes) {
                soXeSuaChuaToiDa.GIATRI = (int)nudMaxFixTimes.Value;
                DataProvider.Instance.UpdatePolicy(soXeSuaChuaToiDa);
                ReloadDataEvent.Ins.Alert(DataType.Policy);
            }
        }

        private void btbProfitChange_Click(object sender, System.EventArgs e)
        {
            if (MesseageBoxStatic.MessageBoxQuestion($"Bạn có muốn thay đổi tỷ lệ giá phụ tùng bán ra từ {tyLeGiaPhuTungBanRa.GIATRI} thành {(int)nudProfitRate.Value} hay không?") == DialogResult.Yes)
            {
                tyLeGiaPhuTungBanRa.GIATRI = (int)nudProfitRate.Value;
                DataProvider.Instance.UpdatePolicy(soXeSuaChuaToiDa);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string target = "https://www.linkedin.com/in/bao-ly-tran-hoang-252739229/";
            System.Diagnostics.Process.Start(target);
        }

        private void toggleNotiData_CheckedChanged(object sender, System.EventArgs e)
        {
            if (toggleNotiData.CheckState == CheckState.Checked)
            {
                UniversalSetting.Instance.isNotiDataOn = true;
            } else
            {
                UniversalSetting.Instance.isNotiDataOn = false;
            }
        }

        private void btbToggleChange_CheckedChanged(object sender, System.EventArgs e)
        {
            if (btbToggleChange.CheckState == CheckState.Checked)
            {
                if (MesseageBoxStatic.MessageBoxQuestion("Bạn có muốn cho phép thu vượt quá chi hay không?") == DialogResult.Yes)
                {
                    thuVuotChi.GIATRI = 1;
                    DataProvider.Instance.UpdatePolicy(thuVuotChi);
                    lblState.Text = "Cho phép";
                }
                else
                {
                    btbToggleChange.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                thuVuotChi.GIATRI = 0;
                DataProvider.Instance.UpdatePolicy(thuVuotChi);
                lblState.Text = "Không cho phép";
            }
        }

        private void toggleNotiGeneRal_CheckedChanged(object sender, System.EventArgs e)
        {
            if (toggleNotiGeneRal.CheckState == CheckState.Checked)
            {
                UniversalSetting.Instance.isNotiGeneralOn = true;
            }
            else
            {
                UniversalSetting.Instance.isNotiGeneralOn = false;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string target = "https://github.com/UIT-21521109/PhanMemQuanLyGaraOto";
            System.Diagnostics.Process.Start(target);
        }
    }
}
