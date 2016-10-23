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
        Dictionary<string, List<string>> sections01 = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> sections02 = new Dictionary<string, List<string>>();
        List<string> lines01 = new List<string>();
        List<string> lines02 = new List<string>();
        string checkType;
        DataTable dataTable01 = new DataTable();
        DataTable dataTable02 = new DataTable();
        BindingSource bindingSource01 = new BindingSource();
        BindingSource bindingSource02 = new BindingSource();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = bindingSource01;
            dataGridView2.DataSource = bindingSource02;

            DataColumn keyColumn = new DataColumn("Data");
            DataColumn valueColumn = new DataColumn("No. of appearances");
            dataTable01.Columns.Add(keyColumn);
            dataTable01.Columns.Add(valueColumn);

            dataTable02 = dataTable01.Clone();
        }

        private void openFile_Btn_Click(object sender, EventArgs e) {
            if (openFileDialog01.ShowDialog() == DialogResult.OK) {
                streamReader01 = new StreamReader(openFileDialog01.FileName);
                sortSelectedFile_lbl01.Text = openFileDialog01.FileName;
                fileToList(ref streamReader01, ref lines01, ref lineCount01);
                linesCountValue_lbl01.Text = lineCount01.ToString();

                //@TODO: Move this to perform check
                if (lineCount01 == 0) {
                    statusValue_Lbl01.ForeColor = Color.Red;
                    statusValue_Lbl01.Text = "File is empty";
                } else {
                    statusValue_Lbl01.ForeColor = Color.Green;
                    statusValue_Lbl01.Text = "OK";
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
                    statusValue_Lbl02.ForeColor = Color.Red;
                    statusValue_Lbl02.Text = "File is empty";
                }
                else {
                    statusValue_Lbl02.ForeColor = Color.Green;
                    statusValue_Lbl02.Text = "OK";
                }
            }
        }

        private void performCheck_btn_Click(object sender, EventArgs e) {
            if (lines01.Count <= 0 && lines01.Count <= 0) {
                MessageBox.Show("Please select file.");
                return;
            }

            if (performCheck()) {
                MessageBox.Show("Files are equal");
            }else {
                MessageBox.Show("Files are not equal");
                buildDataTables();
            }
        }


        private bool performCheck() {
            checkType = typeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            switch (checkType) {
                case "Sections":
                    listToSectionsDictionary(ref sections01, ref lines01);
                    listToSectionsDictionary(ref sections02, ref lines02);
                    var sortedList01 = sections01.OrderBy(kvp => kvp.Key);
                    //sortedList01.Sort();
                    var sortedList02 = sections01.OrderBy(kvp => kvp.Key);
                    //sortedList02.Sort();
                    return DictionaryExtensionMethods.ContentEquals(sections01, sections02);
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

        private void listToSectionsDictionary(ref Dictionary<string, List<string>> sections, ref List<string> list) {
            sections.Clear();
            List<string> section = null;
            foreach (string line in list) {
                if (checkForSection(line)) {
                    section = null;
                    section = new List<string>();
                    sections.Add(line, section);
                }
                else {
                    section.Add(line);
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

        private void buildDataTables() {
            dataTable01.Clear();
            dataTable02.Clear();

            var dicOne = (Dictionary01 ?? new Dictionary<string, int>())
    .OrderBy(kvp => kvp.Key);
            var dicTwo = (Dictionary02 ?? new Dictionary<string, int>())
                .OrderBy(kvp => kvp.Key);
            var diffOne = dicOne.Except(dicTwo);
            var diffTwo = dicTwo.Except(dicOne);

            foreach (KeyValuePair<string, int> diff in diffOne) {
                DataRow row = dataTable01.NewRow();
                row[0] = diff.Key.ToString();
                row[1] = diff.Value.ToString();
                dataTable01.Rows.Add(row);
                Console.WriteLine(diff.ToString());
            }
            foreach (KeyValuePair<string, int> diff in diffTwo) {
                DataRow row = dataTable02.NewRow();
                row[0] = diff.Key.ToString();
                row[1] = diff.Value.ToString();
                dataTable02.Rows.Add(row);
                Console.WriteLine(diff.ToString());
            }

            bindingSource01.DataSource = dataTable01;
            bindingSource02.DataSource = dataTable02;

            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private bool checkForSection(string line) {
            if (line[0] == '[' && line[line.Length - 1] == ']') {
                return true;
            }else { return false; }
        }


    }
}
