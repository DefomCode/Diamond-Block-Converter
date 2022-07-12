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


            ClientSize = new Size(560, 579);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Diamond Block Converter";

            LoadFont();

            label2.Font = MyFont12;
            label3.Font = MyFont16;
            label1.Font = MyFont12;
            label4.Font = MyFont12;
            label5.Font = MyFont12;

        }

        Font MyFont12;
        Font MyFont16;
        int mode=0;
        int lol;

        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("Minecraft_Title_Cyrillic.ttf");
            MyFont12 = new Font(custom_font.Families[0], 12);
            MyFont16 = new Font(custom_font.Families[0], 16);
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
                switch (mode)
                {
                    case 0:
                        textBox1.Text = ((Convert.ToInt32(textBox3.Text) / 64).ToString());
                        textBox2.Text = ((Convert.ToInt32(textBox3.Text) % 64).ToString());

                        textBox4.Text = ((Convert.ToInt32(textBox3.Text) / 576).ToString());
                        textBox5.Text = ((Convert.ToInt32(textBox3.Text) % 576 / 9).ToString());
                        textBox6.Text = ((Convert.ToInt32(textBox3.Text) % 9).ToString());

                        textBox9.Text = (( Convert.ToInt32(textBox3.Text) / Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox8.Text)).ToString());
                        break;
                    case 1:
                        textBox1.Text = ((Convert.ToInt32(textBox3.Text) / 64).ToString());
                        textBox2.Text = ((Convert.ToInt32(textBox3.Text) % 64).ToString());

                        textBox4.Text = ((Convert.ToInt32(textBox3.Text) * 9 / 64).ToString());
                        textBox5.Text = ((Convert.ToInt32(textBox3.Text) * 9 % 64).ToString());

                        textBox9.Text = ((Convert.ToInt32(textBox3.Text) / Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox8.Text)).ToString());
                        break;
 
                }
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

            
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = comboBox1.SelectedIndex;
            switch (mode)
            {
                case 0:
                    pictureBox6.Visible = true;
                    textBox6.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Image = Properties.Resources.Change2;
                    pictureBox6.Image = Properties.Resources.Diamond;
                    pictureBox7.Image = Properties.Resources.Diamond;
                    pictureBox4.Image = Properties.Resources.Diamond;
                    pictureBox5.Image = Properties.Resources.Diamond64;
                    pictureBox1.Image = Properties.Resources.Diamond_Block64;
                    pictureBox2.Image = Properties.Resources.Block_of_Diamond;
  
                    break;
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    textBox6.Visible = false;
                    pictureBox8.Image = Properties.Resources.Change1;
                    pictureBox7.Image = Properties.Resources.Block_of_Diamond;
                    pictureBox4.Image = Properties.Resources.Block_of_Diamond;
                    pictureBox5.Image = Properties.Resources.Diamond_Block64;
                    pictureBox1.Image = Properties.Resources.Diamond64;
                    pictureBox2.Image = Properties.Resources.Diamond;
                    break;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void textBox7_KeyDown_1(object sender, KeyEventArgs e)
        {
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

        // Набор очков для пасхалок
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            lol++;
        }

        // ты думал здесь...
        private void label2_Click(object sender, EventArgs e)
        {
            if(lol > 0)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PkT0PJwy8mI");
                lol--;
            }
        }

        //Рикролл
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (lol > 0)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                lol--;
            }
        }
    }
}
