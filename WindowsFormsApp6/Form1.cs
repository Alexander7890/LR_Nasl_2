using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {  
        List<Computer> computers = new List<Computer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        // Додати комп'ютер
        private void button1_Click(object sender, EventArgs e)
        {
            string type = textBox1.Text;
            string processor = textBox2.Text;
            string monitor = textBox3.Text;
            string keyboard = textBox4.Text;
            string mouse = textBox5.Text;
            string systemUnit = textBox6.Text;

            Computer computer = new Computer(type, processor, monitor, keyboard, mouse, systemUnit);
            computers.Add(computer);

            ClearTextBoxes();
        }
        // Показати список комп'ютерів
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var computer in computers)
            {
                listBox1.Items.Add(computer.GetDescription());
            }
        }
        // Модернізувати комп'ютер
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < computers.Count)
            {
                Computer computer = computers[selectedIndex];

                string component = textBox7.Text;
                string replacement = textBox8.Text;

                computer.Modernize(component, replacement);

                listBox1.Items[selectedIndex] = computer.GetDescription();
            }
            else
            {
                MessageBox.Show("Please select a computer to modernize.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}