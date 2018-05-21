using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmering1_15._1 {
    public partial class Form1: Form {

        int summary = 0; // Contains the sum for calculated numbers
        string newNumber = ""; // Contains the numbers the user is writing now.

        public Form1() {
            InitializeComponent();
            MessageBox.Show("Välkommen till kalkylatorn!", "Hej!");
        }

        //      A METHOD TO ADD NUMBERS
        private void AddDigit(string number) {
            richTextBox1.AppendText(number);
            newNumber += number;
        }

        //      A METHOD TO CLEAR THE TEXTBOX
        private void Clear() {
            summary = 0;
            newNumber = "";
            richTextBox1.Text = "";
        }


        //      A METHOD TO SUMMARIZE 
        private void Summarize() {
            if(newNumber != "") {
                summary = summary + Convert.ToInt32(newNumber);
                newNumber = "";
                richTextBox1.Text = Convert.ToString(summary);
            }
            else {
                Clear();
            }
        }


        //      LOADS OF BUTTONS
        private void button1_Click(object sender, EventArgs e) {
            AddDigit("1");
        }

        private void button2_Click(object sender, EventArgs e) {
            AddDigit("2");
        }

        private void button3_Click(object sender, EventArgs e) {
            AddDigit("3");
        }

        private void button6_Click(object sender, EventArgs e) {
            AddDigit("4");
        }

        private void button5_Click(object sender, EventArgs e) {
            AddDigit("5");
        }

        private void button4_Click(object sender, EventArgs e) {
            AddDigit("6");
        }

        private void button9_Click(object sender, EventArgs e) {
            AddDigit("7");
        }

        private void button8_Click(object sender, EventArgs e) {
            AddDigit("8");
        }

        private void button7_Click(object sender, EventArgs e) {
            AddDigit("9");
        }

        private void button0_Click(object sender, EventArgs e) {
            AddDigit("0");
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            summary = summary + Convert.ToInt32(newNumber);
            newNumber = "";
            richTextBox1.Text = summary + "+";
        }

        private void buttonSummarize_Click(object sender, EventArgs e) {
            Summarize();
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            Clear();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void omProgrammetToolStripMenuItem1_Click(object sender, EventArgs e) {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
