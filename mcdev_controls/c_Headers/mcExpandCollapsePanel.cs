using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcdev_controls.c_Headers
{
    [Designer(typeof(ExpandCollapsePanelDesigner))]
    public partial class mcExpandCollapsePanel : UserControl
    {
        [Browsable(false)]
        private Size _previousParentSize = Size.Empty;

        [Browsable(false)]
        private int _expandedHeight;

        [Browsable(false)]
        private readonly int _collapsedHeight;

        [Category("ExpandCollapsePanel")]
        [Description("Height of panel in expanded state.")]
        [Browsable(true)]
        public int ExpandedHeight
        {
            get { return _expandedHeight; }
            set
            {
                _expandedHeight = value;
                if (IsExpanded)
                {
                    Height = _expandedHeight;
                }
            }
        }

        [Browsable(false)]
        public Color _backheader { get; set; }
        public Color _Background_header 
        { 
            get 
            {
                return _backheader;
            }
            set
            {
                _backheader = value;
                _btnExpandCollapse.BackColor = value;
                lblHeader.BackColor = value;
            } 
        }

        [Browsable(false)]
        public Color _lblHColor { get; set; }

        [Category("ExpandCollapsePanel")]
        [Description("Cor do texto no cabeçalho")]
        public Color _LblHeaderColor
        {
            get
            {
                return _lblHColor;
            }
            set
            {
                _lblHColor = value;
                lblHeader.ForeColor = value;
            }
        }

        [Category("ExpandCollapsePanel")]
        [Description("Expande ou Esconde Body")]
        [Browsable(true)]
        public bool IsExpanded
        {
            get { return _btnExpandCollapse.IsExpanded; }
            set 
            { 
                if(_btnExpandCollapse.IsExpanded != value)
                    _btnExpandCollapse.IsExpanded = value; 
            }
        }

        [Browsable(false)]
        public String TextHeader { get; set; }

        [Category("ExpandCollapsePanel")]
        [Browsable(true)]
        public override string Text
        {
            get
            {
                return lblHeader.Text;
            }
            set
            {
                lblHeader.Text = value;
                TextHeader = value;
            }
        }
        
        [Browsable(false)]
        public bool allowExpand { get; set; }

        [Category("ExpandCollapsePanel")]
        [Description("Define se permite expandir o controle, caso false voce pode trocar a imagem do header")]
        [Browsable(true)]
        public bool _AllowExpand
        {
            get { return allowExpand; }
            set
            {
                allowExpand = value;
                AllowExpand();
            }
        }

        [Category("ExpandCollapsePanel")]
        [Description("Quando o painel foi expandido ou recolhido.")]
        [Browsable(true)]
        public event EventHandler<ExpandCollapseEventArgs> ExpandCollapse;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public mcExpandCollapsePanel()
        {
            InitializeComponent();

            _Background_header = Color.FromArgb(191, 205, 219);

            // make collapsed height equals to fit expand-collapse button
             _collapsedHeight = _btnExpandCollapse.Size.Height;

            //_btnExpandCollapse.AutoSize = true;

            // initial state of panel - expanded
             _btnExpandCollapse.IsExpanded = true;
            // subscribe for button expand-collapse state changed event
            _btnExpandCollapse.ExpandCollapse += BtnExpandCollapseExpandCollapse;

            _AllowExpand = true;
        }

        /// <summary>
        /// Evento de mudança de estado de expansão e colapso do botão de controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExpandCollapseExpandCollapse(object sender, ExpandCollapseEventArgs e)
        {
            if (e.IsExpanded) // if button is expanded now
            {
                Expand(); // expand the panel
            }
            else
            {
                Collapse(); // collapse the panel
            }

            // Retrieve expand-collapse state changed event for panel
            EventHandler<ExpandCollapseEventArgs> handler = ExpandCollapse;
            if (handler != null)
                handler(this, e);
        }

        /// <summary>
        /// Expande conteudo do painel
        /// </summary>
        protected virtual void Expand()
        {
            Size = new Size(Size.Width, _expandedHeight);            
        }

        /// <summary>
        /// Collapse panel content
        /// </summary>
        protected virtual void Collapse()
        {
            _expandedHeight = Size.Height;         
            Size = new Size(Size.Width, _collapsedHeight);            
        }

        /// <summary>
        /// Handle panel resize event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            #region Handling panel's Anchor property sets to Bottom when panel collapsed

            if (!IsExpanded // if panel collapsed
                && ((Anchor & AnchorStyles.Bottom) != 0) //and panel's Anchor property sets to Bottom
                && Size.Height != _collapsedHeight // and panel height is changed (it could happens only if parent control just has resized)
                && Parent != null) // and panel has the parent control
            {
                // main, calculate the parent control resize diff and add it to expandedHeight value:
                _expandedHeight += Parent.Height - _previousParentSize.Height;

                // reset resized height (by base.OnSizeChanged anchor.Bottom handling) to collapsedHeight value:
                Size = new Size(Size.Width, _collapsedHeight);
            }

            // store previous size of parent control (however we need only height)
            if(Parent != null)
                _previousParentSize = Parent.Size;
            #endregion
        }

        private void ExpandCollapsePanel_Load(object sender, EventArgs e)
        {
            Text = TextHeader;
            _Background_header = _backheader;
            _LblHeaderColor = _lblHColor;
        }
        
        private void AllowExpand()
        {
            if (allowExpand)
            {
                lblHeader.Location = new Point(35, 7);
                //lblHeader.Size = new System.Drawing.Size(34, 151);
                _btnExpandCollapse.pictureBox1.Show();
                _btnExpandCollapse.label6.Show();

                _btnExpandCollapse.imgHeader.Hide();
                imgHeader = null;
            }
            else
            {
                lblHeader.Location = new Point(3, 7);
                //lblHeader.Size = new System.Drawing.Size(34, this.Size.Height);
                _btnExpandCollapse.pictureBox1.Hide();
                _btnExpandCollapse.label6.Hide();
            }

            Invalidate();
        }

        private Image imgHeader { get; set; }
        [Browsable(true)]
        public Image _ImgHeader
        {
            get { return imgHeader; }
            set
            {
                imgHeader = value;
                SetaImagemHeader();
            }
        }

        private void SetaImagemHeader()
        {
            if (_ImgHeader == null)
            {
                return;
            }

            if (!_AllowExpand)
            {
                _btnExpandCollapse.imgHeader.Image = _ImgHeader;
                _btnExpandCollapse.imgHeader.Show();

                lblHeader.Location = new Point(35, 7);
                _btnExpandCollapse.pictureBox1.Show();
                _btnExpandCollapse.label6.Show();

                _btnExpandCollapse.pictureBox1.Hide();
                _btnExpandCollapse.label6.Hide();
            }
            else
            {
                imgHeader = null;
                _btnExpandCollapse.imgHeader.Show();
                MessageBox.Show(" Para definir a imagem no header, defina AllowExpand para false, desmarque! ");
            }
        }
    }
}
