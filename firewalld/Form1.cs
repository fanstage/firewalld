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
using System.IO;
using System.Threading;

namespace firewalld
{
    public partial class Form1 : Form
    {
        string Rulename, Description, Fileaddr, LocalAddr, Remote_Addr,  netshCommand, Remote_Port;
        string PROTOCOL = "TCP";
        string Action = "allow";
        string Direction = "in";
        string LocalPort;
        private List<string> ruleNames = new List<string>();
        int op = 1;
        string filePath = "log.txt";
        string output;
        string currentTime;
        public Form1()
        {
            InitializeComponent();
        }
        private void RemoveRule()
        {
            if (ruleNames.Count > 0)
            {
                ruleNames.RemoveAt(0);
            }
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
            /*foreach (string ruleName in ruleNames)
            {
                string showCommand = "netsh advfirewall firewall show rule name=\"" + ruleName + "\"";
                ruleContent = ExecuteCommand(showCommand);
            }
                // 将规则内容展示在pre TextBox中
                pre.Text = string.Join(Environment.NewLine, ruleContent);*/
            List<string> ruleContentList = new List<string>(); // 定义一个列表来存储规则内容
            foreach (string ruleName in ruleNames)
            {
                string showCommand = "netsh advfirewall firewall show rule name=\"" + ruleName + "\"";
                List<string> ruleContentLines = ExecuteCommand(showCommand); // 获取规则内容行列表
                string ruleContent = string.Join(Environment.NewLine, ruleContentLines); // 将规则内容行列表连接成一个字符串
                ruleContentList.Add(ruleContent); // 将规则内容添加到列表中
            }
            // 将规则内容展示在pre TextBox中
            pre.Text = string.Join(Environment.NewLine, ruleContentList);
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
            /*string showCommand = "netsh advfirewall firewall delete rule name=\"" + ruleNames[0] + "\"";
            ExecuteCommand(showCommand);*/
            if (ruleNames.Count > 0)
            {
                string ruleNameToDelete = ruleNames[0]; // 获取第一个规则名称
                string deleteCommand = "netsh advfirewall firewall delete rule name=\"" + ruleNameToDelete + "\"";
                ExecuteCommand(deleteCommand); // 执行删除规则的命令
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }
                string currentTime = DateTime.Now.ToString();
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(currentTime + "  netsh " + deleteCommand); // 写入当前时间
                }
                // 从ruleNames列表中移除已删除的规则名称
                ruleNames.RemoveAt(0);
            }
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

        private void pre_TextChanged(object sender, EventArgs e)
        {

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
            Rulename = Rule_name.Text;
            Description = description.Text;
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
                if (Fileaddr != "")
                {
                    netshCommand = $"advfirewall firewall add rule name=\"{Rulename}\" description=\"{Description}\" dir=\"{Direction}\" protocol= \"{PROTOCOL}\" action=\"{Action}\" program=\"{Fileaddr}\" enable=yes";
                }
            }
            else if (op == 2)
            {
                if (local_addr.Text != null && local_port.Text != null && remoteaddr.Text != null)
                {
                    LocalAddr = local_addr.Text;
                    LocalPort = local_port.Text;
                    //LocalPort = Convert.ToInt32(local_port.Text);
                    Remote_Addr = remoteaddr.Text;
                    if (remoteport.Text == "")
                    {
                        netshCommand = $"advfirewall firewall add rule name=\"{Rulename}\" description=\"{Description}\" dir=\"{Direction}\" protocol= \"{PROTOCOL}\" action=\"{Action}\" localip= \"{LocalAddr}\" localport={LocalPort} remoteip=\"{Remote_Addr}\" enable=yes";
                    }
                    else
                    {
                        Remote_Port = remoteport.Text;
                        netshCommand = $"advfirewall firewall add rule name=\"{Rulename}\" description=\"{Description}\" dir=\"{Direction}\" protocol= \"{PROTOCOL}\" action=\"{Action}\" localip= \"{LocalAddr}\" localport={LocalPort} remoteip=\"{Remote_Addr}\" remoteport={Remote_Port} enable=yes";
                    }
                }
            }
            Process process = new Process();
            process.StartInfo.FileName = "netsh.exe";
            process.StartInfo.Arguments = netshCommand;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            Thread thread = new Thread(() =>
            {
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                process.Close();
            });
            thread.Start();
            ex_result.Text = output;
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            string currentTime = DateTime.Now.ToString();
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(currentTime+ "  netsh " + netshCommand +"  " + output); // 写入当前时间 + output
            }
            if (ruleNames.Count == 2)
            {
                ruleNames.RemoveAt(0);
            }
            ruleNames.Add(Rulename);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void move_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
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
