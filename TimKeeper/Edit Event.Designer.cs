namespace TimKeeper
{
    partial class FormEdit
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
            this.lbName2 = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.lbPlace2 = new System.Windows.Forms.Label();
            this.lbdes2 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName2
            // 
            this.lbName2.AutoSize = true;
            this.lbName2.Location = new System.Drawing.Point(38, 23);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(35, 13);
            this.lbName2.TabIndex = 0;
            this.lbName2.Text = "Name";
            this.lbName2.Click += new System.EventHandler(this.lbName2_Click);
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(107, 20);
            this.textboxName.Multiline = true;
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(231, 20);
            this.textboxName.TabIndex = 1;
            // 
            // lbDate2
            // 
            this.lbDate2.AutoSize = true;
            this.lbDate2.Location = new System.Drawing.Point(38, 68);
            this.lbDate2.Name = "lbDate2";
            this.lbDate2.Size = new System.Drawing.Size(30, 13);
            this.lbDate2.TabIndex = 2;
            this.lbDate2.Text = "Date";
            // 
            // lbPlace2
            // 
            this.lbPlace2.AutoSize = true;
            this.lbPlace2.Location = new System.Drawing.Point(38, 113);
            this.lbPlace2.Name = "lbPlace2";
            this.lbPlace2.Size = new System.Drawing.Size(34, 13);
            this.lbPlace2.TabIndex = 3;
            this.lbPlace2.Text = "Place";
            // 
            // lbdes2
            // 
            this.lbdes2.AutoSize = true;
            this.lbdes2.Location = new System.Drawing.Point(38, 155);
            this.lbdes2.Name = "lbdes2";
            this.lbdes2.Size = new System.Drawing.Size(60, 13);
            this.lbdes2.TabIndex = 4;
            this.lbdes2.Text = "Description";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(107, 65);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(75, 20);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_KeyPress);
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(107, 110);
            this.textBoxPlace.Multiline = true;
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(231, 20);
            this.textBoxPlace.TabIndex = 6;
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(107, 152);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(231, 20);
            this.textBoxDes.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy | hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(18, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(107, 192);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 9;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(205, 192);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 10;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 11;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 227);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.lbdes2);
            this.Controls.Add(this.lbPlace2);
            this.Controls.Add(this.lbDate2);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.lbName2);
            this.Name = "FormEdit";
            this.Text = "Edit_Event";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName2;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label lbDate2;
        private System.Windows.Forms.Label lbPlace2;
        private System.Windows.Forms.Label lbdes2;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}