using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFwTypeLib;

namespace firewalld
{
    public partial class ModifyForm : Form
    {
        private INetFwRule rule;
        public ModifyForm(INetFwRule rule)
        {
            InitializeComponent();
            this.rule = rule;

            // 初始化控件的值
            description.Text = rule.Description;
            ruletype.Text = Convert.ToString(rule.Action);
            enable.Text = Convert.ToString(rule.Enabled);
            fileaddr.Text = rule.ApplicationName;
            localaddr.Text = rule.LocalAddresses;
            localport.Text = rule.LocalPorts;
            remoteaddr.Text = rule.RemoteAddresses;
            remoteport.Text = rule.RemotePorts;
            protocol.Text = Convert.ToString(rule.Protocol);
            direction.Text = Convert.ToString(rule.Direction);
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        private void savebt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要保存修改吗？", "确认", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                rule.LocalAddresses = localaddr.Text;
                rule.LocalPorts = localport.Text;
                rule.RemoteAddresses = remoteaddr.Text;
                rule.RemotePorts = remoteport.Text;
                this.Close();
            }
        }
    }
}
