﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDpassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len_pass = (int)numericUpDown1.Value;
            int quantity = (int)numericUpDown2.Value;
            bool symbols = checkBox1.Checked;
            Random rand = new Random();
            //Random type = new Random();
            for (int j = 0; j < quantity; j++)
            {
                for (int i = 0; i < len_pass; i++)
                {
                    if (symbols == true)
                    {
                        char value = (char)rand.Next(33, 125);
                        if (value == '\\' || value == '/')
                        {
                            value = (char)rand.Next(33, 91);
                            richTextBox1.Text += value.ToString();
                        }
                        else
                        {
                            richTextBox1.Text += value.ToString();
                        }
                        continue;
                    }
                    
                        int value2 = rand.Next(0, 9);
                        richTextBox1.Text += value2.ToString();
                        continue;
                    
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
