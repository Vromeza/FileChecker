namespace FileChecker {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sortSelectedFile_lbl01 = new System.Windows.Forms.Label();
            this.openFile_Btn01 = new System.Windows.Forms.Button();
            this.openFileDialog01 = new System.Windows.Forms.OpenFileDialog();
            this.sortRadioButton = new System.Windows.Forms.RadioButton();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.sectionsRadioButton = new System.Windows.Forms.RadioButton();
            this.performCheck_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile_Btn02 = new System.Windows.Forms.Button();
            this.sortSelectedFile_lbl02 = new System.Windows.Forms.Label();
            this.openFileDialog02 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.statusValue_Lbl02 = new System.Windows.Forms.Label();
            this.status_Lbl02 = new System.Windows.Forms.Label();
            this.linesCountValue_lbl02 = new System.Windows.Forms.Label();
            this.linesCount_lbl02 = new System.Windows.Forms.Label();
            this.columnCountValue_lbl02 = new System.Windows.Forms.Label();
            this.columnCount_lbl02 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusValue_Lbl01 = new System.Windows.Forms.Label();
            this.status_Lbl01 = new System.Windows.Forms.Label();
            this.linesCountValue_lbl01 = new System.Windows.Forms.Label();
            this.linesCount_lbl01 = new System.Windows.Forms.Label();
            this.columnCountValue_lbl01 = new System.Windows.Forms.Label();
            this.columnCount_lbl01 = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.delimiter_txtbox = new System.Windows.Forms.TextBox();
            this.delimiter_lbl = new System.Windows.Forms.Label();
            this.typeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortSelectedFile_lbl01
            // 
            this.sortSelectedFile_lbl01.Location = new System.Drawing.Point(87, 29);
            this.sortSelectedFile_lbl01.Name = "sortSelectedFile_lbl01";
            this.sortSelectedFile_lbl01.Size = new System.Drawing.Size(212, 32);
            this.sortSelectedFile_lbl01.TabIndex = 1;
            this.sortSelectedFile_lbl01.Text = "...";
            // 
            // openFile_Btn01
            // 
            this.openFile_Btn01.Location = new System.Drawing.Point(6, 19);
            this.openFile_Btn01.Name = "openFile_Btn01";
            this.openFile_Btn01.Size = new System.Drawing.Size(75, 23);
            this.openFile_Btn01.TabIndex = 0;
            this.openFile_Btn01.Text = "Open file";
            this.openFile_Btn01.UseVisualStyleBackColor = true;
            this.openFile_Btn01.Click += new System.EventHandler(this.openFile_Btn_Click);
            // 
            // openFileDialog01
            // 
            this.openFileDialog01.Filter = "Text files | *.txt";
            this.openFileDialog01.Title = "Select a text file";
            // 
            // sortRadioButton
            // 
            this.sortRadioButton.AutoSize = true;
            this.sortRadioButton.Location = new System.Drawing.Point(12, 19);
            this.sortRadioButton.Name = "sortRadioButton";
            this.sortRadioButton.Size = new System.Drawing.Size(44, 17);
            this.sortRadioButton.TabIndex = 2;
            this.sortRadioButton.TabStop = true;
            this.sortRadioButton.Text = "Sort";
            this.sortRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.radioButton3);
            this.typeGroupBox.Controls.Add(this.sectionsRadioButton);
            this.typeGroupBox.Controls.Add(this.sortRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(12, 391);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.typeGroupBox.TabIndex = 3;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type of check";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(12, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Other";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // sectionsRadioButton
            // 
            this.sectionsRadioButton.AutoSize = true;
            this.sectionsRadioButton.Location = new System.Drawing.Point(12, 42);
            this.sectionsRadioButton.Name = "sectionsRadioButton";
            this.sectionsRadioButton.Size = new System.Drawing.Size(66, 17);
            this.sectionsRadioButton.TabIndex = 3;
            this.sectionsRadioButton.TabStop = true;
            this.sectionsRadioButton.Text = "Sections";
            this.sectionsRadioButton.UseVisualStyleBackColor = true;
            // 
            // performCheck_btn
            // 
            this.performCheck_btn.Location = new System.Drawing.Point(623, 468);
            this.performCheck_btn.Name = "performCheck_btn";
            this.performCheck_btn.Size = new System.Drawing.Size(75, 23);
            this.performCheck_btn.TabIndex = 4;
            this.performCheck_btn.Text = "Check";
            this.performCheck_btn.UseVisualStyleBackColor = true;
            this.performCheck_btn.Click += new System.EventHandler(this.performCheck_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "compare with...";
            // 
            // openFile_Btn02
            // 
            this.openFile_Btn02.Location = new System.Drawing.Point(15, 29);
            this.openFile_Btn02.Name = "openFile_Btn02";
            this.openFile_Btn02.Size = new System.Drawing.Size(75, 23);
            this.openFile_Btn02.TabIndex = 6;
            this.openFile_Btn02.Text = "Open file";
            this.openFile_Btn02.UseVisualStyleBackColor = true;
            this.openFile_Btn02.Click += new System.EventHandler(this.openFile_Btn02_Click);
            // 
            // sortSelectedFile_lbl02
            // 
            this.sortSelectedFile_lbl02.Location = new System.Drawing.Point(96, 39);
            this.sortSelectedFile_lbl02.Name = "sortSelectedFile_lbl02";
            this.sortSelectedFile_lbl02.Size = new System.Drawing.Size(200, 30);
            this.sortSelectedFile_lbl02.TabIndex = 7;
            this.sortSelectedFile_lbl02.Text = "...";
            // 
            // openFileDialog02
            // 
            this.openFileDialog02.Filter = "Text files | *.txt";
            this.openFileDialog02.Title = "Select a text file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.statusValue_Lbl02);
            this.groupBox2.Controls.Add(this.status_Lbl02);
            this.groupBox2.Controls.Add(this.linesCountValue_lbl02);
            this.groupBox2.Controls.Add(this.linesCount_lbl02);
            this.groupBox2.Controls.Add(this.columnCountValue_lbl02);
            this.groupBox2.Controls.Add(this.columnCount_lbl02);
            this.groupBox2.Controls.Add(this.openFile_Btn02);
            this.groupBox2.Controls.Add(this.sortSelectedFile_lbl02);
            this.groupBox2.Location = new System.Drawing.Point(15, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File No. 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lines contained here are missing or different from the other table";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(302, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 122);
            this.dataGridView2.TabIndex = 13;
            // 
            // statusValue_Lbl02
            // 
            this.statusValue_Lbl02.AutoSize = true;
            this.statusValue_Lbl02.Location = new System.Drawing.Point(66, 118);
            this.statusValue_Lbl02.Name = "statusValue_Lbl02";
            this.statusValue_Lbl02.Size = new System.Drawing.Size(10, 13);
            this.statusValue_Lbl02.TabIndex = 12;
            this.statusValue_Lbl02.Text = "-";
            // 
            // status_Lbl02
            // 
            this.status_Lbl02.AutoSize = true;
            this.status_Lbl02.Location = new System.Drawing.Point(13, 118);
            this.status_Lbl02.Name = "status_Lbl02";
            this.status_Lbl02.Size = new System.Drawing.Size(40, 13);
            this.status_Lbl02.TabIndex = 11;
            this.status_Lbl02.Text = "Status:";
            // 
            // linesCountValue_lbl02
            // 
            this.linesCountValue_lbl02.AutoSize = true;
            this.linesCountValue_lbl02.Location = new System.Drawing.Point(66, 95);
            this.linesCountValue_lbl02.Name = "linesCountValue_lbl02";
            this.linesCountValue_lbl02.Size = new System.Drawing.Size(10, 13);
            this.linesCountValue_lbl02.TabIndex = 10;
            this.linesCountValue_lbl02.Text = "-";
            // 
            // linesCount_lbl02
            // 
            this.linesCount_lbl02.AutoSize = true;
            this.linesCount_lbl02.Location = new System.Drawing.Point(13, 95);
            this.linesCount_lbl02.Name = "linesCount_lbl02";
            this.linesCount_lbl02.Size = new System.Drawing.Size(35, 13);
            this.linesCount_lbl02.TabIndex = 9;
            this.linesCount_lbl02.Text = "Lines:";
            // 
            // columnCountValue_lbl02
            // 
            this.columnCountValue_lbl02.AutoSize = true;
            this.columnCountValue_lbl02.Location = new System.Drawing.Point(65, 72);
            this.columnCountValue_lbl02.Name = "columnCountValue_lbl02";
            this.columnCountValue_lbl02.Size = new System.Drawing.Size(10, 13);
            this.columnCountValue_lbl02.TabIndex = 4;
            this.columnCountValue_lbl02.Text = "-";
            // 
            // columnCount_lbl02
            // 
            this.columnCount_lbl02.AutoSize = true;
            this.columnCount_lbl02.Location = new System.Drawing.Point(12, 72);
            this.columnCount_lbl02.Name = "columnCount_lbl02";
            this.columnCount_lbl02.Size = new System.Drawing.Size(50, 13);
            this.columnCount_lbl02.TabIndex = 3;
            this.columnCount_lbl02.Text = "Columns:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.statusValue_Lbl01);
            this.groupBox1.Controls.Add(this.status_Lbl01);
            this.groupBox1.Controls.Add(this.linesCountValue_lbl01);
            this.groupBox1.Controls.Add(this.linesCount_lbl01);
            this.groupBox1.Controls.Add(this.columnCountValue_lbl01);
            this.groupBox1.Controls.Add(this.columnCount_lbl01);
            this.groupBox1.Controls.Add(this.openFile_Btn01);
            this.groupBox1.Controls.Add(this.sortSelectedFile_lbl01);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File No.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lines contained here are missing or different from the other table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 122);
            this.dataGridView1.TabIndex = 12;
            // 
            // statusValue_Lbl01
            // 
            this.statusValue_Lbl01.AutoSize = true;
            this.statusValue_Lbl01.Location = new System.Drawing.Point(56, 109);
            this.statusValue_Lbl01.Name = "statusValue_Lbl01";
            this.statusValue_Lbl01.Size = new System.Drawing.Size(10, 13);
            this.statusValue_Lbl01.TabIndex = 11;
            this.statusValue_Lbl01.Text = "-";
            // 
            // status_Lbl01
            // 
            this.status_Lbl01.AutoSize = true;
            this.status_Lbl01.Location = new System.Drawing.Point(9, 109);
            this.status_Lbl01.Name = "status_Lbl01";
            this.status_Lbl01.Size = new System.Drawing.Size(40, 13);
            this.status_Lbl01.TabIndex = 10;
            this.status_Lbl01.Text = "Status:";
            // 
            // linesCountValue_lbl01
            // 
            this.linesCountValue_lbl01.AutoSize = true;
            this.linesCountValue_lbl01.Location = new System.Drawing.Point(58, 86);
            this.linesCountValue_lbl01.Name = "linesCountValue_lbl01";
            this.linesCountValue_lbl01.Size = new System.Drawing.Size(10, 13);
            this.linesCountValue_lbl01.TabIndex = 9;
            this.linesCountValue_lbl01.Text = "-";
            // 
            // linesCount_lbl01
            // 
            this.linesCount_lbl01.AutoSize = true;
            this.linesCount_lbl01.Location = new System.Drawing.Point(9, 86);
            this.linesCount_lbl01.Name = "linesCount_lbl01";
            this.linesCount_lbl01.Size = new System.Drawing.Size(35, 13);
            this.linesCount_lbl01.TabIndex = 8;
            this.linesCount_lbl01.Text = "Lines:";
            // 
            // columnCountValue_lbl01
            // 
            this.columnCountValue_lbl01.AutoSize = true;
            this.columnCountValue_lbl01.Location = new System.Drawing.Point(58, 63);
            this.columnCountValue_lbl01.Name = "columnCountValue_lbl01";
            this.columnCountValue_lbl01.Size = new System.Drawing.Size(10, 13);
            this.columnCountValue_lbl01.TabIndex = 3;
            this.columnCountValue_lbl01.Text = "-";
            // 
            // columnCount_lbl01
            // 
            this.columnCount_lbl01.AutoSize = true;
            this.columnCount_lbl01.Location = new System.Drawing.Point(9, 63);
            this.columnCount_lbl01.Name = "columnCount_lbl01";
            this.columnCount_lbl01.Size = new System.Drawing.Size(50, 13);
            this.columnCount_lbl01.TabIndex = 2;
            this.columnCount_lbl01.Text = "Columns:";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.delimiter_txtbox);
            this.settingsGroupBox.Controls.Add(this.delimiter_lbl);
            this.settingsGroupBox.Location = new System.Drawing.Point(230, 391);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(387, 100);
            this.settingsGroupBox.TabIndex = 10;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // delimiter_txtbox
            // 
            this.delimiter_txtbox.Enabled = false;
            this.delimiter_txtbox.Location = new System.Drawing.Point(54, 16);
            this.delimiter_txtbox.MaxLength = 2;
            this.delimiter_txtbox.Name = "delimiter_txtbox";
            this.delimiter_txtbox.Size = new System.Drawing.Size(29, 20);
            this.delimiter_txtbox.TabIndex = 1;
            // 
            // delimiter_lbl
            // 
            this.delimiter_lbl.AutoSize = true;
            this.delimiter_lbl.Location = new System.Drawing.Point(7, 20);
            this.delimiter_lbl.Name = "delimiter_lbl";
            this.delimiter_lbl.Size = new System.Drawing.Size(50, 13);
            this.delimiter_lbl.TabIndex = 0;
            this.delimiter_lbl.Text = "Delimiter:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 637);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.performCheck_btn);
            this.Controls.Add(this.typeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog01;
        private System.Windows.Forms.Button openFile_Btn01;
        private System.Windows.Forms.Label sortSelectedFile_lbl01;
        private System.Windows.Forms.RadioButton sortRadioButton;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton sectionsRadioButton;
        private System.Windows.Forms.Button performCheck_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFile_Btn02;
        private System.Windows.Forms.Label sortSelectedFile_lbl02;
        private System.Windows.Forms.OpenFileDialog openFileDialog02;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.TextBox delimiter_txtbox;
        private System.Windows.Forms.Label delimiter_lbl;
        private System.Windows.Forms.Label columnCountValue_lbl02;
        private System.Windows.Forms.Label columnCount_lbl02;
        private System.Windows.Forms.Label linesCount_lbl01;
        private System.Windows.Forms.Label columnCountValue_lbl01;
        private System.Windows.Forms.Label columnCount_lbl01;
        private System.Windows.Forms.Label linesCountValue_lbl02;
        private System.Windows.Forms.Label linesCount_lbl02;
        private System.Windows.Forms.Label linesCountValue_lbl01;
        private System.Windows.Forms.Label status_Lbl02;
        private System.Windows.Forms.Label statusValue_Lbl01;
        private System.Windows.Forms.Label status_Lbl01;
        private System.Windows.Forms.Label statusValue_Lbl02;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

