using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UTS_Automata_Ravel_Erlindo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz,.:;()`!@#$%^&*;'";
            string finalHuruf = "";
            string angka = "0123456789";
            string finalAngka = "";

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                for (int j = 0; j < huruf.Length; j++)
                {
                    textBox5.Clear();
                    textBox5.ForeColor = Color.Black;
                    await Task.Delay(500);
                    textBox7.Text = Convert.ToString(huruf[j]);
                
                    if (textBox1.Text[i] == huruf[j])
                    {
                        textBox7.ForeColor = Color.Green;
                        string a = textBox7.Text;
                        await Task.Delay(600);
                        textBox3.Text = finalHuruf + a;
                        finalHuruf += huruf[j];
                        await Task.Delay(600);
                        textBox5.Text = "char diterima";
                        await Task.Delay(600);
                        textBox5.Clear();
                        break;
                    }
                    else
                    {
                        textBox7.ForeColor = Color.Red;
                        await Task.Delay(500);
                        textBox5.Text = "Char Ditolak ";
                        await Task.Delay(600);
                        textBox5.Clear();
                    }
                }
                if (textBox3.Text == textBox1.Text)
                {
                    await Task.Delay(500);
                    textBox5.ForeColor = Color.Blue;
                    textBox5.Text = "String Dikenal";
                    await Task.Delay(500);
                }
            }
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                for (int j = 0; j < angka.Length; j++)
                {
                    textBox6.Clear();
                    textBox6.ForeColor = Color.Black;
                    await Task.Delay(500);
                    textBox8.Text = Convert.ToString(angka[j]);

                    if (textBox2.Text[i] == angka[j])
                    {
                        textBox8.ForeColor = Color.Green;
                        string a = textBox8.Text;
                        await Task.Delay(600);
                        textBox4.Text = finalAngka + a;
                        finalAngka += angka[j];
                        await Task.Delay(600);
                        textBox6.Text = "char diterima";
                        await Task.Delay(600);
                        textBox6.Clear();
                        break;
                    }
                    else
                    {
                        textBox8.ForeColor = Color.Red;
                        await Task.Delay(500);
                        textBox6.Text = "Char Ditolak ";
                        await Task.Delay(600);
                        textBox6.Clear();
                    }
                }
                if (textBox4.Text == textBox2.Text)
                {
                    await Task.Delay(500);
                    textBox6.ForeColor = Color.Blue;
                    textBox6.Text = "String Dikenal";
                    await Task.Delay(500);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Input Your Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Input Your Name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void texBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Input Your Nim")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Input Your Nim";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
