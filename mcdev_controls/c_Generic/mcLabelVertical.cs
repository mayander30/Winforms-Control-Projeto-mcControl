using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcdev_controls.c_Generic
{
    public partial class mcLabelVertical : Label
    {
        public mcLabelVertical()
        {
            InitializeComponent();            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Font font = this.Font;
            Brush b = new System.Drawing.SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(23, 3);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(this.Text, font, b, 0, 0);

            this.AutoSize = false;
        }
    }
}
