using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class PolicyForm : Form
    {
        public PolicyForm()
        {
            InitializeComponent();
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
    }
}
