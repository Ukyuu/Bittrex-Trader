using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Bittrex_2.Views;

namespace My_Bittrex_2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            MainView mainView = new MainView();
            MainApp.Controls.Add(mainView);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
