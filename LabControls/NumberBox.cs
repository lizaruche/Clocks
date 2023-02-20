using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Messaging;

namespace LabControls
{
    public partial class NumberBox : TextBox
    {
        private bool isDec;
        static private Regex rDec = new Regex(@"^\d+$");
        static private Regex rHex = new Regex(@"^[\dA-Fa-f]+$");
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
                if (this.Text.Length > 0)
                    if (this.Text[0] == '0')
                        this.Text = this.Text.Remove(0, 1);
                // Check decimal
                if (isDec)
                {
                    if (!IsDec(this.Text + e.KeyChar))
                        e.Handled = true;
                }
                // Check hex
                else
                {
                    if (!IsHex(this.Text + e.KeyChar))
                        e.Handled = true;
                }
            }
            else
            {
                switch ((Keys)e.KeyChar)
                {
                    case Keys.Back:
                        base.OnKeyPress(e);
                        break;
                }
            }
        }
        public static bool IsDec(string text)
        {
            if (!rDec.Match(text).Success)
                return false;
            else if (!InDecBounds(text))
                return false;
            return true;
        }
        public static bool IsHex(string text)
        {
            if (!rHex.Match(text).Success)
                return false;
            else if (!InHexBounds(text))
                return false;
            return true;
        }
        private static bool InHexBounds(string text)
        {
            int tmp = int.Parse(text, System.Globalization.NumberStyles.HexNumber);
            return 0 <= tmp && tmp <= 255;
        }
        private static bool InDecBounds(string text)
        {
            int tmp = Convert.ToInt32(text);
            return 0 <= tmp && tmp <= 255;
        }
        public int ConvertToInt()
        {
            if (this.Text == String.Empty)
                return 0;
            else
            {
                if (isDec && IsDec(this.Text))
                    return Convert.ToInt32(this.Text);
                else if (!isDec && IsHex(this.Text))
                    return int.Parse(this.Text, System.Globalization.NumberStyles.HexNumber);
                else
                {
                    this.Text = "0";
                    return 0;
                }   
            }
        }
    }
}
