namespace firewalld
{
    partial class ModifyForm
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ruletype = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.enable = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.fileaddr = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.localaddr = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.localport = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.remoteaddr = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.remoteport = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.protocol = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.savebt = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Controls.Add(this.description);
            this.flowLayoutPanel2.Controls.Add(this.label19);
            this.flowLayoutPanel2.Controls.Add(this.ruletype);
            this.flowLayoutPanel2.Controls.Add(this.label21);
            this.flowLayoutPanel2.Controls.Add(this.enable);
            this.flowLayoutPanel2.Controls.Add(this.label20);
            this.flowLayoutPanel2.Controls.Add(this.fileaddr);
            this.flowLayoutPanel2.Controls.Add(this.label22);
            this.flowLayoutPanel2.Controls.Add(this.localaddr);
            this.flowLayoutPanel2.Controls.Add(this.label23);
            this.flowLayoutPanel2.Controls.Add(this.localport);
            this.flowLayoutPanel2.Controls.Add(this.label24);
            this.flowLayoutPanel2.Controls.Add(this.remoteaddr);
            this.flowLayoutPanel2.Controls.Add(this.label25);
            this.flowLayoutPanel2.Controls.Add(this.remoteport);
            this.flowLayoutPanel2.Controls.Add(this.label26);
            this.flowLayoutPanel2.Controls.Add(this.protocol);
            this.flowLayoutPanel2.Controls.Add(this.label27);
            this.flowLayoutPanel2.Controls.Add(this.direction);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(253, 39);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(295, 281);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "描述";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(38, 3);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(234, 21);
            this.description.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "规则类型";
            // 
            // ruletype
            // 
            this.ruletype.Location = new System.Drawing.Point(62, 30);
            this.ruletype.Name = "ruletype";
            this.ruletype.ReadOnly = true;
            this.ruletype.Size = new System.Drawing.Size(216, 21);
            this.ruletype.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "Enabled";
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(56, 57);
            this.enable.Name = "enable";
            this.enable.ReadOnly = true;
            this.enable.Size = new System.Drawing.Size(234, 21);
            this.enable.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "本地路径";
            // 
            // fileaddr
            // 
            this.fileaddr.Location = new System.Drawing.Point(62, 84);
            this.fileaddr.Name = "fileaddr";
            this.fileaddr.ReadOnly = true;
            this.fileaddr.Size = new System.Drawing.Size(216, 21);
            this.fileaddr.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "本地地址";
            // 
            // localaddr
            // 
            this.localaddr.Location = new System.Drawing.Point(62, 111);
            this.localaddr.Name = "localaddr";
            this.localaddr.Size = new System.Drawing.Size(216, 21);
            this.localaddr.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "本地端口";
            // 
            // localport
            // 
            this.localport.Location = new System.Drawing.Point(62, 138);
            this.localport.Name = "localport";
            this.localport.Size = new System.Drawing.Size(216, 21);
            this.localport.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "远程地址";
            // 
            // remoteaddr
            // 
            this.remoteaddr.Location = new System.Drawing.Point(62, 165);
            this.remoteaddr.Name = "remoteaddr";
            this.remoteaddr.Size = new System.Drawing.Size(216, 21);
            this.remoteaddr.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "远程端口";
            // 
            // remoteport
            // 
            this.remoteport.Location = new System.Drawing.Point(62, 192);
            this.remoteport.Name = "remoteport";
            this.remoteport.Size = new System.Drawing.Size(216, 21);
            this.remoteport.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 216);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "协议类型";
            // 
            // protocol
            // 
            this.protocol.Location = new System.Drawing.Point(62, 219);
            this.protocol.Name = "protocol";
            this.protocol.ReadOnly = true;
            this.protocol.Size = new System.Drawing.Size(216, 21);
            this.protocol.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 243);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "方向";
            // 
            // direction
            // 
            this.direction.Location = new System.Drawing.Point(38, 246);
            this.direction.Name = "direction";
            this.direction.ReadOnly = true;
            this.direction.Size = new System.Drawing.Size(234, 21);
            this.direction.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label16);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.label17);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(253, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(295, 281);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "label16";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "label16";
            // 
            // savebt
            // 
            this.savebt.Location = new System.Drawing.Point(339, 338);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(87, 33);
            this.savebt.TabIndex = 2;
            this.savebt.Text = "save";
            this.savebt.UseVisualStyleBackColor = true;
            this.savebt.Click += new System.EventHandler(this.savebt_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.savebt);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ruletype;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox enable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox fileaddr;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox localaddr;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox localport;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox remoteaddr;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox remoteport;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox protocol;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox direction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button savebt;
    }
}