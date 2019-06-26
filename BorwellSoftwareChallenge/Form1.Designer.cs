namespace BorwellSoftwareChallenge
{
    partial class frnHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnHome));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbWidth = new System.Windows.Forms.TextBox();
            this.txtbHeight = new System.Windows.Forms.TextBox();
            this.txtbLength = new System.Windows.Forms.TextBox();
            this.txtbVolumeOfRoom = new System.Windows.Forms.TextBox();
            this.txtbAmountOfPaint = new System.Windows.Forms.TextBox();
            this.txtbAreaOfFloor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDimension_Units = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolume_Units = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(654, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 36);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Values";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length";
            // 
            // txtbWidth
            // 
            this.txtbWidth.Location = new System.Drawing.Point(73, 18);
            this.txtbWidth.MaxLength = 5;
            this.txtbWidth.Name = "txtbWidth";
            this.txtbWidth.ShortcutsEnabled = false;
            this.txtbWidth.Size = new System.Drawing.Size(100, 20);
            this.txtbWidth.TabIndex = 4;
            this.txtbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbWidth_KeyPress);
            // 
            // txtbHeight
            // 
            this.txtbHeight.Location = new System.Drawing.Point(73, 52);
            this.txtbHeight.MaxLength = 5;
            this.txtbHeight.Name = "txtbHeight";
            this.txtbHeight.ShortcutsEnabled = false;
            this.txtbHeight.Size = new System.Drawing.Size(100, 20);
            this.txtbHeight.TabIndex = 5;
            this.txtbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHeight_KeyPress);
            // 
            // txtbLength
            // 
            this.txtbLength.Location = new System.Drawing.Point(73, 88);
            this.txtbLength.MaxLength = 5;
            this.txtbLength.Name = "txtbLength";
            this.txtbLength.ShortcutsEnabled = false;
            this.txtbLength.Size = new System.Drawing.Size(100, 20);
            this.txtbLength.TabIndex = 6;
            this.txtbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLength_KeyPress);
            // 
            // txtbVolumeOfRoom
            // 
            this.txtbVolumeOfRoom.Location = new System.Drawing.Point(686, 104);
            this.txtbVolumeOfRoom.Name = "txtbVolumeOfRoom";
            this.txtbVolumeOfRoom.ReadOnly = true;
            this.txtbVolumeOfRoom.Size = new System.Drawing.Size(100, 20);
            this.txtbVolumeOfRoom.TabIndex = 12;
            // 
            // txtbAmountOfPaint
            // 
            this.txtbAmountOfPaint.Location = new System.Drawing.Point(686, 61);
            this.txtbAmountOfPaint.Name = "txtbAmountOfPaint";
            this.txtbAmountOfPaint.ReadOnly = true;
            this.txtbAmountOfPaint.Size = new System.Drawing.Size(100, 20);
            this.txtbAmountOfPaint.TabIndex = 11;
            // 
            // txtbAreaOfFloor
            // 
            this.txtbAreaOfFloor.Location = new System.Drawing.Point(686, 19);
            this.txtbAreaOfFloor.Name = "txtbAreaOfFloor";
            this.txtbAreaOfFloor.ReadOnly = true;
            this.txtbAreaOfFloor.Size = new System.Drawing.Size(100, 20);
            this.txtbAreaOfFloor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "volume of room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount of paint required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Area of floor";
            // 
            // cmbDimension_Units
            // 
            this.cmbDimension_Units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDimension_Units.FormattingEnabled = true;
            this.cmbDimension_Units.Items.AddRange(new object[] {
            "CM",
            "MM",
            "M"});
            this.cmbDimension_Units.Location = new System.Drawing.Point(387, 19);
            this.cmbDimension_Units.MaxDropDownItems = 3;
            this.cmbDimension_Units.Name = "cmbDimension_Units";
            this.cmbDimension_Units.Size = new System.Drawing.Size(121, 21);
            this.cmbDimension_Units.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Change dimension units";
            // 
            // cmbVolume_Units
            // 
            this.cmbVolume_Units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVolume_Units.FormattingEnabled = true;
            this.cmbVolume_Units.Items.AddRange(new object[] {
            "Litres"});
            this.cmbVolume_Units.Location = new System.Drawing.Point(387, 63);
            this.cmbVolume_Units.Name = "cmbVolume_Units";
            this.cmbVolume_Units.Size = new System.Drawing.Size(121, 21);
            this.cmbVolume_Units.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Change volume units";
            // 
            // frnHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(798, 200);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbVolume_Units);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDimension_Units);
            this.Controls.Add(this.txtbVolumeOfRoom);
            this.Controls.Add(this.txtbAmountOfPaint);
            this.Controls.Add(this.txtbAreaOfFloor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbLength);
            this.Controls.Add(this.txtbHeight);
            this.Controls.Add(this.txtbWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frnHome";
            this.Text = "Borwell Software Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbWidth;
        private System.Windows.Forms.TextBox txtbHeight;
        private System.Windows.Forms.TextBox txtbLength;
        private System.Windows.Forms.TextBox txtbVolumeOfRoom;
        private System.Windows.Forms.TextBox txtbAmountOfPaint;
        private System.Windows.Forms.TextBox txtbAreaOfFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDimension_Units;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolume_Units;
        private System.Windows.Forms.Label label8;
    }
}

