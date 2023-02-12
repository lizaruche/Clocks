using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace LabControls
{
    public partial class NumberBox : TextBox
    {
        private bool isDec;
        public NumberBox()
        {
            InitializeComponent();
            this.isDec = true;
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void HexMode()
        {
            this.isDec = false;
        }
        public void DecMode()
        {
            this.isDec = true;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Ignore controls (backspace gives \b in the and of string)
            if (!char.IsControl((e.KeyChar)))
            {
                // Check decimal
                if (isDec)
                {
                    if (!char.IsDigit(e.KeyChar))
                        e.Handled = true;
                    else if (!InDecBounds(this.Text + e.KeyChar))
                        e.Handled = true;
                }
                // Check hex
                else
                {
                    if (!IsHex(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                        e.Handled = true;
                    else if (!InHexBounds(this.Text + e.KeyChar))
                        e.Handled = true;
                }
            }
                
            base.OnKeyPress(e);
        }
        public static bool InHexBounds(string text)
        {
            int tmp = int.Parse(text, System.Globalization.NumberStyles.HexNumber);
            return 0 <= tmp && tmp <= 255;
        }
        public static bool InDecBounds(string text)
        {
            int tmp = Convert.ToInt32(text);
            return 0 <= tmp && tmp <= 255;
        }
        public static bool IsHex(char c)
        {
            return (c >= '0' && c <= '9') ||
                     (c >= 'a' && c <= 'f') ||
                     (c >= 'A' && c <= 'F');
        }
        public int ConvertToInt()
        {
            if (this.Text == String.Empty)
                return 0;
            else
            {
                if (isDec)
                    return Convert.ToInt32(this.Text);
                else 
                    return int.Parse(this.Text, System.Globalization.NumberStyles.HexNumber);
            }
        }
    }
}
