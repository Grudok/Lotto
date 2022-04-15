using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {

        

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Tipp_1_Click(object sender, EventArgs e)
        {
            List<int> userNums = new List<int>();
            List<int> lottoNums = new List<int>();

            userNums.Add(Convert.ToInt32(Txt_Box_1.Text));
            userNums.Add(Convert.ToInt32(Txt_Box_2.Text));
            userNums.Add(Convert.ToInt32(Txt_Box_3.Text));
<
            Random lottoNums = new Random();

            lottoNums.Add(lottoNums.Next(1, 4));
            lottoNums.Add(lottoNums.Next(1, 5));
            lottoNums.Add(lottoNums.Next(1, 6));

            lottoNums.Remove(userNums[0]);
            lottoNums.Remove(userNums[1]);
            lottoNums.Remove(userNums[2]);

            if (lottoNums.Count == 0)
                Lbl_1.Text = "You didnt get any matches";
            else if (lottoNums.Count == 1)
                Lbl_1.Text = "You made one match!";
            else if (lottoNums.Count == 2)
                Lbl_1.Text = "You made two matches!";
            else if (lottoNums.Count == 3)
                Lbl_1.Text = "You made three matches, jackpot!";

            
        }
           

       
       

        private void Btn_Ende_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
