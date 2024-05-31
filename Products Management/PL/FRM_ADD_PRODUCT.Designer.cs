namespace Products_Management.PL
{
    partial class FRM_ADD_PRODUCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_PRODUCT));
            label1 = new Label();
            cmbCategories = new ComboBox();
            txtRef = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDes = new TextBox();
            label4 = new Label();
            txtQte = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            pbox = new PictureBox();
            button1 = new Button();
            btnCancel = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "تصنيف المنتج:";
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(118, 42);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(233, 23);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // txtRef
            // 
            txtRef.Location = new Point(118, 92);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(233, 23);
            txtRef.TabIndex = 0;
            txtRef.Validated += txtRef_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 100);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "معرف المنتج:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 143);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "وصف المنتج:";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(118, 143);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.ScrollBars = ScrollBars.Vertical;
            txtDes.Size = new Size(233, 79);
            txtDes.TabIndex = 1;
            txtDes.Text = "ر";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 262);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 7;
            label4.Text = "الكمية المخزنة:";
            // 
            // txtQte
            // 
            txtQte.Location = new Point(118, 254);
            txtQte.Name = "txtQte";
            txtQte.Size = new Size(233, 23);
            txtQte.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 312);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "ثمن المنتج:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(118, 304);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(233, 23);
            txtPrice.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 285);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 10;
            label6.Text = "ثمن المنتج:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 356);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 11;
            label7.Text = "صورة المنتج:";
            // 
            // pbox
            // 
            pbox.Image = (Image)resources.GetObject("pbox.Image");
            pbox.Location = new Point(118, 356);
            pbox.Name = "pbox";
            pbox.Size = new Size(233, 99);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 12;
            pbox.TabStop = false;
            pbox.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 471);
            button1.Name = "button1";
            button1.Size = new Size(233, 23);
            button1.TabIndex = 4;
            button1.Text = "تحميل صورة";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(244, 527);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(347, 527);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 14;
            btnOk.Text = "حفظ";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // FRM_ADD_PRODUCT
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 584);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(button1);
            Controls.Add(pbox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtQte);
            Controls.Add(label3);
            Controls.Add(txtDes);
            Controls.Add(label2);
            Controls.Add(txtRef);
            Controls.Add(cmbCategories);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FRM_ADD_PRODUCT";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " اضافة منتج جديد:";
            Load += FRM_ADD_PRODUCT_Load;
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCategories;
        private TextBox txtRef;
        private Label label2;
        private Label label3;
        private TextBox txtDes;
        private Label label4;
        private TextBox txtQte;
        private Label label5;
        private TextBox txtPrice;
        private Label label6;
        private Label label7;
        private PictureBox pbox;
        private Button button1;
        private Button btnCancel;
        private Button btnOk;
    }
}