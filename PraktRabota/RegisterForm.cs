using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PraktRabota
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                    throw new Exception();

                string s = $"[{textBox1.Text}={textBox2.Text}]";
                File.WriteAllLines("users.txt", new string[] { s });
                this.Close();
                MessageBox.Show("Регистрация завершена.");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные.");
            }
        }
    }
}
