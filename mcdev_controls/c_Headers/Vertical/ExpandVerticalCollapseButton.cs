﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mcdev_controls.c_Headers.Vertical
{
    [ToolboxItem(false)]
    public partial class ExpandVerticalCollapseButton : UserControl
    {
        private Image _expanded;

        private Image _collapsed;

        private bool isExpanded;

        [Browsable(true)]
        [Category("ExpandCollapseButton_B")]
        [Description("Expand or collapse button.")]
        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                isExpanded = value;
                OnExpandCollapse();
            }
        }

        [Category("ExpandCollapseButton_B")]
        [Description("Occurs when the button has expanded or collapsed.")]
        [Browsable(true)]
        public event EventHandler<ExpandCollapseEventArgs> ExpandCollapse;

        public ExpandVerticalCollapseButton()
        {
            InitializeComponent();

            #region initialize expanded/collapsed state bitmaps:
            InitButtonStyle(ExpandButtonStyle.Normal);
            InitButtonSize(ExpandButtonSize.Small);
            #endregion

            // initial state of panel - collapsed
            isExpanded = false;
        }

        #region ExpandButtonStyles
        /// <summary>
        /// Visual styles of the expand-collapse button.
        /// </summary>
        public enum ExpandButtonStyle
        {
            Normal
        }
        private ExpandButtonStyle _expandButtonStyle = ExpandButtonStyle.Normal;

        /// <summary>
        /// Visual style of the expand-collapse button.
        /// </summary>
        [Category("ExpandCollapseButton_B")]
        [Description("Visual style of the expand-collapse button.")]
        [Browsable(true)]
        public ExpandButtonStyle ButtonStyle
        {
            get { return _expandButtonStyle; }
            set
            {
                if (_expandButtonStyle != value)
                {
                    InitButtonStyle(value);
                }
            }
        }

        private void InitButtonStyle(ExpandButtonStyle style)
        {
            _expandButtonStyle = style;

            switch (_expandButtonStyle)
            {
                //case ExpandButtonStyle.MagicArrow:
                //    var bmp = Properties.Resources.Upload;
                //    bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                //    pictureBox1.Image = bmp;
                //    break;
                //case ExpandButtonStyle.Circle:
                //    bmp = Properties.Resources.icon_expand;
                //    pictureBox1.Image = bmp;
                //    break;
                //case ExpandButtonStyle.Triangle:
                //    pictureBox1.Image = Properties.Resources._1downarrow1;
                //    break;
                //case ExpandButtonStyle.FatArrow:
                //    bmp = Properties.Resources.up_256;
                //    bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                //    pictureBox1.Image = bmp;
                //    break;
                //case ExpandButtonStyle.Classic:
                //    bmp = Properties.Resources.icon_struct_hide_collapsed;
                //    bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                //    pictureBox1.Image = bmp;
                //    break;
                default:
                    var bmp = Properties.Resources.Expand;
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Image = bmp;
                    break;
            }

            // collapsed bitmap:
            _collapsed = pictureBox1.Image;

            // expanded bitmap is rotated collapsed bitmap:
            _expanded = MakeGrayscale3(pictureBox1.Image);
            _expanded.RotateFlip(RotateFlipType.Rotate180FlipNone);

            // finally set appropriate bitmap for current state
            pictureBox1.Image = isExpanded ? _expanded : _collapsed;
        }
        #endregion ExpandButtonStyles

        #region ExpandButtonSizes
        /// <summary>
        /// Size presets of the expand-collapse button.
        /// </summary>
        public enum ExpandButtonSize
        {
            Small,
            Normal
        }
        private ExpandButtonSize _expandButtonSize = ExpandButtonSize.Normal;

        /// <summary>
        /// Size preset of the expand-collapse button.
        /// </summary>
        [Category("ExpandCollapseButton_B")]
        [Description("Size preset of the expand-collapse button.")]
        [Browsable(true)]
        public ExpandButtonSize ButtonSize
        {
            get { return _expandButtonSize; }
            set
            {
                if (_expandButtonSize != value)
                {
                    InitButtonSize(value);
                }
            }
        }

        /// <summary>
        /// Resize and arrange child controls according to ButtonSize preset
        /// </summary>
        /// <param name="size">ButtonSize preset</param>
        private void InitButtonSize(ExpandButtonSize size)
        {
            _expandButtonSize = size;

            switch (_expandButtonSize)
            {
                case ExpandButtonSize.Small:
                   // pictureBox1.Location = new Point(0, 3);
                   // pictureBox1.Size = new Size(16, 16);
                    //lblLine.Location = new Point(20, 18);
                   // lblHeader.Location = new Point(20, 1);
                    break;
                case ExpandButtonSize.Normal:
                  //  pictureBox1.Location = new Point(0, 3);
                   // pictureBox1.Size = new Size(24, 24);
                   // lblLine.Location = new Point(30, 22);
                   // lblHeader.Location = new Point(30, 3);

                    break;
                //case ExpandButtonSize.Large:
                //    pictureBox1.Location = new Point(0, 3);
                //    pictureBox1.Size = new Size(35, 35);
                //    lblLine.Location = new Point(41, 28);
                //    lblHeader.Location = new Point(41, 3);
                //    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
        }
        #endregion ExpandButtonSizes
        
        /// <summary>
        /// Handle clicks from PictureBox and Header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnMouseDown(object sender, EventArgs e)
        {
            // just invert current state
            IsExpanded = !IsExpanded;
        }

        /// <summary>
        /// Handle state changing
        /// </summary>
        protected virtual void OnExpandCollapse()
        {
            // set appropriate bitmap
            pictureBox1.Image = isExpanded ? _expanded : _collapsed;
            //lblHeader.ForeColor = IsExpanded ? Color.DarkGray : Color.SteelBlue;

            // and fire the event:
            EventHandler<ExpandCollapseEventArgs> handler = ExpandCollapse;
            if (handler != null)
                handler(this, new ExpandCollapseEventArgs(isExpanded));
        }

        /// <summary>
        /// Utillity method for createing a grayscale copy of image
        /// </summary>
        /// <param name="original">original image</param>
        /// <returns>grayscale copy of image</returns>
        public static Bitmap MakeGrayscale3(Image original)
        {
            // create a blank bitmap the same size as original
            var newBitmap = new Bitmap(original.Width, original.Height);

            // get a graphics object from the new image
            using (var g = Graphics.FromImage(newBitmap))
            {

                // create the grayscale ColorMatrix
                var colorMatrix = new ColorMatrix(
                    new float[][]
                        {
                            new float[] {.3f, .3f, .3f, 0, 0},
                            new float[] {.59f, .59f, .59f, 0, 0},
                            new float[] {.11f, .11f, .11f, 0, 0},
                            new float[] {0, 0, 0, 1, 0},
                            new float[] {0, 0, 0, 0, 1}
                        });

                // create some image attributes
                var attributes = new ImageAttributes();

                // set the color matrix attribute
                attributes.SetColorMatrix(colorMatrix);

                // draw the original image on the new image
                // using the grayscale color matrix
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                            0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

                // dispose the Graphics object
                g.Dispose();
            }

            return newBitmap;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
        }
    }
}