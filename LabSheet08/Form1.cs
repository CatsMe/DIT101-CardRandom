using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet08
{
    public partial class Form1 : Form
    {
        int[] comDeck;
        int topIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button currentBututton = (Button)sender;
            //MessageBox.Show(currentBututton.Text);

            lblInfo.Text = "Player " + currentBututton.Text + " Computer " +
                comDeck[topIndex];

            if (Convert.ToInt32(currentBututton.Text) > comDeck[topIndex])
            {
                lblInfo.Text += " Player Win!!";
                lblPlayerPoint.Text = (Convert.ToInt32(lblPlayerPoint.Text) + 1)
                    .ToString();
            }

            currentBututton.Enabled = false;
            topIndex++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            comDeck = new int[15];

            Random rnd =new Random();
            int tmpIndex;

            for(int card = 1; card <= 15; card++)
            {
                tmpIndex = rnd.Next(15);

                while (comDeck[tmpIndex] != 0)
                {
                    tmpIndex = (tmpIndex + 1)%15;
                }

                comDeck[tmpIndex] = card;
            }

            topIndex = 0;

            foreach (Control t in this.Controls)
            {
                if (t is Button)
                {
                    t.Enabled = true;
                }
            }
        }
    }
}
