using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_MAIN : Form
    {

        private static FRM_MAIN frm;
        
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_MAIN getMainForm
        {
            get
                {
                if (frm == null)
                {
                    frm=new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);

                }   
                return frm; 
            }

        }
        public FRM_MAIN()
        {
            
            InitializeComponent();
            if (frm == null) frm = this;
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
