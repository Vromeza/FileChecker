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
        Dictionary<string, int> Dictionary01 = new Dictionary<string, int>();
        Dictionary<string, int> Dictionary02 = new Dictionary<string, int>();
        List<string> lines01 = new List<string>();
        List<string> lines02 = new List<string>();
        char Delimiter;
        string checkType;
        public Form1() {
            InitializeComponent();
        }

        private void openFile_Btn_Click(object sender, EventArgs e) {
            if (openFileDialog01.ShowDialog() == DialogResult.OK) {
                streamReader01 = new StreamReader(openFileDialog01.FileName);
                sortSelectedFile_lbl01.Text = openFileDialog01.FileName;

                fileToList(ref streamReader01, ref lines01, ref lineCount01);
                
                linesCountValue_lbl01.Text = lineCount01.ToString();

                //@TODO: Move this to perform check
                if (lineCount01 == 0) {
                    statusValue_Lbl01.Text = "File is empty";
                }
            }
        }

        private void openFile_Btn02_Click(object sender, EventArgs e) {
            if (openFileDialog02.ShowDialog() == DialogResult.OK) {
                streamReader02 = new StreamReader(openFileDialog02.FileName);
                sortSelectedFile_lbl02.Text = openFileDialog02.FileName;

                fileToList(ref streamReader02, ref lines02, ref lineCount02);

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
            if (performCheck()) {
                MessageBox.Show("Files are equal");
                //@TODO: Display relevant data
            }else {
                MessageBox.Show("Files are not equal");
                //@TODO: Display relevant data
            }
        }


        private bool performCheck() {
            Delimiter = delimiter_txtbox.Text[0];
            checkType = typeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            switch (checkType) {
                case "Line":
                    //@TODO: Implement line checking
                    return false;
                case "Sort":
                    listToDictionary(ref Dictionary01, ref lines01);
                    listToDictionary(ref Dictionary02, ref lines02);
                    return DictionaryExtensionMethods.ContentEquals(Dictionary01, Dictionary02);
                default:MessageBox.Show("Please select a check type");
                    return false;
            }
        }

        private void listToDictionary(ref Dictionary<string, int> dictionary, ref List<string> list) {
            dictionary.Clear();
            foreach (string line in list) {
                if (dictionary.ContainsKey(line)) {
                    dictionary[line] += 1;
                }
                else {
                    dictionary[line] = 1;
                }
            }
        }

        private void fileToList(ref StreamReader file, ref List<string> list, ref int count) {
            count = 0;
            list.Clear();
            /* More efficient line reading for large files */
            string line;
            while ((line = file.ReadLine()) != null) {
                list.Add(line);
                count++;
            }
            /**/
            file.Close();
        }

        private int getNumberOfColumns(string line, char delimiter) {
            return line.Split(delimiter).Length;
        }
    }
}
