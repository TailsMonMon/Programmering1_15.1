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
        }

        //      A METHOD TO ADD NUMBERS
        private void AddDigit(string number) {
            richTextBox1.AppendText(number);
            newNumber += number;
        }

        //      A METHOD TO SUMMARIZE 
        private void Summarize() {
            if(newNumber != "") {
                summary = summary + Convert.ToInt32(newNumber);
                newNumber = "";
                richTextBox1.Text = Convert.ToString(summary);
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
            summary = 0;
            newNumber = "";
            richTextBox1 = "";
        }
    }
}
