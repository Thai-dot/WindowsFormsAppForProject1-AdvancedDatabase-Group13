
namespace WindowsFormsApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtime_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.tb_MAKH = new System.Windows.Forms.TextBox();
            this.tb_MAHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_doanhthu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_doanhthu);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.bt_khoitao);
            this.groupBox5.Controls.Add(this.bt_them);
            this.groupBox5.Controls.Add(this.dtime_ngaylap);
            this.groupBox5.Controls.Add(this.tb_MAKH);
            this.groupBox5.Controls.Add(this.tb_MAHD);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_khoitao.ForeColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.bt_khoitao, "bt_khoitao");
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.UseVisualStyleBackColor = false;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.ForeColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.bt_them, "bt_them");
            this.bt_them.Name = "bt_them";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtime_ngaylap
            // 
            this.dtime_ngaylap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtime_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtime_ngaylap, "dtime_ngaylap");
            this.dtime_ngaylap.MaxDate = new System.DateTime(2300, 1, 1, 0, 0, 0, 0);
            this.dtime_ngaylap.MinDate = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.dtime_ngaylap.Name = "dtime_ngaylap";
            // 
            // tb_MAKH
            // 
            resources.ApplyResources(this.tb_MAKH, "tb_MAKH");
            this.tb_MAKH.Name = "tb_MAKH";
            // 
            // tb_MAHD
            // 
            resources.ApplyResources(this.tb_MAHD, "tb_MAHD");
            this.tb_MAHD.Name = "tb_MAHD";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tb_doanhthu
            // 
            resources.ApplyResources(this.tb_doanhthu, "tb_doanhthu");
            this.tb_doanhthu.Name = "tb_doanhthu";
            this.tb_doanhthu.TextChanged += new System.EventHandler(this.tb_doanhthu_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label6);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtime_ngaylap;
        private System.Windows.Forms.TextBox tb_MAKH;
        private System.Windows.Forms.TextBox tb_MAHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_doanhthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}

