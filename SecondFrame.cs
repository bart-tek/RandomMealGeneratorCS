using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMealApp
{
    public partial class SecondFrame : Form
    {
        public SecondFrame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void m_getMealButton_Click(object sender, EventArgs e)
        {
            MainFrame vMainFrame = new MainFrame();
            vMainFrame.Location = this.Location;
            vMainFrame.StartPosition = FormStartPosition.Manual;
            vMainFrame.FormClosing += delegate { Application.Exit(); };
            vMainFrame.Show();
            Hide();
        }
    }
}
