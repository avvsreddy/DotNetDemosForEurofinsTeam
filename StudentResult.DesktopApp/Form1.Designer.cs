
namespace StudentResult.DesktopApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtSubject1Marks = new System.Windows.Forms.TextBox();
            this.txtSubject2Marks = new System.Windows.Forms.TextBox();
            this.txtSubject3Marks = new System.Windows.Forms.TextBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAverageMarks = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject 1 Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject 2 Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject 3 Marks";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(211, 52);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(362, 26);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtSubject1Marks
            // 
            this.txtSubject1Marks.Location = new System.Drawing.Point(211, 92);
            this.txtSubject1Marks.Name = "txtSubject1Marks";
            this.txtSubject1Marks.Size = new System.Drawing.Size(100, 26);
            this.txtSubject1Marks.TabIndex = 5;
            // 
            // txtSubject2Marks
            // 
            this.txtSubject2Marks.Location = new System.Drawing.Point(211, 132);
            this.txtSubject2Marks.Name = "txtSubject2Marks";
            this.txtSubject2Marks.Size = new System.Drawing.Size(100, 26);
            this.txtSubject2Marks.TabIndex = 6;
            // 
            // txtSubject3Marks
            // 
            this.txtSubject3Marks.Location = new System.Drawing.Point(211, 176);
            this.txtSubject3Marks.Name = "txtSubject3Marks";
            this.txtSubject3Marks.Size = new System.Drawing.Size(100, 26);
            this.txtSubject3Marks.TabIndex = 7;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(211, 219);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(362, 29);
            this.btnGetResult.TabIndex = 8;
            this.btnGetResult.Text = "Calculate Student Result";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Marks";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(72, 314);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.ReadOnly = true;
            this.txtTotalMarks.Size = new System.Drawing.Size(100, 26);
            this.txtTotalMarks.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Average Marks";
            // 
            // txtAverageMarks
            // 
            this.txtAverageMarks.Location = new System.Drawing.Point(211, 314);
            this.txtAverageMarks.Name = "txtAverageMarks";
            this.txtAverageMarks.ReadOnly = true;
            this.txtAverageMarks.Size = new System.Drawing.Size(100, 26);
            this.txtAverageMarks.TabIndex = 12;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(348, 314);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(225, 26);
            this.txtResult.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 364);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAverageMarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.txtSubject3Marks);
            this.Controls.Add(this.txtSubject2Marks);
            this.Controls.Add(this.txtSubject1Marks);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Student Result Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtSubject1Marks;
        private System.Windows.Forms.TextBox txtSubject2Marks;
        private System.Windows.Forms.TextBox txtSubject3Marks;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAverageMarks;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label7;
    }
}

