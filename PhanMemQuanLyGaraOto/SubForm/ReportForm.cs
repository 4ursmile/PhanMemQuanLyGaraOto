using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, System.EventArgs e)
        {

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
        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiposeToRoot(this);
        }
    }
}
