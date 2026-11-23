namespace Demo_Parrallel_Arrays
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGrade = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStudent = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblGrade
            // 
            lblGrade.BorderStyle = BorderStyle.Fixed3D;
            lblGrade.Location = new Point(225, 129);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(247, 99);
            lblGrade.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 159);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Grade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Students:";
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(225, 82);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(125, 27);
            txtStudent.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(225, 277);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(139, 45);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search Grade";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblGrade);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade Lookup";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrade;
        private Label label2;
        private Label label3;
        private TextBox txtStudent;
        private Button btnSearch;
    }
}
