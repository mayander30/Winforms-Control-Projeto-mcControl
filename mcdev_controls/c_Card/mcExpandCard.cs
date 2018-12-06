using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace mcdev_controls.c_Card
{
    [Designer(typeof(mcCard_ControlDesigner))] 
    public partial class mcExpandCard : UserControl
    {
        #region propriedades do controle

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
        public int ExpandedHeight { get; set; }

        #endregion

        public mcExpandCard()
        {
            InitializeComponent();         
            
            IsExpanded = true;
            AllowExpand = true;
            ExpandedHeight = this.Height;

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
                lblHeader.Location = new Point(36, 3);
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
        }

        private void SetExpanded(bool value)
        {
            if (IsExpanded)
            {
                IsExpanded = false;
                
                ExpandedHeight = this.Height;
                
                this.Size = new Size(this.Size.Width, painel_header.Height+1);

                var bmp = Properties.Resources.Expand;
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                imgExpand.Image = bmp;
                
            }
            else
            {
                IsExpanded = true;
                
                this.Size = new Size(SizeControl.Width, ExpandedHeight);

                var bmp = Properties.Resources.Expand;
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                imgExpand.Image = bmp;                
            }
        }

        private void SetAllowExpand(bool value)
        {
            AllowExpand = value;

            if (AllowExpand)
            {
                lblHeader.Location = new Point(36, 3);
                //lblHeader.Size = new System.Drawing.Size(34, 151);

                imgExpand.Show();
                lbl_separator.Show();

                imgHeader.Hide();
                imgHeader.Image = null;
            }
            else
            {
                lblHeader.Location = new Point(3, 3);
                //lblHeader.Size = new System.Drawing.Size(34, this.Size.Height);
                imgExpand.Hide();
                lbl_separator.Hide();
            }

            
        }

        private void SetBackColorHeader(Color value)
        {
            painel_header.BackColor = value;
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
            SetExpanded(IsExpanded);
        }

        private void mcExpandCard_Resize(object sender, EventArgs e)
        {
            this.SizeControl = new Size(this.Size.Width, ExpandedHeight);
        }

        #endregion
               
        
    }
}
