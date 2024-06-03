using System.Windows.Forms;
using System.Drawing;
namespace Products_Management.PL
{
    partial class FRM_PRODUCTS
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
            label1 = new Label();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 42);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 0;
            label1.Text = "قم بادخال الكلمة المراد البحث عنها :";
            label1.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(344, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(435, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 431);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "لائحة المنتجات";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1098, 403);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 519);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1110, 96);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            // 
            // button8
            // 
            button8.Location = new Point(407, 51);
            button8.Name = "button8";
            button8.Size = new Size(169, 23);
            button8.TabIndex = 7;
            button8.Text = "الخروج";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(582, 51);
            button7.Name = "button7";
            button7.Size = new Size(169, 23);
            button7.TabIndex = 6;
            button7.Text = "حفظ اللائحة في ملف اكسيل";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(24, 22);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 5;
            button4.Text = "طباعة كل المنتجات";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(186, 22);
            button5.Name = "button5";
            button5.Size = new Size(166, 23);
            button5.TabIndex = 4;
            button5.Text = "طباعة المنتج المحدد";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(358, 22);
            button6.Name = "button6";
            button6.Size = new Size(176, 23);
            button6.TabIndex = 3;
            button6.Text = "صورة المنتج";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(540, 22);
            button3.Name = "button3";
            button3.Size = new Size(169, 23);
            button3.TabIndex = 2;
            button3.Text = "تعديل بيانات المنتج";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(715, 22);
            button2.Name = "button2";
            button2.Size = new Size(180, 23);
            button2.TabIndex = 1;
            button2.Text = "حذف المنتج المحدد";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(901, 22);
            button1.Name = "button1";
            button1.Size = new Size(172, 23);
            button1.TabIndex = 0;
            button1.Text = "اضافة منتج جديد";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FRM_PRODUCTS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 635);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "FRM_PRODUCTS";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نافذة ادارة المنتجات";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        public DataGridView dataGridView1;
    }
}