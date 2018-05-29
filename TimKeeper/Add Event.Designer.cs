namespace TimKeeper
{
    partial class FormAdd
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
            this.lbName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxdate1 = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxDate2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(40, 32);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(98, 29);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(268, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxdate1
            // 
            this.textBoxdate1.Location = new System.Drawing.Point(98, 70);
            this.textBoxdate1.Multiline = true;
            this.textBoxdate1.Name = "textBoxdate1";
            this.textBoxdate1.Size = new System.Drawing.Size(83, 20);
            this.textBoxdate1.TabIndex = 2;
            this.textBoxdate1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxdate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxdate1_KeyPress);
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(98, 110);
            this.textBoxPlace.Multiline = true;
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(268, 20);
            this.textBoxPlace.TabIndex = 3;
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(98, 153);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(268, 20);
            this.textBoxDes.TabIndex = 4;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(40, 73);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 13);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time";
            this.lbTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.ClientSizeChanged += new System.EventHandler(this.btn_ClickCancel);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxDate2
            // 
            this.textBoxDate2.Location = new System.Drawing.Point(187, 70);
            this.textBoxDate2.Multiline = true;
            this.textBoxDate2.Name = "textBoxDate2";
            this.textBoxDate2.ReadOnly = true;
            this.textBoxDate2.Size = new System.Drawing.Size(153, 20);
            this.textBoxDate2.TabIndex = 11;
            this.textBoxDate2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 235);
            this.Controls.Add(this.textBoxDate2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxdate1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lbName);
            this.Name = "FormAdd";
            this.Text = "Add_Event";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxdate1;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxDate2;
    }
}