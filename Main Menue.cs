using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class Main_Menue : Form
    {
        public Main_Menue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnP2PForm_Click(object sender, EventArgs e)
        {
            Form form = new P2P_Game();
            form.ShowDialog();
        }


    }
}
