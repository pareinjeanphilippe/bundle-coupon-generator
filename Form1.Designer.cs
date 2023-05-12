namespace bundle_coupon_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            listView1 = new ListView();
            SelectAll = new Button();
            SelectNone = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCustomPrice = new TextBox();
            txtCodeCoupon = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_csv_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(168, 42);
            button1.TabIndex = 1;
            button1.Text = "Import CSV Formations";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "*.csv";
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(513, 245);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // SelectAll
            // 
            SelectAll.BackColor = Color.Transparent;
            SelectAll.FlatAppearance.BorderSize = 0;
            SelectAll.FlatStyle = FlatStyle.Flat;
            SelectAll.Image = (Image)resources.GetObject("SelectAll.Image");
            SelectAll.Location = new Point(498, 28);
            SelectAll.Name = "SelectAll";
            SelectAll.Size = new Size(27, 26);
            SelectAll.TabIndex = 3;
            SelectAll.UseVisualStyleBackColor = false;
            SelectAll.Click += SelectAll_Click;
            // 
            // SelectNone
            // 
            SelectNone.FlatAppearance.BorderSize = 0;
            SelectNone.FlatStyle = FlatStyle.Flat;
            SelectNone.Image = (Image)resources.GetObject("SelectNone.Image");
            SelectNone.Location = new Point(476, 28);
            SelectNone.Name = "SelectNone";
            SelectNone.Size = new Size(27, 26);
            SelectNone.TabIndex = 4;
            SelectNone.UseVisualStyleBackColor = true;
            SelectNone.Click += SelectNone_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_csv_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(86, 224);
            button2.Name = "button2";
            button2.Size = new Size(134, 48);
            button2.TabIndex = 5;
            button2.Text = "Export du CSV";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCustomPrice);
            groupBox1.Controls.Add(txtCodeCoupon);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(542, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 293);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Traitement";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 141);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 13;
            label5.Text = "Code coupon";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 30);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 12;
            label4.Text = "Prix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 79);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Heure";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 10;
            label2.Text = "Date validité";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 9;
            label1.Text = "Type Coupon";
            // 
            // txtCustomPrice
            // 
            txtCustomPrice.Location = new Point(212, 48);
            txtCustomPrice.Name = "txtCustomPrice";
            txtCustomPrice.Size = new Size(61, 23);
            txtCustomPrice.TabIndex = 8;
            txtCustomPrice.TextChanged += txtCustomPrice_TextChanged;
            // 
            // txtCodeCoupon
            // 
            txtCodeCoupon.Location = new Point(20, 159);
            txtCodeCoupon.Name = "txtCodeCoupon";
            txtCodeCoupon.Size = new Size(185, 23);
            txtCodeCoupon.TabIndex = 7;
            txtCodeCoupon.TextChanged += txtCodeCoupon_TextChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "\"HH:mm\"";
            dateTimePicker2.Location = new Point(212, 97);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(61, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "free_open", "best_price", "custom_price", "free_targeted" });
            comboBox1.Location = new Point(18, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 315);
            Controls.Add(groupBox1);
            Controls.Add(SelectNone);
            Controls.Add(SelectAll);
            Controls.Add(listView1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BundleCouponGenerator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
        private Button SelectAll;
        private Button SelectNone;
        private Button button2;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox txtCodeCoupon;
        private TextBox txtCustomPrice;
        private SaveFileDialog saveFileDialog1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}