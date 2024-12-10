
namespace tcping
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.continuousPingCheckBox = new System.Windows.Forms.CheckBox();
            this.Topdisplay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tcping
            // 
            this.tcping.Location = new System.Drawing.Point(244, 12);
            this.tcping.Name = "tcping";
            this.tcping.Size = new System.Drawing.Size(75, 23);
            this.tcping.TabIndex = 0;
            this.tcping.Text = "开始";
            this.tcping.UseVisualStyleBackColor = true;
            this.tcping.Click += new System.EventHandler(this.tcping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口:";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(47, 14);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 21);
            this.IP.TabIndex = 3;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(193, 14);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(45, 21);
            this.Port.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(20, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 208);
            this.listBox1.TabIndex = 5;
            // 
            // continuousPingCheckBox
            // 
            this.continuousPingCheckBox.AutoSize = true;
            this.continuousPingCheckBox.Location = new System.Drawing.Point(47, 55);
            this.continuousPingCheckBox.Name = "continuousPingCheckBox";
            this.continuousPingCheckBox.Size = new System.Drawing.Size(72, 16);
            this.continuousPingCheckBox.TabIndex = 6;
            this.continuousPingCheckBox.Text = "持续PING";
            this.continuousPingCheckBox.UseVisualStyleBackColor = true;
            // 
            // Topdisplay
            // 
            this.Topdisplay.AutoSize = true;
            this.Topdisplay.Location = new System.Drawing.Point(193, 55);
            this.Topdisplay.Name = "Topdisplay";
            this.Topdisplay.Size = new System.Drawing.Size(72, 16);
            this.Topdisplay.TabIndex = 7;
            this.Topdisplay.Text = "顶层显示";
            this.Topdisplay.UseVisualStyleBackColor = true;
            this.Topdisplay.CheckedChanged += new System.EventHandler(this.Topdisplay_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 303);
            this.Controls.Add(this.Topdisplay);
            this.Controls.Add(this.continuousPingCheckBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcping);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "tcping检测工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tcping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox continuousPingCheckBox;
        private System.Windows.Forms.CheckBox Topdisplay;
    }
}

