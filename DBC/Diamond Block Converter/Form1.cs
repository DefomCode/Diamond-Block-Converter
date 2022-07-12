using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Diamond_Block_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // ClientSize = new Size(560, 510);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Diamond Block Converter";



            LoadFont();
            button0.Font = MyFont12;
            button1.Font = MyFont12;
            button2.Font = MyFont12;
            button3.Font = MyFont12;
            button4.Font = MyFont12;
            button5.Font = MyFont12;
            button6.Font = MyFont12;
            button7.Font = MyFont12;
            button8.Font = MyFont12;
            button9.Font = MyFont12;
            buttonС.Font = MyFont12;
            button10.Font = MyFont26;
            label2.Font = MyFont12;
            label3.Font = MyFont16;

        }

        Font MyFont12;
        Font MyFont16;
        Font MyFont26;
        


        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("Minecraft_Title_Cyrillic.ttf");
            MyFont12 = new Font(custom_font.Families[0], 12);
            MyFont16 = new Font(custom_font.Families[0], 16);
            MyFont26 = new Font(custom_font.Families[0], 26);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
                e.Handled = true;
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox3.Text == "0")
                textBox3.Text = B.Text;
            else if (textBox3.Text.Length == 8)
            {

            }
            else
                textBox3.Text = textBox3.Text + B.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 1)
            {
                int lenght = textBox3.Text.Length - 1;
                string text = textBox3.Text;
                textBox3.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    textBox3.Text = textBox3.Text + text[i];
                }
            }
            else if (textBox3.Text.Length == 1)
            {
                textBox3.Clear();
                textBox3.Text = "0";
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox3.Text) != 0)
            {
                textBox1.Text = ((Convert.ToInt32(textBox3.Text) / 64).ToString());
                textBox2.Text = ((Convert.ToInt32(textBox3.Text) % 64).ToString());

                textBox4.Text = ((Convert.ToInt32(textBox3.Text) / 576).ToString());
                textBox5.Text = ((Convert.ToInt32(textBox3.Text) % 576 / 9).ToString());
                textBox6.Text = ((Convert.ToInt32(textBox3.Text) % 9).ToString());

            }
        }

        private void buttonС_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Text = "0";
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;


            if (!Char.IsDigit(number))
            {
                if ((e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
                    | (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
        }


        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            //да я написал через иф елсс. что ты мне сделаешь?
            if (e.KeyValue == (char)Keys.Back)
            {
                if (textBox3.Text.Length > 1)
                {
                    int lenght = textBox3.Text.Length - 1;
                    string text = textBox3.Text;
                    textBox3.Clear();
                    for (int i = 0; i < lenght; i++)
                    {
                        textBox3.Text = textBox3.Text + text[i];
                    }
                }
                else
                {
                    textBox3.Clear();
                    textBox3.Text = "0";
                }
            }
        }


    }
}
