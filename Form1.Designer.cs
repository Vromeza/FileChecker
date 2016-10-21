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
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.performCheck_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile_Btn02 = new System.Windows.Forms.Button();
            this.sortSelectedFile_lbl02 = new System.Windows.Forms.Label();
            this.openFileDialog02 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusValue_Lbl02 = new System.Windows.Forms.Label();
            this.status_Lbl02 = new System.Windows.Forms.Label();
            this.linesCountValue_lbl02 = new System.Windows.Forms.Label();
            this.linesCount_lbl02 = new System.Windows.Forms.Label();
            this.columnCountValue_lbl02 = new System.Windows.Forms.Label();
            this.columnCount_lbl02 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sortSelectedFile_lbl01
            // 
            this.sortSelectedFile_lbl01.Location = new System.Drawing.Point(116, 36);
            this.sortSelectedFile_lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortSelectedFile_lbl01.Name = "sortSelectedFile_lbl01";
            this.sortSelectedFile_lbl01.Size = new System.Drawing.Size(283, 40);
            this.sortSelectedFile_lbl01.TabIndex = 1;
            this.sortSelectedFile_lbl01.Text = "...";
            // 
            // openFile_Btn01
            // 
            this.openFile_Btn01.Location = new System.Drawing.Point(8, 23);
            this.openFile_Btn01.Margin = new System.Windows.Forms.Padding(4);
            this.openFile_Btn01.Name = "openFile_Btn01";
            this.openFile_Btn01.Size = new System.Drawing.Size(100, 28);
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
            this.sortRadioButton.Location = new System.Drawing.Point(16, 23);
            this.sortRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortRadioButton.Name = "sortRadioButton";
            this.sortRadioButton.Size = new System.Drawing.Size(55, 21);
            this.sortRadioButton.TabIndex = 2;
            this.sortRadioButton.TabStop = true;
            this.sortRadioButton.Text = "Sort";
            this.sortRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.radioButton3);
            this.typeGroupBox.Controls.Add(this.lineRadioButton);
            this.typeGroupBox.Controls.Add(this.sortRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(16, 481);
            this.typeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.typeGroupBox.Size = new System.Drawing.Size(267, 123);
            this.typeGroupBox.TabIndex = 3;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type of check";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(16, 84);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Other";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.AutoSize = true;
            this.lineRadioButton.Enabled = false;
            this.lineRadioButton.Location = new System.Drawing.Point(16, 52);
            this.lineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(56, 21);
            this.lineRadioButton.TabIndex = 3;
            this.lineRadioButton.TabStop = true;
            this.lineRadioButton.Text = "Line";
            this.lineRadioButton.UseVisualStyleBackColor = true;
            // 
            // performCheck_btn
            // 
            this.performCheck_btn.Location = new System.Drawing.Point(831, 576);
            this.performCheck_btn.Margin = new System.Windows.Forms.Padding(4);
            this.performCheck_btn.Name = "performCheck_btn";
            this.performCheck_btn.Size = new System.Drawing.Size(100, 28);
            this.performCheck_btn.TabIndex = 4;
            this.performCheck_btn.Text = "Check";
            this.performCheck_btn.UseVisualStyleBackColor = true;
            this.performCheck_btn.Click += new System.EventHandler(this.performCheck_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "compare with...";
            // 
            // openFile_Btn02
            // 
            this.openFile_Btn02.Location = new System.Drawing.Point(20, 36);
            this.openFile_Btn02.Margin = new System.Windows.Forms.Padding(4);
            this.openFile_Btn02.Name = "openFile_Btn02";
            this.openFile_Btn02.Size = new System.Drawing.Size(100, 28);
            this.openFile_Btn02.TabIndex = 6;
            this.openFile_Btn02.Text = "Open file";
            this.openFile_Btn02.UseVisualStyleBackColor = true;
            this.openFile_Btn02.Click += new System.EventHandler(this.openFile_Btn02_Click);
            // 
            // sortSelectedFile_lbl02
            // 
            this.sortSelectedFile_lbl02.Location = new System.Drawing.Point(128, 48);
            this.sortSelectedFile_lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortSelectedFile_lbl02.Name = "sortSelectedFile_lbl02";
            this.sortSelectedFile_lbl02.Size = new System.Drawing.Size(267, 37);
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
            this.groupBox2.Location = new System.Drawing.Point(20, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(911, 203);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File No. 2";
            // 
            // statusValue_Lbl02
            // 
            this.statusValue_Lbl02.AutoSize = true;
            this.statusValue_Lbl02.Location = new System.Drawing.Point(88, 145);
            this.statusValue_Lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusValue_Lbl02.Name = "statusValue_Lbl02";
            this.statusValue_Lbl02.Size = new System.Drawing.Size(13, 17);
            this.statusValue_Lbl02.TabIndex = 12;
            this.statusValue_Lbl02.Text = "-";
            // 
            // status_Lbl02
            // 
            this.status_Lbl02.AutoSize = true;
            this.status_Lbl02.Location = new System.Drawing.Point(17, 145);
            this.status_Lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_Lbl02.Name = "status_Lbl02";
            this.status_Lbl02.Size = new System.Drawing.Size(52, 17);
            this.status_Lbl02.TabIndex = 11;
            this.status_Lbl02.Text = "Status:";
            // 
            // linesCountValue_lbl02
            // 
            this.linesCountValue_lbl02.AutoSize = true;
            this.linesCountValue_lbl02.Location = new System.Drawing.Point(88, 117);
            this.linesCountValue_lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linesCountValue_lbl02.Name = "linesCountValue_lbl02";
            this.linesCountValue_lbl02.Size = new System.Drawing.Size(13, 17);
            this.linesCountValue_lbl02.TabIndex = 10;
            this.linesCountValue_lbl02.Text = "-";
            // 
            // linesCount_lbl02
            // 
            this.linesCount_lbl02.AutoSize = true;
            this.linesCount_lbl02.Location = new System.Drawing.Point(17, 117);
            this.linesCount_lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linesCount_lbl02.Name = "linesCount_lbl02";
            this.linesCount_lbl02.Size = new System.Drawing.Size(46, 17);
            this.linesCount_lbl02.TabIndex = 9;
            this.linesCount_lbl02.Text = "Lines:";
            // 
            // columnCountValue_lbl02
            // 
            this.columnCountValue_lbl02.AutoSize = true;
            this.columnCountValue_lbl02.Location = new System.Drawing.Point(87, 89);
            this.columnCountValue_lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columnCountValue_lbl02.Name = "columnCountValue_lbl02";
            this.columnCountValue_lbl02.Size = new System.Drawing.Size(13, 17);
            this.columnCountValue_lbl02.TabIndex = 4;
            this.columnCountValue_lbl02.Text = "-";
            // 
            // columnCount_lbl02
            // 
            this.columnCount_lbl02.AutoSize = true;
            this.columnCount_lbl02.Location = new System.Drawing.Point(16, 89);
            this.columnCount_lbl02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columnCount_lbl02.Name = "columnCount_lbl02";
            this.columnCount_lbl02.Size = new System.Drawing.Size(66, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(911, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File No.1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // statusValue_Lbl01
            // 
            this.statusValue_Lbl01.AutoSize = true;
            this.statusValue_Lbl01.Location = new System.Drawing.Point(75, 134);
            this.statusValue_Lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusValue_Lbl01.Name = "statusValue_Lbl01";
            this.statusValue_Lbl01.Size = new System.Drawing.Size(13, 17);
            this.statusValue_Lbl01.TabIndex = 11;
            this.statusValue_Lbl01.Text = "-";
            // 
            // status_Lbl01
            // 
            this.status_Lbl01.AutoSize = true;
            this.status_Lbl01.Location = new System.Drawing.Point(12, 134);
            this.status_Lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_Lbl01.Name = "status_Lbl01";
            this.status_Lbl01.Size = new System.Drawing.Size(52, 17);
            this.status_Lbl01.TabIndex = 10;
            this.status_Lbl01.Text = "Status:";
            // 
            // linesCountValue_lbl01
            // 
            this.linesCountValue_lbl01.AutoSize = true;
            this.linesCountValue_lbl01.Location = new System.Drawing.Point(77, 106);
            this.linesCountValue_lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linesCountValue_lbl01.Name = "linesCountValue_lbl01";
            this.linesCountValue_lbl01.Size = new System.Drawing.Size(13, 17);
            this.linesCountValue_lbl01.TabIndex = 9;
            this.linesCountValue_lbl01.Text = "-";
            // 
            // linesCount_lbl01
            // 
            this.linesCount_lbl01.AutoSize = true;
            this.linesCount_lbl01.Location = new System.Drawing.Point(12, 106);
            this.linesCount_lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linesCount_lbl01.Name = "linesCount_lbl01";
            this.linesCount_lbl01.Size = new System.Drawing.Size(46, 17);
            this.linesCount_lbl01.TabIndex = 8;
            this.linesCount_lbl01.Text = "Lines:";
            // 
            // columnCountValue_lbl01
            // 
            this.columnCountValue_lbl01.AutoSize = true;
            this.columnCountValue_lbl01.Location = new System.Drawing.Point(77, 78);
            this.columnCountValue_lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columnCountValue_lbl01.Name = "columnCountValue_lbl01";
            this.columnCountValue_lbl01.Size = new System.Drawing.Size(13, 17);
            this.columnCountValue_lbl01.TabIndex = 3;
            this.columnCountValue_lbl01.Text = "-";
            // 
            // columnCount_lbl01
            // 
            this.columnCount_lbl01.AutoSize = true;
            this.columnCount_lbl01.Location = new System.Drawing.Point(12, 78);
            this.columnCount_lbl01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columnCount_lbl01.Name = "columnCount_lbl01";
            this.columnCount_lbl01.Size = new System.Drawing.Size(66, 17);
            this.columnCount_lbl01.TabIndex = 2;
            this.columnCount_lbl01.Text = "Columns:";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.delimiter_txtbox);
            this.settingsGroupBox.Controls.Add(this.delimiter_lbl);
            this.settingsGroupBox.Location = new System.Drawing.Point(307, 481);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.settingsGroupBox.Size = new System.Drawing.Size(516, 123);
            this.settingsGroupBox.TabIndex = 10;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // delimiter_txtbox
            // 
            this.delimiter_txtbox.Enabled = false;
            this.delimiter_txtbox.Location = new System.Drawing.Point(72, 20);
            this.delimiter_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.delimiter_txtbox.MaxLength = 2;
            this.delimiter_txtbox.Name = "delimiter_txtbox";
            this.delimiter_txtbox.Size = new System.Drawing.Size(37, 22);
            this.delimiter_txtbox.TabIndex = 1;
            // 
            // delimiter_lbl
            // 
            this.delimiter_lbl.AutoSize = true;
            this.delimiter_lbl.Location = new System.Drawing.Point(9, 25);
            this.delimiter_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delimiter_lbl.Name = "delimiter_lbl";
            this.delimiter_lbl.Size = new System.Drawing.Size(67, 17);
            this.delimiter_lbl.TabIndex = 0;
            this.delimiter_lbl.Text = "Delimiter:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(402, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(480, 150);
            this.dataGridView2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lines contained here are missing or different from the other table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lines contained here are missing or different from the other table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 619);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.performCheck_btn);
            this.Controls.Add(this.typeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "File Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.RadioButton lineRadioButton;
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

