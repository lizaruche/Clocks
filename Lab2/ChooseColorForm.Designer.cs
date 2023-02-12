namespace Lab2
{
    partial class ChooseColorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.btnHex = new System.Windows.Forms.RadioButton();
            this.btnDec = new System.Windows.Forms.RadioButton();
            this.numBoxGreen = new LabControls.NumberBox(this.components);
            this.numBoxBlue = new LabControls.NumberBox(this.components);
            this.numBoxRed = new LabControls.NumberBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Синий:";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.IndianRed;
            this.colorBox.Location = new System.Drawing.Point(235, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(123, 103);
            this.colorBox.TabIndex = 10;
            this.colorBox.TabStop = false;
            // 
            // btnHex
            // 
            this.btnHex.AutoSize = true;
            this.btnHex.Location = new System.Drawing.Point(125, 98);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(44, 17);
            this.btnHex.TabIndex = 12;
            this.btnHex.TabStop = true;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.CheckedChanged += new System.EventHandler(this.btnHex_CheckedChanged);
            // 
            // btnDec
            // 
            this.btnDec.AutoSize = true;
            this.btnDec.Location = new System.Drawing.Point(23, 98);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(45, 17);
            this.btnDec.TabIndex = 13;
            this.btnDec.TabStop = true;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.CheckedChanged += new System.EventHandler(this.btnDec_CheckedChanged);
            // 
            // numBoxGreen
            // 
            this.numBoxGreen.ForeColor = System.Drawing.Color.Black;
            this.numBoxGreen.Location = new System.Drawing.Point(108, 38);
            this.numBoxGreen.Name = "numBoxGreen";
            this.numBoxGreen.Size = new System.Drawing.Size(112, 20);
            this.numBoxGreen.TabIndex = 7;
            this.numBoxGreen.Text = "0";
            this.numBoxGreen.TextChanged += new System.EventHandler(this.numBox_TextChanged);
            // 
            // numBoxBlue
            // 
            this.numBoxBlue.ForeColor = System.Drawing.Color.Black;
            this.numBoxBlue.Location = new System.Drawing.Point(108, 64);
            this.numBoxBlue.Name = "numBoxBlue";
            this.numBoxBlue.Size = new System.Drawing.Size(112, 20);
            this.numBoxBlue.TabIndex = 6;
            this.numBoxBlue.Text = "0";
            this.numBoxBlue.TextChanged += new System.EventHandler(this.numBox_TextChanged);
            // 
            // numBoxRed
            // 
            this.numBoxRed.ForeColor = System.Drawing.Color.Black;
            this.numBoxRed.Location = new System.Drawing.Point(108, 12);
            this.numBoxRed.Name = "numBoxRed";
            this.numBoxRed.Size = new System.Drawing.Size(112, 20);
            this.numBoxRed.TabIndex = 5;
            this.numBoxRed.Text = "0";
            this.numBoxRed.TextChanged += new System.EventHandler(this.numBox_TextChanged);
            // 
            // ChooseColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 127);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.numBoxGreen);
            this.Controls.Add(this.numBoxBlue);
            this.Controls.Add(this.numBoxRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChooseColorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LabControls.NumberBox numBoxRed;
        private LabControls.NumberBox numBoxBlue;
        private LabControls.NumberBox numBoxGreen;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.RadioButton btnHex;
        private System.Windows.Forms.RadioButton btnDec;
    }
}

