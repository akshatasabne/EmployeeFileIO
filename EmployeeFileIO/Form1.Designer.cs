namespace EmployeeFileIO
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.butWrite = new System.Windows.Forms.Button();
            this.butRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(80, 49);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(83, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Employee Id";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(80, 112);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Employee Name";
            this.labelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(80, 179);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(46, 16);
            this.labelSalary.TabIndex = 2;
            this.labelSalary.Text = "Salary";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(249, 49);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(146, 22);
            this.textID.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(249, 112);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(146, 22);
            this.textName.TabIndex = 4;
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(249, 179);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(146, 22);
            this.textSalary.TabIndex = 5;
            // 
            // butWrite
            // 
            this.butWrite.Location = new System.Drawing.Point(83, 284);
            this.butWrite.Name = "butWrite";
            this.butWrite.Size = new System.Drawing.Size(75, 34);
            this.butWrite.TabIndex = 6;
            this.butWrite.Text = "Write";
            this.butWrite.UseVisualStyleBackColor = true;
            this.butWrite.Click += new System.EventHandler(this.butWrite_Click);
            // 
            // butRead
            // 
            this.butRead.Location = new System.Drawing.Point(280, 284);
            this.butRead.Name = "butRead";
            this.butRead.Size = new System.Drawing.Size(75, 34);
            this.butRead.TabIndex = 7;
            this.butRead.Text = "Read";
            this.butRead.UseVisualStyleBackColor = true;
            this.butRead.Click += new System.EventHandler(this.butRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRead);
            this.Controls.Add(this.butWrite);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Button butWrite;
        private System.Windows.Forms.Button butRead;
    }
}

