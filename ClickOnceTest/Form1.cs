using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickOnceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ApplicationDeployment.IsNetworkDeployed)
            {
                return;
            }

            // 起動URLを表示
            MessageBox.Show(ApplicationDeployment.CurrentDeployment.UpdateLocation.AbsoluteUri);
        }
    }
}
