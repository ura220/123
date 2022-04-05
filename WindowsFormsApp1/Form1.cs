using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> users = new Dictionary<string, string>();
        string current_user;
        string It;
        string Robo;
        string Geo;
        string HiTech;
        string Bio;
        string Energy;

        //Dictionary<string, bool> putin = new Dictionary<string, bool>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button8.Visible = true;
            button4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button4.Visible = true;
            button8.Visible = true;
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox2.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox3.Text)
            {
                label8.Text = "пароли не совпадают";
            }
            else if (users.ContainsKey(textBox4.Text))
            {
                label8.Text = "такой ник уже существует";
            }
            else
            {
                users.Add(textBox4.Text, textBox3.Text);
                label8.Text = "вы успешно зарегестрировались";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (users.ContainsKey(textBox1.Text) && users.ContainsValue(textBox2.Text))
            {
                current_user = textBox1.Text;
                groupBox3.Visible = true;
                groupBox1.Visible = false;
                button8.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
            }
            else
            {
                label7.Text = "неверное имя или пароль";
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button8.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            button8.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "88005553535")
            {
                groupBox5.Visible = true;
                groupBox4.Visible = false;
                label16.Text = null;
            }
            else
            {
                label16.Text = "неверный пароль";
            }
            textBox6.Text = null;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "IT")
            {
                It = It + " " + current_user;
            }
            if (comboBox1.SelectedItem.ToString() == "Robo")
            {
                Robo = Robo + " " + current_user;
            }
            if (comboBox1.SelectedItem.ToString() == "Geo")
            {
                Geo = Geo + " " + current_user;
            }
            if (comboBox1.SelectedItem.ToString() == "HiTech")
            {
                HiTech = HiTech + " " + current_user;
            }
            if (comboBox1.SelectedItem.ToString() == "Bio")
            {
                Bio = Bio + " " + current_user;
            }
            if (comboBox1.SelectedItem.ToString() == "Energy")
            {
                Energy = Energy + " " + current_user;
            }
            textBox7.Text = "It:" + It + "Robo:" + Robo +  "Geo:" + Geo +  "HiTech:" + HiTech +  "Bio:" + Bio + "Energy:" + Energy;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            button8.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }
    }
}
