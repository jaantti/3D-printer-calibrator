namespace _3D_printer_calibrator {
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
            this.label1 = new System.Windows.Forms.Label();
            this.oldX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldY = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.X2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.newX = new System.Windows.Forms.TextBox();
            this.newY = new System.Windows.Forms.TextBox();
            this.printerBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old X";
            // 
            // oldX
            // 
            this.oldX.Location = new System.Drawing.Point(15, 25);
            this.oldX.Name = "oldX";
            this.oldX.Size = new System.Drawing.Size(56, 20);
            this.oldX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Old Y";
            // 
            // oldY
            // 
            this.oldY.Location = new System.Drawing.Point(81, 25);
            this.oldY.Name = "oldY";
            this.oldY.Size = new System.Drawing.Size(57, 20);
            this.oldY.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.X2);
            this.panel1.Controls.Add(this.X1);
            this.panel1.Controls.Add(this.Y1);
            this.panel1.Controls.Add(this.Y2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 3;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(152, 89);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(43, 20);
            this.X2.TabIndex = 4;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(3, 89);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(41, 20);
            this.X1.TabIndex = 3;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(50, 157);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 20);
            this.Y1.TabIndex = 5;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(50, 25);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(100, 20);
            this.Y2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(50, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Y";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.Control;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.calculate.Location = new System.Drawing.Point(222, 51);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(137, 110);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // newX
            // 
            this.newX.Location = new System.Drawing.Point(222, 181);
            this.newX.Name = "newX";
            this.newX.Size = new System.Drawing.Size(100, 20);
            this.newX.TabIndex = 8;
            // 
            // newY
            // 
            this.newY.Location = new System.Drawing.Point(222, 231);
            this.newY.Name = "newY";
            this.newY.Size = new System.Drawing.Size(100, 20);
            this.newY.TabIndex = 9;
            // 
            // printerBox
            // 
            this.printerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerBox.FormattingEnabled = true;
            this.printerBox.Location = new System.Drawing.Point(222, 24);
            this.printerBox.Name = "printerBox";
            this.printerBox.Size = new System.Drawing.Size(121, 21);
            this.printerBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Printer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.printerBox);
            this.Controls.Add(this.newY);
            this.Controls.Add(this.newX);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.oldY);
            this.Controls.Add(this.oldX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Printer calibration tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox newX;
        private System.Windows.Forms.TextBox newY;
        private System.Windows.Forms.ComboBox printerBox;
        private System.Windows.Forms.Label label5;
    }
}

