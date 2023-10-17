
namespace firewalld
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseFire = new System.Windows.Forms.Button();
            this.OpenFire = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Out = new System.Windows.Forms.RadioButton();
            this.In = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Port = new System.Windows.Forms.RadioButton();
            this.Application = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.local_addr = new System.Windows.Forms.TextBox();
            this.local_port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.remoteaddr = new System.Windows.Forms.TextBox();
            this.remoteport = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.move = new System.Windows.Forms.Label();
            this.file_addr1 = new System.Windows.Forms.TextBox();
            this.file_addr3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.file_addr = new System.Windows.Forms.TextBox();
            this.Typein = new System.Windows.Forms.RadioButton();
            this.Browse = new System.Windows.Forms.RadioButton();
            this.Drag = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Block = new System.Windows.Forms.RadioButton();
            this.Allow = new System.Windows.Forms.RadioButton();
            this.Rule_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UDP = new System.Windows.Forms.RadioButton();
            this.ICMP = new System.Windows.Forms.RadioButton();
            this.TCP = new System.Windows.Forms.RadioButton();
            this.description = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addrule = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Show = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pre = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ex_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseFire);
            this.groupBox1.Controls.Add(this.OpenFire);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Location = new System.Drawing.Point(11, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(124, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "防火墙";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CloseFire
            // 
            this.CloseFire.Location = new System.Drawing.Point(62, 57);
            this.CloseFire.Margin = new System.Windows.Forms.Padding(2);
            this.CloseFire.Name = "CloseFire";
            this.CloseFire.Size = new System.Drawing.Size(47, 34);
            this.CloseFire.TabIndex = 1;
            this.CloseFire.Text = "关闭";
            this.CloseFire.UseVisualStyleBackColor = true;
            this.CloseFire.Click += new System.EventHandler(this.CloseFire_Click);
            // 
            // OpenFire
            // 
            this.OpenFire.Location = new System.Drawing.Point(62, 19);
            this.OpenFire.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFire.Name = "OpenFire";
            this.OpenFire.Size = new System.Drawing.Size(47, 33);
            this.OpenFire.TabIndex = 1;
            this.OpenFire.Text = "打开";
            this.OpenFire.UseVisualStyleBackColor = true;
            this.OpenFire.Click += new System.EventHandler(this.OpenFire_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ControlText;
            this.status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status.Location = new System.Drawing.Point(13, 20);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(28, 71);
            this.status.TabIndex = 0;
            this.status.Paint += new System.Windows.Forms.PaintEventHandler(this.status_Paint);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Out);
            this.groupBox7.Controls.Add(this.In);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.Rule_name);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.description);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.addrule);
            this.groupBox7.Location = new System.Drawing.Point(186, 55);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(551, 675);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "添加规则";
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.Location = new System.Drawing.Point(202, 626);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(41, 16);
            this.Out.TabIndex = 3;
            this.Out.Text = "Out";
            this.Out.UseVisualStyleBackColor = true;
            // 
            // In
            // 
            this.In.AutoSize = true;
            this.In.Checked = true;
            this.In.Location = new System.Drawing.Point(140, 626);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(35, 16);
            this.In.TabIndex = 3;
            this.In.TabStop = true;
            this.In.Text = "In";
            this.In.UseVisualStyleBackColor = true;
            this.In.CheckedChanged += new System.EventHandler(this.In_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Port);
            this.groupBox6.Controls.Add(this.Application);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Location = new System.Drawing.Point(35, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(511, 365);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Details";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(18, 245);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(47, 16);
            this.Port.TabIndex = 1;
            this.Port.TabStop = true;
            this.Port.Text = "Port";
            this.Port.UseVisualStyleBackColor = true;
            this.Port.CheckedChanged += new System.EventHandler(this.Port_CheckedChanged);
            // 
            // Application
            // 
            this.Application.AutoSize = true;
            this.Application.Checked = true;
            this.Application.Location = new System.Drawing.Point(18, 26);
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(89, 16);
            this.Application.TabIndex = 1;
            this.Application.TabStop = true;
            this.Application.Text = "Application";
            this.Application.UseVisualStyleBackColor = true;
            this.Application.CheckedChanged += new System.EventHandler(this.Application_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.local_addr);
            this.groupBox9.Controls.Add(this.local_port);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.remoteaddr);
            this.groupBox9.Controls.Add(this.remoteport);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Location = new System.Drawing.Point(18, 272);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(487, 82);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Port";
            // 
            // local_addr
            // 
            this.local_addr.Location = new System.Drawing.Point(91, 20);
            this.local_addr.Name = "local_addr";
            this.local_addr.Size = new System.Drawing.Size(154, 21);
            this.local_addr.TabIndex = 5;
            this.local_addr.Text = "*";
            // 
            // local_port
            // 
            this.local_port.Location = new System.Drawing.Point(91, 50);
            this.local_port.Name = "local_port";
            this.local_port.Size = new System.Drawing.Size(154, 21);
            this.local_port.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "本地端口";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "本地地址";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // remoteaddr
            // 
            this.remoteaddr.Location = new System.Drawing.Point(327, 20);
            this.remoteaddr.Name = "remoteaddr";
            this.remoteaddr.Size = new System.Drawing.Size(154, 21);
            this.remoteaddr.TabIndex = 6;
            this.remoteaddr.Text = "*";
            // 
            // remoteport
            // 
            this.remoteport.Location = new System.Drawing.Point(327, 51);
            this.remoteport.Name = "remoteport";
            this.remoteport.Size = new System.Drawing.Size(154, 21);
            this.remoteport.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "远端端口";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "远程地址";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.move);
            this.groupBox8.Controls.Add(this.file_addr1);
            this.groupBox8.Controls.Add(this.file_addr3);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.file_addr);
            this.groupBox8.Controls.Add(this.Typein);
            this.groupBox8.Controls.Add(this.Browse);
            this.groupBox8.Controls.Add(this.Drag);
            this.groupBox8.Location = new System.Drawing.Point(18, 59);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(487, 180);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Application";
            // 
            // move
            // 
            this.move.AllowDrop = true;
            this.move.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.move.Location = new System.Drawing.Point(91, 19);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(60, 40);
            this.move.TabIndex = 2;
            this.move.Text = "拖拽文件到此处";
            this.move.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // file_addr1
            // 
            this.file_addr1.Location = new System.Drawing.Point(194, 26);
            this.file_addr1.Name = "file_addr1";
            this.file_addr1.Size = new System.Drawing.Size(197, 21);
            this.file_addr1.TabIndex = 1;
            // 
            // file_addr3
            // 
            this.file_addr3.Location = new System.Drawing.Point(149, 123);
            this.file_addr3.Name = "file_addr3";
            this.file_addr3.Size = new System.Drawing.Size(242, 21);
            this.file_addr3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 69);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "选择文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // file_addr
            // 
            this.file_addr.Location = new System.Drawing.Point(194, 76);
            this.file_addr.Margin = new System.Windows.Forms.Padding(2);
            this.file_addr.Name = "file_addr";
            this.file_addr.Size = new System.Drawing.Size(197, 21);
            this.file_addr.TabIndex = 1;
            // 
            // Typein
            // 
            this.Typein.AutoSize = true;
            this.Typein.Location = new System.Drawing.Point(17, 128);
            this.Typein.Name = "Typein";
            this.Typein.Size = new System.Drawing.Size(59, 16);
            this.Typein.TabIndex = 0;
            this.Typein.Text = "typein";
            this.Typein.UseVisualStyleBackColor = true;
            this.Typein.CheckedChanged += new System.EventHandler(this.Typein_CheckedChanged);
            // 
            // Browse
            // 
            this.Browse.AutoSize = true;
            this.Browse.Checked = true;
            this.Browse.Location = new System.Drawing.Point(17, 81);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(59, 16);
            this.Browse.TabIndex = 0;
            this.Browse.TabStop = true;
            this.Browse.Text = "browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.CheckedChanged += new System.EventHandler(this.Browse_CheckedChanged);
            // 
            // Drag
            // 
            this.Drag.AutoSize = true;
            this.Drag.Location = new System.Drawing.Point(17, 31);
            this.Drag.Name = "Drag";
            this.Drag.Size = new System.Drawing.Size(47, 16);
            this.Drag.TabIndex = 0;
            this.Drag.Text = "drag";
            this.Drag.UseVisualStyleBackColor = true;
            this.Drag.CheckedChanged += new System.EventHandler(this.Drag_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Block);
            this.groupBox5.Controls.Add(this.Allow);
            this.groupBox5.Location = new System.Drawing.Point(35, 165);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 81);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Action";
            // 
            // Block
            // 
            this.Block.AutoSize = true;
            this.Block.Location = new System.Drawing.Point(7, 58);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(53, 16);
            this.Block.TabIndex = 0;
            this.Block.Text = "block";
            this.Block.UseVisualStyleBackColor = true;
            this.Block.CheckedChanged += new System.EventHandler(this.Block_CheckedChanged);
            // 
            // Allow
            // 
            this.Allow.AutoSize = true;
            this.Allow.Checked = true;
            this.Allow.Location = new System.Drawing.Point(7, 36);
            this.Allow.Name = "Allow";
            this.Allow.Size = new System.Drawing.Size(53, 16);
            this.Allow.TabIndex = 0;
            this.Allow.TabStop = true;
            this.Allow.Text = "allow";
            this.Allow.UseVisualStyleBackColor = true;
            this.Allow.CheckedChanged += new System.EventHandler(this.Allow_CheckedChanged);
            // 
            // Rule_name
            // 
            this.Rule_name.Location = new System.Drawing.Point(63, 111);
            this.Rule_name.Name = "Rule_name";
            this.Rule_name.Size = new System.Drawing.Size(172, 21);
            this.Rule_name.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "名称";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UDP);
            this.groupBox4.Controls.Add(this.ICMP);
            this.groupBox4.Controls.Add(this.TCP);
            this.groupBox4.Location = new System.Drawing.Point(35, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 76);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Protocol";
            // 
            // UDP
            // 
            this.UDP.AutoSize = true;
            this.UDP.Location = new System.Drawing.Point(105, 21);
            this.UDP.Name = "UDP";
            this.UDP.Size = new System.Drawing.Size(41, 16);
            this.UDP.TabIndex = 0;
            this.UDP.Text = "UDP";
            this.UDP.UseVisualStyleBackColor = true;
            this.UDP.CheckedChanged += new System.EventHandler(this.UDP_CheckedChanged);
            // 
            // ICMP
            // 
            this.ICMP.AutoSize = true;
            this.ICMP.Location = new System.Drawing.Point(7, 46);
            this.ICMP.Name = "ICMP";
            this.ICMP.Size = new System.Drawing.Size(47, 16);
            this.ICMP.TabIndex = 0;
            this.ICMP.Text = "ICMP";
            this.ICMP.UseVisualStyleBackColor = true;
            this.ICMP.CheckedChanged += new System.EventHandler(this.ICMP_CheckedChanged);
            // 
            // TCP
            // 
            this.TCP.AutoSize = true;
            this.TCP.Checked = true;
            this.TCP.Location = new System.Drawing.Point(7, 21);
            this.TCP.Name = "TCP";
            this.TCP.Size = new System.Drawing.Size(41, 16);
            this.TCP.TabIndex = 0;
            this.TCP.TabStop = true;
            this.TCP.Text = "TCP";
            this.TCP.UseVisualStyleBackColor = true;
            this.TCP.CheckedChanged += new System.EventHandler(this.TCP_CheckedChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(63, 138);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(172, 21);
            this.description.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 630);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "方向";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "描述";
            // 
            // addrule
            // 
            this.addrule.Location = new System.Drawing.Point(321, 101);
            this.addrule.Margin = new System.Windows.Forms.Padding(2);
            this.addrule.Name = "addrule";
            this.addrule.Size = new System.Drawing.Size(67, 39);
            this.addrule.TabIndex = 2;
            this.addrule.Text = "添加";
            this.addrule.UseVisualStyleBackColor = true;
            this.addrule.Click += new System.EventHandler(this.addrule_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Show);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.pre);
            this.groupBox3.Location = new System.Drawing.Point(776, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 326);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "预览";
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(659, 34);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(82, 50);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(659, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pre
            // 
            this.pre.Location = new System.Drawing.Point(27, 34);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(582, 261);
            this.pre.TabIndex = 0;
            this.pre.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(776, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 333);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rules";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(922, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(118, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ex_result
            // 
            this.ex_result.Location = new System.Drawing.Point(12, 188);
            this.ex_result.Multiline = true;
            this.ex_result.Name = "ex_result";
            this.ex_result.Size = new System.Drawing.Size(124, 432);
            this.ex_result.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "执行结果";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 799);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ex_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel status;
        private System.Windows.Forms.Button CloseFire;
        private System.Windows.Forms.Button OpenFire;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addrule;
        private System.Windows.Forms.TextBox file_addr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox local_port;
        private System.Windows.Forms.TextBox local_addr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox remoteport;
        private System.Windows.Forms.TextBox remoteaddr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox pre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton UDP;
        private System.Windows.Forms.RadioButton ICMP;
        private System.Windows.Forms.RadioButton TCP;
        private System.Windows.Forms.TextBox Rule_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Block;
        private System.Windows.Forms.RadioButton Allow;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton Port;
        private System.Windows.Forms.RadioButton Application;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox file_addr1;
        private System.Windows.Forms.TextBox file_addr3;
        private System.Windows.Forms.RadioButton Typein;
        private System.Windows.Forms.RadioButton Browse;
        private System.Windows.Forms.RadioButton Drag;
        private System.Windows.Forms.Label move;
        private System.Windows.Forms.RadioButton In;
        private System.Windows.Forms.RadioButton Out;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ex_result;
        private System.Windows.Forms.Button Show;
    }
}

