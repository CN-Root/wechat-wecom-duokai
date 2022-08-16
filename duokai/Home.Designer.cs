
namespace shuangkai
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.copyright = new System.Windows.Forms.Label();
            this.rootlink = new System.Windows.Forms.LinkLabel();
            this.time_nian = new System.Windows.Forms.Label();
            this.banquan = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wechat_shuangkai = new System.Windows.Forms.PictureBox();
            this.wework_shuangkai = new System.Windows.Forms.PictureBox();
            this.wechat_path = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wechat_time = new System.Windows.Forms.Timer(this.components);
            this.wework_time = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.banquan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wechat_shuangkai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wework_shuangkai)).BeginInit();
            this.SuspendLayout();
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copyright.Location = new System.Drawing.Point(44, 2);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(96, 20);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "Copyright © ";
            // 
            // rootlink
            // 
            this.rootlink.AutoSize = true;
            this.rootlink.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.rootlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.rootlink.Location = new System.Drawing.Point(132, 2);
            this.rootlink.Name = "rootlink";
            this.rootlink.Size = new System.Drawing.Size(112, 20);
            this.rootlink.TabIndex = 4;
            this.rootlink.TabStop = true;
            this.rootlink.Text = "root.tax(根目录)";
            this.rootlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rootlink_LinkClicked);
            // 
            // time_nian
            // 
            this.time_nian.AutoSize = true;
            this.time_nian.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.time_nian.Location = new System.Drawing.Point(239, 2);
            this.time_nian.Name = "time_nian";
            this.time_nian.Size = new System.Drawing.Size(41, 20);
            this.time_nian.TabIndex = 5;
            this.time_nian.Text = "1970";
            // 
            // banquan
            // 
            this.banquan.Controls.Add(this.rootlink);
            this.banquan.Controls.Add(this.copyright);
            this.banquan.Controls.Add(this.time_nian);
            this.banquan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.banquan.Location = new System.Drawing.Point(0, 148);
            this.banquan.Name = "banquan";
            this.banquan.Size = new System.Drawing.Size(337, 25);
            this.banquan.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(28, 26);
            this.textBox1.MaxLength = 2;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 60);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "2";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // wechat_shuangkai
            // 
            this.wechat_shuangkai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wechat_shuangkai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wechat_shuangkai.Image = global::duokai.Properties.Resources.WeChat;
            this.wechat_shuangkai.Location = new System.Drawing.Point(124, 26);
            this.wechat_shuangkai.Name = "wechat_shuangkai";
            this.wechat_shuangkai.Size = new System.Drawing.Size(90, 60);
            this.wechat_shuangkai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wechat_shuangkai.TabIndex = 8;
            this.wechat_shuangkai.TabStop = false;
            this.wechat_shuangkai.Click += new System.EventHandler(this.wechat_shuangkai_Click);
            // 
            // wework_shuangkai
            // 
            this.wework_shuangkai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wework_shuangkai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wework_shuangkai.Image = global::duokai.Properties.Resources.WXWork;
            this.wework_shuangkai.Location = new System.Drawing.Point(220, 26);
            this.wework_shuangkai.Name = "wework_shuangkai";
            this.wework_shuangkai.Size = new System.Drawing.Size(90, 60);
            this.wework_shuangkai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wework_shuangkai.TabIndex = 9;
            this.wework_shuangkai.TabStop = false;
            this.wework_shuangkai.Click += new System.EventHandler(this.wework_shuangkai_Click);
            // 
            // wechat_path
            // 
            this.wechat_path.AutoSize = true;
            this.wechat_path.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wechat_path.Location = new System.Drawing.Point(5, 95);
            this.wechat_path.Name = "wechat_path";
            this.wechat_path.Size = new System.Drawing.Size(79, 20);
            this.wechat_path.TabIndex = 10;
            this.wechat_path.Text = "微信路径：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "企微路径：";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(74, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(254, 23);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(74, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(254, 23);
            this.textBox3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 80);
            this.label2.TabIndex = 14;
            this.label2.Text = "双\r\n开\r\n数\r\n量";
            // 
            // wechat_time
            // 
            this.wechat_time.Interval = 1;
            this.wechat_time.Tick += new System.EventHandler(this.wechat_time_Tick);
            // 
            // wework_time
            // 
            this.wework_time.Interval = 1;
            this.wework_time.Tick += new System.EventHandler(this.wework_time_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "点击图标后切莫着急,让子弹飞一会.";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wechat_path);
            this.Controls.Add(this.wework_shuangkai);
            this.Controls.Add(this.wechat_shuangkai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.banquan);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信-企业微信双开神器";
            this.Load += new System.EventHandler(this.Home_Load);
            this.banquan.ResumeLayout(false);
            this.banquan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wechat_shuangkai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wework_shuangkai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.LinkLabel rootlink;
        private System.Windows.Forms.Label time_nian;
        private System.Windows.Forms.Panel banquan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox wechat_shuangkai;
        private System.Windows.Forms.PictureBox wework_shuangkai;
        private System.Windows.Forms.Label wechat_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer wechat_time;
        private System.Windows.Forms.Timer wework_time;
        private System.Windows.Forms.Label label3;
    }
}