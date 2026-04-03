using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pentaliza
{
    public partial class Form1 : Form
    {
        bool flag = true; //for flag=true it's x's turn
        int i;
        string turn;
        int counter=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void checking()
        {
            List<Button> b = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };
            if (flag) turn = "X";
            else turn = "O";
            // checking rows
            for (int i = 0; i <= 20; i+=5)
            {
                if (b[i].Text == b[i + 1].Text && b[i].Text == b[i + 2].Text && b[i].Text == b[i + 3].Text && b[i].Text == b[i + 4].Text && b[i].Text != "")
                {
                    MessageBox.Show("Player "+turn+" won");
                    cleanup(b);
                }
            }
            //checking columns
            for (int i = 0; i < 5; i++)
            {
                if (b[i].Text == b[i + 5].Text && b[i].Text == b[i + 10].Text && b[i].Text == b[i + 15].Text && b[i].Text == b[i + 20].Text && b[i].Text != "")
                {
                    MessageBox.Show("Player " + turn + " won");
                    cleanup(b);
                }
            }
            // checking upper diagonal
            i = 0;
            if (b[i].Text == b[i + 6].Text && b[i].Text == b[i + 12].Text && b[i].Text == b[i + 18].Text && b[i].Text == b[i + 24].Text && b[i].Text != "")
            {
                MessageBox.Show("Player " + turn + " won");
                cleanup(b);
            }
            // checking bottom diagonal
            i = 20;
            if (b[i].Text == b[i - 4].Text && b[i].Text == b[i - 8].Text && b[i].Text == b[i - 12].Text && b[i].Text == b[i - 16].Text && b[i].Text != "")
            {
                MessageBox.Show("Player " + turn + " won");
                cleanup(b);
            }
            //checking draw
            for (i = 0; i < 25; i++)
            {
                if (b[i].Text != "") counter++;
            }
            if (counter == 25)
            {
                MessageBox.Show("It's a draw...");
                cleanup(b);
            }
            else counter = 0;
        }

        private void buttonclicked(object sender, EventArgs e)
        {
            Button butc = (Button)sender;
            if (butc.Text == "")
            {
                if (flag)
                {
                    butc.Text = "X";
                }
                else
                {
                    butc.Text = "O";
                }
                checking();
                if (flag) label1.Text = ("Playing next: O");
                else label1.Text = ("Playing next:X");
                flag = !flag;
            }
        }
        private void cleanup(List<Button>b)
        {
            for (i=0; i < 25; i++)
            {
                b[i].Text = "";
            }
        }
    }
}
