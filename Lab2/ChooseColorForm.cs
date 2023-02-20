using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabControls;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public partial class ChooseColorForm : Form
    {
        public int green;
        public int blue;
        public int red;
        public ChooseColorForm(int green=0, int blue=0, int red=0)
        {
            InitializeComponent();
            this.green = green;
            this.numBoxGreen.Text = green.ToString();
            this.red = red;
            this.numBoxRed.Text = red.ToString();
            this.blue = blue;
            this.numBoxBlue.Text = blue.ToString();
            this.btnDec.Checked = true;
            this.colorBox.BackColor = Color.FromArgb(red, green, blue);
        }
        private void ChangeToHex()
        {
            this.numBoxBlue.HexMode();
            this.numBoxRed.HexMode();
            this.numBoxGreen.HexMode();
            this.numBoxBlue.Text = blue.ToString("X");
            this.numBoxRed.Text = red.ToString("X");
            this.numBoxGreen.Text = green.ToString("X");
        }
        private void ChangeToDec()
        {
            this.numBoxBlue.DecMode();
            this.numBoxRed.DecMode();
            this.numBoxGreen.DecMode();
            this.numBoxBlue.Text = blue.ToString();
            this.numBoxGreen.Text = green.ToString();
            this.numBoxRed.Text = red.ToString();
        }
        private void btnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (btnHex.Checked)
                ChangeToHex();
        }

        private void btnDec_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDec.Checked) 
                ChangeToDec();
        }
        private void numBox_TextChanged(object sender, EventArgs e)
        {
            if (btnDec.Checked)
            {
                if (sender == numBoxBlue)
                    this.blue = this.numBoxBlue.ConvertToInt();
                if (sender == numBoxRed)
                    this.red = this.numBoxRed.ConvertToInt();
                if (sender == numBoxGreen)
                    this.green = this.numBoxGreen.ConvertToInt();
                this.colorBox.BackColor = Color.FromArgb(red, green, blue);
            }
            else
            {
                if (sender == numBoxBlue)
                    this.blue = this.numBoxBlue.ConvertToInt();
                if (sender == numBoxRed)
                    this.red = this.numBoxRed.ConvertToInt();
                if (sender == numBoxGreen)
                    this.green = this.numBoxGreen.ConvertToInt();
                this.colorBox.BackColor = Color.FromArgb(red, green, blue);
            }
        }
    }
}
