using mcdev_controls.c_Headers;
using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace mcdev_controls.c_Headers
{
    [Designer(typeof(mcPainelExpand_ControlDesigner))]
    public partial class mcPainelExpand : UserControl
    {
        #region propriedades do controle

        [Browsable(true)]
        public bool _orentationVertical { get { return orentationVertical; } set { SetOrentarion(value); } }

        [Browsable(true)]
        public String _TextHeader { get { return lblHeader.Text; } set { SetTextHeader(value); } }

        [Browsable(true)]
        public bool _IsExpanded { get { return IsExpanded; } set { SetExpanded(value); } }

        [Browsable(true)]
        public bool _AllowExpand { get { return AllowExpand; } set { SetAllowExpand(value); } }

        [Browsable(true)]
        public Color _BackColorHeader { get { return painel_header.BackColor; } set { SetBackColorHeader(value); } }

        [Browsable(true)]
        public Image _ImgHeader { get { return imgHeader.Image; } set { SetImagemHeader(value); } }

        #endregion

        #region propiedades de armazanamento dos valores

        [Browsable(false)]
        public bool orentationVertical { get; set; }

        [Browsable(false)]
        public bool IsExpanded { get; set; }

        [Browsable(false)]
        public Size SizeControl { get; set; }

        [Browsable(false)]
        public bool AllowExpand { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentsPanel
        {
            get { return painel_content; }
        }

        [Browsable(false)]
        public int Tam_Expanded { get; set; }

        #endregion

        public mcPainelExpand()
        {
            InitializeComponent();

            orentationVertical = false;

            IsExpanded = true;
            AllowExpand = true;
            Tam_Expanded = this.Height;

            SizeControl = this.Size;
        }

        #region functions set propiedades

        private void SetImagemHeader(Image imagem)
        {
            if (imagem == null)
            {
                return;
            }

            if (!AllowExpand)
            {
                this.imgHeader.Show();
                this.imgHeader.Image = imagem;

                if (!orentationVertical)
                {
                    lblHeader.Location = new Point(36, 3);
                }
                else
                {
                    lblHeaderVertical.Location = new Point(-4, 29);
                }

                this.imgExpand.Hide();
                this.lbl_separator.Hide();
            }
            else
            {
                imgHeader.Image = null;
                this.imgHeader.Show();
                MessageBox.Show(" Para definir a imagem no header, defina AllowExpand para false, desmarque! ");
            }
        }

        private void SetTextHeader(String value)
        {
            lblHeader.Text = value;
            lblHeaderVertical.Text = value;
        }

        private void SetExpanded(bool value)
        {
            if (!orentationVertical)
            {
                if (IsExpanded)
                {
                    IsExpanded = false;
                    Tam_Expanded = this.Height;
                    this.Size = new Size(this.Size.Width, painel_header.Height + 1);
                    imgExpand.Image = Properties.Resources.Expand;
                    imgExpand.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                }
                else
                {
                    IsExpanded = true;
                    this.Size = new Size(SizeControl.Width, Tam_Expanded);
                    imgExpand.Image = Properties.Resources.Expand;
                    imgExpand.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
            }
            else
            {
                if (IsExpanded)
                {
                    IsExpanded = false;
                    Tam_Expanded = this.Width;
                    this.Size = new Size(painel_header.Width + 1, this.Height);
                    imgExpand.Image = Properties.Resources.Expand;
                    imgExpand.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                }
                else
                {
                    IsExpanded = true;
                    this.Size = new Size(Tam_Expanded, SizeControl.Height);
                    imgExpand.Image = Properties.Resources.Expand;
                    imgExpand.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                }
            }
        }

        private void SetAllowExpand(bool value)
        {
            AllowExpand = value;

            if (AllowExpand)
            {
                if (!orentationVertical)
                {
                    lblHeader.Location = new Point(36, 3);
                }
                else
                {
                    lblHeaderVertical.Location = new Point(-4, 29);
                }

                imgExpand.Show();
                lbl_separator.Show();

                imgHeader.Hide();
                imgHeader.Image = null;
            }
            else
            {
                if (!orentationVertical)
                {
                    lblHeader.Location = new Point(3, 3);
                }
                else
                {
                    lblHeaderVertical.Location = new Point(-4, 3);
                }

                imgExpand.Hide();
                lbl_separator.Hide();
            }
        }

        private void SetBackColorHeader(Color value)
        {
            painel_header.BackColor = value;
        }

        private void SetOrentarion(bool value)
        {
            orentationVertical = value;
            if (value)
            {
                lblHeaderVertical.Visible = true;
                lblHeader.Visible = false;

                imgExpand.Image = Properties.Resources.Expand;
                imgExpand.Image.RotateFlip(RotateFlipType.Rotate90FlipX);

                painel_header.Dock = DockStyle.Left;
                painel_content.Dock = DockStyle.Fill;

                painel_header.Height = this.Height;
                painel_header.Width = 22;

                imgHeader.Location = new Point(0, 2);

                imgExpand.Location = new Point(4, 6);

                lblHeaderVertical.Location = new Point(-4, 29);

                lbl_separator.Location = new Point(5, 27);
                lbl_separator.Size = new Size(12, 2);
            }
            else
            {
                lblHeaderVertical.Visible = false;
                lblHeader.Visible = true;

                imgExpand.Image = Properties.Resources.Expand;
                imgExpand.Image.RotateFlip(RotateFlipType.Rotate180FlipY);

                painel_header.Dock = DockStyle.Top;
                painel_content.Dock = DockStyle.Fill;

                painel_header.Height = 22;
                painel_header.Width = this.Width;

                imgHeader.Location = new Point(6, 2);

                imgExpand.Location = new Point(10, 6);

                lblHeader.Location = new Point(36, 3);

                lbl_separator.Location = new Point(28, 6);
                lbl_separator.Size = new Size(2, 12);

            }

           // SetExpanded(IsExpanded);
        }

        #endregion

        #region f_eventos

        private void mcExpandCard_Load(object sender, EventArgs e)
        {
            SizeControl = this.Size;
        }

        private void painel_header_MouseHover(object sender, EventArgs e)
        {
            painel_header.Cursor = Cursors.Hand;
        }

        private void painel_header_MouseLeave(object sender, EventArgs e)
        {
            painel_header.Cursor = Cursors.Default;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (AllowExpand)
            {
                SetExpanded(IsExpanded);
            }
        }

        private void mcExpandCard_Resize(object sender, EventArgs e)
        {
            if (!orentationVertical)
            {
                this.SizeControl = new Size(this.Size.Width, Tam_Expanded);
            }
            else
            {
                this.SizeControl = new Size(Tam_Expanded, this.Size.Height);
            }
        }

        #endregion


    }
}
