using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileChecker {
    public partial class Form1 : Form {

        StreamReader streamReader01, streamReader02;
        int lineCount01, lineCount02;
        Dictionary<int, string> Dictionary01, Dictionary02;
        List<string> lines01 = new List<string>();
        List<string> lines02 = new List<string>();
        char Delimiter;
        string checkType;
        public Form1() {
            InitializeComponent();
        }

        private void sortOpenFile_Btn_Click(object sender, EventArgs e) {
            if (openFileDialog01.ShowDialog() == DialogResult.OK) {
                string line;
                streamReader01 = new StreamReader(openFileDialog01.FileName);
                sortSelectedFile_lbl01.Text = openFileDialog01.FileName;
                //lineCount01 = File.ReadAllLines(openFileDialog01.FileName).Length;

                /* More efficient line reading for large files */
                while ((line = streamReader01.ReadLine()) != null) {
                    lines01.Add(line);
                    lineCount01++;
                }
                /**/
                linesCountValue_lbl01.Text = lineCount01.ToString();

                //@TODO: Move this to perform check
                if (lineCount01 == 0) {
                    statusValue_Lbl01.Text = "File is empty";
                }
            }
        }

        private void sortOpenFile_Btn02_Click(object sender, EventArgs e) {
            if (openFileDialog02.ShowDialog() == DialogResult.OK) {
                string line;
                streamReader02 = new StreamReader(openFileDialog02.FileName);
                sortSelectedFile_lbl02.Text = openFileDialog02.FileName;
                //lineCount02 = File.ReadAllLines(openFileDialog02.FileName).Length;

                /* More efficient line reading for large files */
                while ((line = streamReader02.ReadLine()) != null) {
                    lineCount02++;
                    lines02.Add(line);
                }
                /**/
                linesCountValue_lbl02.Text = lineCount02.ToString();
                if (lineCount02 == 0) {
                    statusValue_Lbl02.Text = "File is empty";
                }
            }
        }

        private void performCheck_btn_Click(object sender, EventArgs e) {
            //@TODO: Check if there is an option selected here
            if (delimiter_txtbox.Text == "") {
                MessageBox.Show("Please select a delimiter");
                return;
            }
            if (lines01.Count <= 0 && lines01.Count <= 0) {
                MessageBox.Show("Please select file.");
                return;
            }
            performCheck();
        }


        private bool performCheck() {
            Delimiter = delimiter_txtbox.Text[0];
            checkType = typeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            switch (checkType) {
                case "Sort":

                    break;
                case "Line":

                    break;
                default:MessageBox.Show("Please select a check type");
                    break;
            }

            /* File 01*/
            foreach (string line in lines01) {
                Console.WriteLine(line);
                Console.WriteLine("Number of columns {0}", getNumberOfColumns(line, ','));
            }

            /* File 02*/
            foreach (string line in lines02) {
                Console.WriteLine(line);
            }

            return true;
        }

        private int getNumberOfColumns(string line, char delimiter) {
            string[] columns = line.Split(delimiter);
            return columns.Length;
        }

    }
}
