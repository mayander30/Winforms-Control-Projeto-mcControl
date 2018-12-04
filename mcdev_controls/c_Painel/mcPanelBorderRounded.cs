using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace mcdev_controls.c_Painel
{
    public partial class mcPanelBorderRounded : Panel
    {
        /// <summary>
        /// Define o valor para a borda, quando maior o valor mais vai arredondar a borda
        /// </summary>
        [Category("PanelRounded")]
        public float _RADIUS { get; set; }

        [Category("PanelRounded")]
        public Color _background { get; set; }

        public mcPanelBorderRounded()
        {
            InitializeComponent();
            _RADIUS = 10;
            _background = SystemColors.ButtonFace;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.FillRoundedRectangle(new SolidBrush(_background),
                0, 0, this.Width, this.Height, _RADIUS);

        }

        protected override void OnResize(EventArgs eventargs)
        {
            this.Invalidate();
        }
    }
}
