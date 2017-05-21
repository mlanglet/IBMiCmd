﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBMiCmd.Forms
{
    public partial class userSettings : Form
    {
        public userSettings()
        {
            InitializeComponent();
        }

        private void userSettings_Load(object sender, EventArgs e)
        {
            textBox1.Text = IBMi.GetConfig("system");
            textBox2.Text = IBMi.GetConfig("username");
            textBox3.Text = IBMi.GetConfig("password");
            textBox4.Text = IBMi.GetConfig("relicdir");
            textBox5.Text = IBMi.GetConfig("reliclib");
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                textBox3.Focus();
                return;
            }

            IBMi.SetConfig("system", textBox1.Text);
            IBMi.SetConfig("username", textBox2.Text);
            IBMi.SetConfig("password", textBox3.Text);
            IBMi.SetConfig("relicdir", textBox4.Text);
            IBMi.SetConfig("reliclib", textBox5.Text);

			this.Close();
        }
	}
}
