using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public string state = "add";
        public FRM_ADD_PRODUCT()
        {

            InitializeComponent();
            cmbCategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.BMP;.*JPEG;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                prd.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtRef.Text, txtDes.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                MessageBox.Show("تم الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                prd.UPDATE_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtRef.Text, txtDes.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FRM_PRODUCTS.getMainForm.dataGridView1.DataSource=prd.GET_ALL_PRODUCTS();   
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
           if(state=="add"){ DataTable dt = new DataTable();
            dt = prd.VerifyProductID(txtRef.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
