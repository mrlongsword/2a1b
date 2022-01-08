using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2a1b
{
    public partial class Form1 : Form
    {
        /*public static class Global
        {
            public static string guess { get; set; }
        };*/
        public bool play = false;
        public static string guess = "";
        public string randnum = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//play
        {
            textBox1.ReadOnly = false;
            play_btn.Visible = false;
            tutorial_btn.Visible = false;
            tutorial.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Back_btn.Visible = false;
            title.Visible = false;
            textBox1.Visible = true;
            // your_guess.Visible = true;
            //  output.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button1.Visible = true;
            textBox2.Text = "";
            Random random = new Random();
            List<int> randomList = new List<int>();
            int tmp = random.Next(10);
            while ((!randomList.Contains(tmp)) && randomList.Count<4)
            {
                randomList.Add(tmp);
                tmp = random.Next(10);
            };
            
            for(int i=0;i<randomList.Count;i++)
            {
                randnum += randomList[i].ToString();
            }
            // randnum = random.Next(10).ToString() + random.Next(10).ToString() + random.Next(10).ToString() + random.Next(10).ToString();
            //Console.WriteLine(randnum);
            
        }

        private void button2_Click(object sender, EventArgs e)//tutorial
        {
            tutorial.Visible = true;
            play_btn.Visible = false;
            tutorial_btn.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Back_btn.Visible = true;

        }

        private void tutorial_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            tutorial.Visible = false;
            play_btn.Visible = true;
            tutorial_btn.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Back_btn.Visible = false;
        }

        private void input_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                //Console.WriteLine(textBox1.Text);
                guess= textBox1.Text.ToString();
                textBox1.Text = "";
                Console.WriteLine("guess:" + guess);
                Console.WriteLine("randnum:" + randnum);
                
                int A = 0;
                int B = 0;
                for(int i=0;i<4;i++)
                {
                    for(int j=0;j<4;j++)
                    {
                        if(randnum[i] == guess[j])
                        {
                            B++;
                            if(i==j)
                            {
                                A++;
                                B--;
                            }
                        }
                    }
                }
                Console.WriteLine(A + "a" + B + "b");
                //your_guess.Text = your_guess.Text + guess+"\n";
               // output.Text = output.Text + A.ToString() + "a" + B.ToString() + "b" + "\n";
                string space = new String(' ', 19);
                string newtext = guess + space + A.ToString() + "a" + B.ToString() + "b" + "\r\n";
                textBox2.AppendText(newtext);

                //textBox2.Text = textBox2.Text + guess + space +  A.ToString() + "a" + B.ToString() + "b" + "\r\n";
                //textBox2.ScrollToCaret();
                if(A == 4)
                {
                    fireworks.Visible = true;
                    textBox1.ReadOnly = true;
                    textBox2.AppendText("\r\nCongratulations,You Win!");
                }


            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            play_btn.Visible = true;
            tutorial_btn.Visible = true;
            tutorial.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            Back_btn.Visible = false;
            title.Visible = true;
            textBox1.Visible = false;

            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            fireworks.Visible = false;
        }
    }
}
