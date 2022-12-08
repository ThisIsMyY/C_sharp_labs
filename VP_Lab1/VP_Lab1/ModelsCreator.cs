using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Lab1
{
    public partial class ModelsCreator : Form
    {
        public ModelsCreator()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox1.Text = "enter name";
            textBox2.Text = "enter display size";
            textBox3.Text = "enter memory value";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelsCreator modelsCreator = new ModelsCreator();
            modelsCreator.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Gray)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "enter name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Gray)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == null || textBox2.Text == "")
            {
                textBox2.Text = "enter display size";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.ForeColor == Color.Gray)
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == null || textBox3.Text == "")
            {
                textBox3.Text = "enter memory value";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
