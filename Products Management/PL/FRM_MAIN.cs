using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
            this.المنجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخهمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void إنشاءنسخهاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm=new FRM_LOGIN();
            frm.ShowDialog();
        }
    }
}
