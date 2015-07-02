using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;
using System.IO;

namespace AgarQuit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (comboBox1.SelectedItem == null)
            {
                button1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Evet")
            {
                button1.Enabled = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Hayır")
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine("\r\n127.0.0.1 agar.io");
                string message = "Yeni Agar.io 'suz hayatınızda başarılar dileriz.";
                string caption = "Başarılı !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (result == DialogResult.OK){
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=x4n3xpct-64");
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://akcanca.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Windows/System32/drivers/etc/hosts\ndosyasını düzenleyerek Agar.io ile iletişiminizi keser.",
                    "Nasıl Çalışır ?");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
