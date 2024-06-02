using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();

        private static FRM_PRODUCTS frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);

                }
                return frm;
            }

        }
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null) frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PreviewDataTable(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("The DataTable is empty.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            // Iterate through the rows
            foreach (DataRow row in dt.Rows)
            {
                // Iterate through the columns
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append(column.ColumnName + ": " + row[column].ToString() + " ");
                }
                sb.AppendLine();
            }

            // Display the contents of the DataTable
            MessageBox.Show(sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SearchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtRef.ReadOnly = true;
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث المنتج:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.state = "update";
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);

            frm.btnOk.Text = "تحديث";
            frm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_IMAGE_PREVIEW frm = new FRM_IMAGE_PREVIEW();
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }
    }
}
