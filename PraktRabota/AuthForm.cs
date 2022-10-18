using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PraktRabota
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("users.txt"))
            {
                List<string> s = File.ReadAllLines("users.txt").ToList();
                if (!s.Contains($"[{textBox1.Text}={textBox2.Text}]"))
                {
                    MessageBox.Show("Не найден пользователь", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не найден пользователь", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new MainForm().Show();
            this.Hide();
        }
    }
}
