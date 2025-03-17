using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_O.Properties;

namespace X_O
{
    public partial class P2P_Game : Form
    {
        private int NumberOfButtonsSelected = 0;
        public P2P_Game()
        {
            InitializeComponent();
        }
        private void P2P_Game_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }
        private void P2P_Game_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
        private void ChangePlayerNumber()
        {
            if (lblPlayerNum.Text == "1") lblPlayerNum.Text = "2";
            else if (lblPlayerNum.Text == "2") lblPlayerNum.Text = "1";
        }
        public void ChangeButton(Button btn)
        {
            NumberOfButtonsSelected += 1;
            if (btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Already Chosen!", "Notice");
                return;
            }
            if(lblPlayerNum.Text == "1")
            {
                btn.Image = Resources.X;
                btn.Tag = "X";
            }
            if(lblPlayerNum.Text == "2")
            {
                btn.Image = Resources.O;
                btn.Tag = "O";
            }
            ChangePlayerNumber();
        }
        public void ResetButton(Button btn)
        {
            btn.Tag = "?";
            btn.Image = Resources.Q;
            btn.BackColor = Color.Transparent;
        }
        public void DefineThreeEqualButtons(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.Green;
            btn3.BackColor = Color.Green;
            btn2.BackColor = Color.Green;
        }
        public bool IsEqual(Button btn1, Button btn2, Button btn3)
        {
            if ((btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag) && btn1.Tag.ToString() != "?")
            {
                DefineThreeEqualButtons(btn1, btn2, btn3);
                return true;
            }
            return false;
        }
        public bool IsWin_ner(string label)
        {
            return (
               (IsEqual(btn1, btn2, btn3) && btn1.Tag.ToString() == label) ||
               (IsEqual(btn4, btn5, btn6) && btn4.Tag.ToString() == label) ||
               (IsEqual(btn7, btn8, btn9) && btn7.Tag.ToString() == label) ||
               (IsEqual(btn2, btn5, btn8) && btn2.Tag.ToString() == label) ||
               (IsEqual(btn3, btn6, btn9) && btn3.Tag.ToString() == label) ||
               (IsEqual(btn1, btn5, btn9) && btn5.Tag.ToString() == label) ||
               (IsEqual(btn1, btn4, btn7) && btn5.Tag.ToString() == label) ||
               (IsEqual(btn3, btn5, btn7) && btn5.Tag.ToString() == label)
               );         
        }
        public void Winner()
        {
            if (NumberOfButtonsSelected == 9)
            {
                lblWinner.Text = " draw";
                MessageBox.Show("Game Over", "The End");
                DisableAllExcept();
                return;
            }
            if (!IsWin_ner("X") && !IsWin_ner("O")) return;
            if (IsWin_ner("X"))
            {
                lblWinner.Text = "Player 1";
            }
            else if (IsWin_ner("O"))
            {
                lblWinner.Text = "Player 2";
            }
            MessageBox.Show("Game Over", "The End");
            DisableAllExcept();
        }
        public void DisableAllExcept(Button button1 = null, Button button2 = null, Button button3 = null)
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            lblPlayerNum.Enabled = false;
            if(button1 != null && button2 != null && button3 != null)
            {            
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            //lblWinner.Enabled = false;

        }
        public void EnableAll()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            lblPlayerNum.Enabled = true;
            lblWinner.Enabled = true;

        }


        private void btn_Click(object sender, MouseEventArgs e)
        {
            ChangeButton((Button)sender);
            Winner();
        }

        private void button7_Click(object sender, MouseEventArgs e)
        {
            NumberOfButtonsSelected = 0;
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);
            lblWinner.Text = "In Progress";
            lblPlayerNum.Text = "1"; EnableAll();
        }
    }
}
