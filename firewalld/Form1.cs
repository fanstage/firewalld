using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace firewalld
{
    public partial class Form1 : Form
    {
        string Rulename, Description, Fileaddr, LocalAddr, LocalPort, Remote_Addr, Remote_Port, netshCommand;
        string PROTOCOL = "TCP";
        string Action = "allow";
        string Direction = "in";
        int op = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CloseFire_Click(object sender, EventArgs e)
        {
            //关闭防火墙
            Process proc = new Process();
            string top = "netsh.exe";
            proc.StartInfo.Arguments = "Advfirewall set allprofiles state off";
            proc.StartInfo.FileName = top;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            status.BackColor = Color.Red;
        }

        private void OpenFire_Click(object sender, EventArgs e)
        {
            //打开防火墙
            Process proc = new Process();
            string top = "netsh.exe";
            proc.StartInfo.Arguments = "Advfirewall set allprofiles state on";
            proc.StartInfo.FileName = top;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            status.BackColor = Color.Green;
        }

        private void status_Paint(object sender, PaintEventArgs e)
        {

        }
        private static NetFwTypeLib.INetFwMgr GetFirewallManager()
        {
            const string CLSID_FIREWALL_MANAGER = "{304CE942-6E39-40D8-943A-B913C40C9CD4}";
            Type objType = Type.GetTypeFromCLSID(new Guid(CLSID_FIREWALL_MANAGER));
            return Activator.CreateInstance(objType) as NetFwTypeLib.INetFwMgr;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var table = new DataTable();
            table.Columns.Add("名称", typeof(string));
            table.Columns.Add("描述",typeof(string));
            table.Columns.Add("类型", typeof(string));
            table.Columns.Add("Enabled", typeof(string));
            table.Columns.Add("本地路径", typeof(string));
            table.Columns.Add("本地地址", typeof(string));
            table.Columns.Add("本地端口", typeof(string));
            table.Columns.Add("远程地址", typeof(string));
            table.Columns.Add("远程端口", typeof(string));
            table.Columns.Add("Protocol", typeof(string));
            table.Columns.Add("Direction",typeof(string));
            List<string> rules = new List<string>();
            INetFwMgr netFwMgr = GetFirewallManager();
            if (netFwMgr.LocalPolicy.CurrentProfile.FirewallEnabled == true)
            {
                status.BackColor = Color.Green;
            }
            else
            {
                status.BackColor = Color.Red;
            }
            Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(type);
            INetFwRules fwRules = fwPolicy2.Rules;
            foreach (INetFwRule rule in fwRules)
            {
                //rules.Add(rule.Name);
                table.Rows.Add(rule.Name,rule.Description,rule.Action,rule.Enabled,rule.ApplicationName,rule.LocalAddresses,rule.LocalPorts,rule.RemoteAddresses,rule.RemotePorts,rule.Protocol,rule.Direction);
            }
            dataGridView1.DataSource = table;
        }

        private void TCP_CheckedChanged(object sender, EventArgs e)
        {
            if (TCP.Checked)
            {
                PROTOCOL = "TCP";
            }
        }

        private void UDP_CheckedChanged(object sender, EventArgs e)
        {
            if (UDP.Checked)
            {
                PROTOCOL = "UDP";
            }
        }

        private void ICMP_CheckedChanged(object sender, EventArgs e)
        {
            if (ICMP.Checked)
            {
                PROTOCOL = "ICMP";
            }
        }

        private void Allow_CheckedChanged(object sender, EventArgs e)
        {
            if (Allow.Checked)
            {
                Action = "allow";
            }
        }

        private void Block_CheckedChanged(object sender, EventArgs e)
        {
            if (Block.Checked)
            {
                Action = "block";
            }
        }

        private void Application_CheckedChanged(object sender, EventArgs e)
        {
            if (Application.Checked)
            {
                op = 1;
            }
        }

        private void Port_CheckedChanged(object sender, EventArgs e)
        {
            if (Port.Checked)
            {
                op = 2;
            }
        }

        private void Drag_CheckedChanged(object sender, EventArgs e)
        {
            if (Drag.Checked)
            {
                Fileaddr = file_addr1.Text;
            }
        }

        private void Browse_CheckedChanged(object sender, EventArgs e)
        {
            if (Browse.Checked)
            {
                Fileaddr = file_addr.Text;
            }
        }

        private void Typein_CheckedChanged(object sender, EventArgs e)
        {
            if (Typein.Checked)
            {
                Fileaddr = file_addr3.Text;
            }
        }

        private void In_CheckedChanged(object sender, EventArgs e)
        {
            if (In.Checked)
            {
                Direction = "in";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static void StopFirewallService()
        {
            ServiceController sc = new ServiceController("MpsSvc");
            if (sc.Status != ServiceControllerStatus.Stopped)
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string showCommand = "netsh advfirewall firewall show rule name=\"" + Rulename + "\"";
            List<string> ruleContent = ExecuteCommand(showCommand);

            // 将规则内容展示在pre TextBox中
            pre.Text = string.Join(Environment.NewLine, ruleContent);
        }
        private List<string> ExecuteCommand(string command)
        {
            // 创建一个ProcessStartInfo对象来设置进程属性
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe"; // 指定要执行的命令行程序
            startInfo.Arguments = "/c " + command; // 指定要执行的命令
            startInfo.RedirectStandardOutput = true; // 重定向标准输出
            startInfo.UseShellExecute = false; // 不使用操作系统外壳程序启动进程
            startInfo.CreateNoWindow = true; // 不创建窗口
                                             // 创建一个Process对象并启动进程
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            // 读取命令行输出结果
            List<string> outputLines = new List<string>();
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                outputLines.Add(line);
            }
            // 等待进程执行完毕
            process.WaitForExit();
            return outputLines;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string showCommand = "netsh advfirewall firewall show rule name=\"" + Rulename + "\"";
            ExecuteCommand(showCommand);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 创建 OpenFileDialog 实例
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置文件对话框的标题
            openFileDialog.Title = "选择文件";

            // 设置文件对话框的初始目录
            openFileDialog.InitialDirectory = @"C:\";

            // 设置文件对话框的过滤器
            openFileDialog.Filter = "所有文件 (*.*)|*.*";

            // 显示文件对话框
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选定文件的路径
                string filePath = openFileDialog.FileName;

                // 将文件路径显示在文本框中
                file_addr.Text = filePath;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            table.Columns.Add("描述", typeof(string));
            table.Columns.Add("类型", typeof(string));
            table.Columns.Add("Enabled", typeof(string));
            table.Columns.Add("本地路径", typeof(string));
            table.Columns.Add("本地地址", typeof(string));
            table.Columns.Add("本地端口", typeof(string));
            table.Columns.Add("远程地址", typeof(string));
            table.Columns.Add("远程端口", typeof(string));
            table.Columns.Add("Protocol", typeof(string));
            table.Columns.Add("Direction", typeof(string));
            List<string> rules = new List<string>();
            INetFwMgr netFwMgr = GetFirewallManager();
            if (netFwMgr.LocalPolicy.CurrentProfile.FirewallEnabled == true)
            {
                status.BackColor = Color.Green;
            }
            else
            {
                status.BackColor = Color.Red;
            }
            Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(type);
            INetFwRules fwRules = fwPolicy2.Rules;
            foreach (INetFwRule rule in fwRules)
            {
                //rules.Add(rule.Name);
                table.Rows.Add(rule.Description, rule.Action, rule.Enabled, rule.ApplicationName, rule.LocalAddresses, rule.LocalPorts, rule.RemoteAddresses, rule.RemotePorts, rule.Protocol, rule.Direction);
            }
            //dataGridView1.DataSource = table;
        }

        private void addrule_Click(object sender, EventArgs e)
        {
            if(Rule_name.Text !=  null)
            {
                Rulename = Rule_name.Text;
            }
            else
            {
                MessageBox.Show("请输入规则名称！");
            }
            if(description.Text != null)
            {
                Description = description.Text;
            }
            else
            {
                MessageBox.Show("请输入规则描述！");
            }
            if (op == 1)
            {
                if(Browse.Checked)
                {
                    Fileaddr = file_addr.Text;
                }
                else if(Drag.Checked)
                {
                    Fileaddr = file_addr1.Text;
                }
                else if(Typein.Checked)
                {
                    Fileaddr = file_addr3.Text;
                }
                if (Fileaddr != null)
                {
                    netshCommand = $"advfirewall firewall add rule name=\"{Rulename}\" description=\"{Description}\" dir=\"{Direction}\" protocol= \"{PROTOCOL}\" action=\"{Action}\" program=\"{Fileaddr}\" enable=yes";
                    Console.WriteLine(netshCommand);
                }
                else
                {
                    MessageBox.Show("请输入文件地址！");
                }
            }
            else if (op == 2)
            {
                if (local_addr.Text != null && local_port.Text != null && remoteaddr.Text != null && remoteport.Text != null)
                {
                    LocalAddr = local_addr.Text;
                    LocalPort = local_port.Text;
                    Remote_Addr = remoteaddr.Text;
                    Remote_Port = remoteport.Text;
                    netshCommand = $"advfirewall firewall add rule name=\"{Rulename}\" dir=\"{Direction}\" protocol= \"{PROTOCOL}\" action=\"{Action}\" localip= \"{LocalAddr}\" localport=\"{LocalPort}\" remoteip=\"{Remote_Addr}\" remoteport=\"{Remote_Port}\" enable=yes";
                }
                else
                {
                    MessageBox.Show("请输入完整的端口信息！");
                }
            }
            else
            {
                MessageBox.Show("发生错误，请检查输入的内容再重新添加");
            }
            Process process = new Process();
            process.StartInfo.FileName = "netsh.exe";
            process.StartInfo.Arguments = netshCommand;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            // 启动进程
            process.Start();
            // 读取输出结果
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            ex_result.Text = output;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void move_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // 允许拖放操作
                e.Effect = DragDropEffects.All;
            }
            else
            {
                // 不允许拖放操作
                e.Effect = DragDropEffects.None;
            }
        }
        private void move_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            file_addr1.Text = filePath;
        }

        private void move_Click(object sender, EventArgs e)
        {

        }
    }
}
