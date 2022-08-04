using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private object tocombo2;
        private object fromcombo1;
        private object amount_text;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(amount_text.Text);
            if (fromcombo1.SelectdItem == "Euro" && tocombo2.SelectedItem == "Dollar") ;

            {
                int conver = i / 103;
                display_txt.Text = "Converted Amount : " + conver + "\t $";
            }

            public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                int i = int.Parse(amount_text.Text);
                if (fromcombo1.SelectdItem == "Dollar" && tocombo2.SelectedItem == "Euro") ;

                {
                    int conver = i * 115;
                    display_txt.Text = "Converted Amount : " + conver + "\t Euro";
                }
            }
        }
    }