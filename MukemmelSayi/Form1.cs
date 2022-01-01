using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemmelSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long num;
        int total = 0;

        private void btnFind_Click(object sender, EventArgs e)
        {
            lboxPerfect.Items.Clear();
            if(tboxNum.Text == "")
            {
                MessageBox.Show("Please Input Number", "Alert");
            }
            else
            {
                num = long.Parse(tboxNum.Text);
                for (int i = 6; i<=num; i++)
                {
                    for(int j = 1; j<=i/2; j++)
                    {
                        if(i % j == 0)
                        {
                            total += j; 
                        }
                    }
                    if(total == i)
                    {
                        lboxPerfect.Items.Add(i);
                    }
                    total = 0;
                }
            }
        }

        private void tboxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
