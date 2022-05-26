using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervace.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        private string placeholder = string.Empty;
        private bool password;

        public CustomTextBox()
        {
            InitializeComponent();
        }


        public event EventHandler _TextChanged;



        [Category("Custom TextBox")]
        public Color BorderColor { 
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom TextBox")]
        public int BorderSize { 
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom TextBox")]
        public bool UnderlinedStyle {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Custom TextBox")]
        public bool Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                textBox1.UseSystemPasswordChar = !placeholder.Equals(string.Empty) && value;
            }
        }

        [Category("Custom TextBox")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Custom TextBox")]
        public override Color BackColor 
        { 
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Custom TextBox")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("Custom TextBox")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
            }
        }

        [Category("Custom TextBox")]
        public string Placeholder
        { 
            get => placeholder;
            set 
            {
                textBox1.Text = value;
                placeholder = value;
            }
        }

        [Category("Custom TextBox")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("Custom TextBox")]
        public HorizontalAlignment TextAlign
        {
            get => textBox1.TextAlign;
            set => textBox1.TextAlign = value;
        }

        public override string Text
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            using Pen penBorder = new(borderColor, borderSize);
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            if (isFocused) penBorder.Color = borderFocusColor;
            if (underlinedStyle)
            {
                g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
            }
            else
            {
                g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e) => OnClick(e);

        private void textBox1_MouseEnter(object sender, EventArgs e) => OnMouseEnter(e);

        private void textBox1_MouseLeave(object sender, EventArgs e) => OnMouseLeave(e);

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            if (textBox1.Text.Equals(placeholder))
            {
                if (password)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
                textBox1.Text = string.Empty;
            }
            Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.UseSystemPasswordChar = false;
                textBox1.Text = placeholder;
            }
            isFocused = false;
            Invalidate();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }
    }
}
