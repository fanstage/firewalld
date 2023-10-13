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
        string PROTOCOL, Rulename, Description, Action, Fileaddr,LocalAddr, LocalPort, Remote_Addr, Remote_Port, Direction, netshCommand;
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
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "deleteColumn";
            deleteButtonColumn.Text = "删除";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "modifyColumn";
            modifyButtonColumn.Text = "修改";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(modifyButtonColumn);
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
            if(TCP.Checked) 
            { 
                PROTOCOL = "TCP";
            }
            else if (UDP.Checked)
            {
                PROTOCOL = "UDP";
            }
            else if (ICMP.Checked)
            {
                PROTOCOL = "ICMP";
            }
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
            if (Allow.Checked)
            {
                Action = "Allow";
            }
            else if (Block.Checked)
            {
                Action = "Block";
            }
            if (Application.Checked)
            {
                /*if(Drag.Checked)
                {

                }*/
                if (Browse.Checked)
                {
                    if (file_addr.Text != null)
                    {
                        Fileaddr = file_addr.Text;
                    }
                    else
                    {
                        MessageBox.Show("请选择文件！");
                    }
                }
                else if (Typein.Checked)
                {
                    if (file_addr3.Text != null)
                    {
                        Fileaddr = file_addr3.Text;
                    }
                    else
                    {
                        MessageBox.Show("请输入文件路径！");
                    }
                }
                netshCommand = "advfirewall firewall add rule name=\"" + Rulename + "\" dir=in "  + Action + " protocol=" + PROTOCOL + " program=" + Fileaddr + " enable=yes";
            }
            else if (Port.Checked)
            {
                if (local_addr.Text != null && local_port.Text != null && remoteaddr.Text != null && remoteport.Text != null)
                {
                    LocalAddr = local_addr.Text;
                    LocalPort = local_port.Text;
                    Remote_Addr = remoteaddr.Text;
                    Remote_Port = remoteport.Text;
                    if(In.Checked)
                    { 
                        Direction = "in";
                    }
                    else if(Out.Checked)
                    {
                        Direction = "out";
                    }
                    netshCommand = "advfirewall firewall add rule name=" + Rulename + " dir=" + Direction + " action="+ Action + " protocol=" + PROTOCOL + " localport=" + LocalPort + " remoteip=" + Remote_Addr + " remoteport=" + Remote_Port + " enable=yes";
                }
                else
                {
                    MessageBox.Show("请输入完整的端口信息！");
                }
            }

            // 创建一个Process实例
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = netshCommand;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            // 启动进程
            process.Start();

            // 读取输出结果
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            pre.Text = output;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Type policyType = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 policy = (INetFwPolicy2)Activator.CreateInstance(policyType);

            // 获取防火墙规则集合
            INetFwRules rules = policy.Rules;

            // 处理删除按钮
            if (e.ColumnIndex == dataGridView1.Columns["deleteColumn"].Index)
            {
                DialogResult result = MessageBox.Show("您确定要删除此规则吗？", "确认", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) 
                {
                    // 获取要删除的规则名称
                    string ruleName = dataGridView1.Rows[e.RowIndex].Cells["描述"].Value.ToString();

                    // 删除规则
                    rules.Remove(ruleName);

                    // 从 DataGridView 中删除行
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                
            }
            if (e.ColumnIndex == dataGridView1.Columns["modifyColumn"].Index)
            {
                // 获取要修改的规则名称
                string ruleName = dataGridView1.Rows[e.RowIndex].Cells["描述"].Value.ToString();

                // 获取要修改的规则
                INetFwRule rule = rules.Item(ruleName);

                // 打开修改窗口
                ModifyForm modifyForm = new ModifyForm(rule);
                modifyForm.ShowDialog();
            }*/
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
