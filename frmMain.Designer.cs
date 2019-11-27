namespace Algorithms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputRTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnShell = new System.Windows.Forms.RadioButton();
            this.rbtnMerge = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.rbtnRadix = new System.Windows.Forms.RadioButton();
            this.rbtnInsertion = new System.Windows.Forms.RadioButton();
            this.rbtnSelection = new System.Windows.Forms.RadioButton();
            this.btnBubble = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbtnRecBinary = new System.Windows.Forms.RadioButton();
            this.rbtnBinary = new System.Windows.Forms.RadioButton();
            this.rbtnLinear = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputRTxt
            // 
            this.outputRTxt.Location = new System.Drawing.Point(12, 240);
            this.outputRTxt.Name = "outputRTxt";
            this.outputRTxt.ReadOnly = true;
            this.outputRTxt.Size = new System.Drawing.Size(486, 179);
            this.outputRTxt.TabIndex = 0;
            this.outputRTxt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnShell);
            this.groupBox1.Controls.Add(this.rbtnMerge);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.rbtnRadix);
            this.groupBox1.Controls.Add(this.rbtnInsertion);
            this.groupBox1.Controls.Add(this.rbtnSelection);
            this.groupBox1.Controls.Add(this.btnBubble);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // rbtnShell
            // 
            this.rbtnShell.AutoSize = true;
            this.rbtnShell.Location = new System.Drawing.Point(134, 43);
            this.rbtnShell.Name = "rbtnShell";
            this.rbtnShell.Size = new System.Drawing.Size(70, 17);
            this.rbtnShell.TabIndex = 6;
            this.rbtnShell.TabStop = true;
            this.rbtnShell.Text = "Shell Sort";
            this.rbtnShell.UseVisualStyleBackColor = true;
            // 
            // rbtnMerge
            // 
            this.rbtnMerge.AutoSize = true;
            this.rbtnMerge.Location = new System.Drawing.Point(134, 20);
            this.rbtnMerge.Name = "rbtnMerge";
            this.rbtnMerge.Size = new System.Drawing.Size(77, 17);
            this.rbtnMerge.TabIndex = 5;
            this.rbtnMerge.TabStop = true;
            this.rbtnMerge.Text = "Merge Sort";
            this.rbtnMerge.UseVisualStyleBackColor = true;
            this.rbtnMerge.CheckedChanged += new System.EventHandler(this.rbtnMerge_CheckedChanged);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(157, 89);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rbtnRadix
            // 
            this.rbtnRadix.AutoSize = true;
            this.rbtnRadix.Location = new System.Drawing.Point(17, 89);
            this.rbtnRadix.Name = "rbtnRadix";
            this.rbtnRadix.Size = new System.Drawing.Size(74, 17);
            this.rbtnRadix.TabIndex = 3;
            this.rbtnRadix.TabStop = true;
            this.rbtnRadix.Text = "Radix Sort";
            this.rbtnRadix.UseVisualStyleBackColor = true;
            this.rbtnRadix.CheckedChanged += new System.EventHandler(this.rbtnRadix_CheckedChanged);
            // 
            // rbtnInsertion
            // 
            this.rbtnInsertion.AutoSize = true;
            this.rbtnInsertion.Location = new System.Drawing.Point(17, 66);
            this.rbtnInsertion.Name = "rbtnInsertion";
            this.rbtnInsertion.Size = new System.Drawing.Size(87, 17);
            this.rbtnInsertion.TabIndex = 2;
            this.rbtnInsertion.TabStop = true;
            this.rbtnInsertion.Text = "Insertion Sort";
            this.rbtnInsertion.UseVisualStyleBackColor = true;
            // 
            // rbtnSelection
            // 
            this.rbtnSelection.AutoSize = true;
            this.rbtnSelection.Location = new System.Drawing.Point(17, 43);
            this.rbtnSelection.Name = "rbtnSelection";
            this.rbtnSelection.Size = new System.Drawing.Size(91, 17);
            this.rbtnSelection.TabIndex = 1;
            this.rbtnSelection.TabStop = true;
            this.rbtnSelection.Text = "Selection Sort";
            this.rbtnSelection.UseVisualStyleBackColor = true;
            // 
            // btnBubble
            // 
            this.btnBubble.AutoSize = true;
            this.btnBubble.Location = new System.Drawing.Point(17, 20);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(80, 17);
            this.btnBubble.TabIndex = 0;
            this.btnBubble.TabStop = true;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.CheckedChanged += new System.EventHandler(this.btnBubble_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchTxt);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rbtnRecBinary);
            this.groupBox2.Controls.Add(this.rbtnBinary);
            this.groupBox2.Controls.Add(this.rbtnLinear);
            this.groupBox2.Location = new System.Drawing.Point(260, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search number:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(88, 91);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(63, 20);
            this.searchTxt.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(157, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnRecBinary
            // 
            this.rbtnRecBinary.AutoSize = true;
            this.rbtnRecBinary.Location = new System.Drawing.Point(6, 66);
            this.rbtnRecBinary.Name = "rbtnRecBinary";
            this.rbtnRecBinary.Size = new System.Drawing.Size(142, 17);
            this.rbtnRecBinary.TabIndex = 3;
            this.rbtnRecBinary.TabStop = true;
            this.rbtnRecBinary.Text = "Recursive Binary Search";
            this.rbtnRecBinary.UseVisualStyleBackColor = true;
            // 
            // rbtnBinary
            // 
            this.rbtnBinary.AutoSize = true;
            this.rbtnBinary.Location = new System.Drawing.Point(6, 43);
            this.rbtnBinary.Name = "rbtnBinary";
            this.rbtnBinary.Size = new System.Drawing.Size(91, 17);
            this.rbtnBinary.TabIndex = 2;
            this.rbtnBinary.TabStop = true;
            this.rbtnBinary.Text = "Binary Search";
            this.rbtnBinary.UseVisualStyleBackColor = true;
            // 
            // rbtnLinear
            // 
            this.rbtnLinear.AutoSize = true;
            this.rbtnLinear.Location = new System.Drawing.Point(6, 20);
            this.rbtnLinear.Name = "rbtnLinear";
            this.rbtnLinear.Size = new System.Drawing.Size(91, 17);
            this.rbtnLinear.TabIndex = 1;
            this.rbtnLinear.TabStop = true;
            this.rbtnLinear.Text = "Linear Search";
            this.rbtnLinear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort and Search Algorithms";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(127, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate new List";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(50, 54);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(71, 20);
            this.sizeTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(273, 52);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show List";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(397, 54);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(101, 23);
            this.btnShuffle.TabIndex = 8;
            this.btnShuffle.Text = "Shuffle List";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(210, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sizeTxt);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputRTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithms";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbtnRadix;
        private System.Windows.Forms.RadioButton rbtnInsertion;
        private System.Windows.Forms.RadioButton rbtnSelection;
        private System.Windows.Forms.RadioButton btnBubble;
        private System.Windows.Forms.RadioButton rbtnRecBinary;
        private System.Windows.Forms.RadioButton rbtnBinary;
        private System.Windows.Forms.RadioButton rbtnLinear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.RadioButton rbtnShell;
        private System.Windows.Forms.RadioButton rbtnMerge;
        private System.Windows.Forms.Button btnExit;
    }
}

