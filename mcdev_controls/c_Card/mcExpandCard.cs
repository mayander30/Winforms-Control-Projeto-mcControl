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
        public Color _BackColorHeader { get { return painel_header.BackColor; } set { SetBackColorHeader(value); } }

        #endregion



        #region propiedades de armazanamento dos valores

        [Browsable(false)]
        public bool IsExpanded { get; set; }

        public Size SizeControl { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentsPanel
        {
            get { return painel_content; }
        }

        #endregion


        /// <summary>
        /// Constructor
        /// </summary>
        public mcExpandCard()
        {
            InitializeComponent();

            TypeDescriptor.AddAttributes(this.painel_content,
            new DesignerAttribute(typeof(mcCard_ControlDesigner)));
        }

        #region functions set propiedades

        private void SetImagemHeader()
        {
            if (this.imgHeader == null)
            {
                return;
            }

            //if (!_AllowExpand)
            //{
            //    this.imgHeader.Show();

            //    lblHeader.Location = new Point(35, 7);
            //    this.pictureBox1.Show();
            //    this.lbl_separator.Show();

            //    this.pictureBox1.Hide();
            //    this.lbl_separator.Hide();
            //}
            //else
            //{
            //    imgHeader = null;
            //    this.imgHeader.Show();
            //    MessageBox.Show(" Para definir a imagem no header, defina AllowExpand para false, desmarque! ");
            //}
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
                this.Size = new Size(this.Size.Width, painel_header.Height+1);

                var bmp = Properties.Resources.Expand;
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                imgExpand.Image = bmp;
            }
            else
            {
                IsExpanded = true;

                this.Size = SizeControl;

                var bmp = Properties.Resources.Expand;
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                imgExpand.Image = bmp;

            }
        }

        private void SetBackColorHeader(Color value)
        {
            painel_header.BackColor = value;
        }

        #endregion

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
    }
}
