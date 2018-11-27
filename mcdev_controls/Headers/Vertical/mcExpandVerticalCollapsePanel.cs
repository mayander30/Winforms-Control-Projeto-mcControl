using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcdev_controls.Headers.Vertical
{
    /// <summary>
    /// The ExpandCollapsePanel control displays a header that has a collapsible window that displays content.
    /// </summary>
    [Designer(typeof(ExpandVerticalCollapsePanelDesigner))]
    public partial class mcExpandVerticalCollapsePanel : UserControl
    {
        /// <summary>
        /// Last stored size of panel's parent control
        /// <remarks>used for handling panel's Anchor property sets to Bottom when panel collapsed
        /// in OnSizeChanged method</remarks>
        /// </summary>
        private Size _previousParentSize = Size.Empty;

        /// <summary>
        /// Height of panel in expanded state
        /// </summary>
        private int _expandedWidth;

        /// <summary>
        /// Height of panel in collapsed state
        /// </summary>
        private readonly int _collapsedWidth;

        /// <summary>
        /// Height of panel in expanded state
        /// </summary>
        [Category("ExpandCollapsePanel")]
        [Description("Height of panel in expanded state.")]
        [Browsable(true)]
        public int ExpandedWidth
        {
            get { return _expandedWidth; }
            set
            {
                _expandedWidth = value;
                if (IsExpanded)
                {
                    Width = _expandedWidth;
                }
            }
        }

        [Browsable(false)]
        public Color _backheader { get; set; }

        [Category("ExpandCollapsePanel")]
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
        [Description("Expand or collapse panel content.")]
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

        // não mostra nas propiedades
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

        [Category("ExpandCollapsePanel")]
        [Description("Occurs when the panel has expanded or collapsed.")]
        [Browsable(true)]
        public event EventHandler<ExpandCollapseEventArgs> ExpandCollapse;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public mcExpandVerticalCollapsePanel()
        {
            InitializeComponent();
            
            _Background_header = Color.FromArgb(191, 205, 219);

            // make collapsed height equals to fit expand-collapse button
            _collapsedWidth = _btnExpandCollapse.Size.Width;

            //_btnExpandCollapse.AutoSize = true;

            // initial state of panel - expanded
             _btnExpandCollapse.IsExpanded = true;
            // subscribe for button expand-collapse state changed event
            _btnExpandCollapse.ExpandCollapse += BtnExpandCollapseExpandCollapse;
            _AllowExpand = true;
        }

        //CONTROL LOAD
        private void ExpandCollapsePanel_Load(object sender, EventArgs e)
        {
            Text = TextHeader;
            _Background_header = _backheader;
            lblHeader.ForeColor = _LblHeaderColor;
        }

        /// <summary>
        /// Handle button expand-collapse state changed event
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
        /// Expand panel content
        /// </summary>
        protected virtual void Expand()
        {            
            Size = new Size(_expandedWidth, Size.Height);            
        }

        /// <summary>
        /// Collapse panel content
        /// </summary>
        protected virtual void Collapse()
        {
            _expandedWidth = Size.Width;
            // resize panel
            Size = new Size(_collapsedWidth, Size.Height);
            
        }

        /// <summary>
        /// Handle panel resize event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // we always manually scale expand-collapse button for filling the horizontal space of panel:
            //_btnExpandCollapse.Size = new Size(ClientSize.Width - _btnExpandCollapse.Margin.Left - _btnExpandCollapse.Margin.Right,
            //    _btnExpandCollapse.Width);

            #region Handling panel's Anchor property sets to Bottom when panel collapsed

            if (!IsExpanded // if panel collapsed
                && ((Anchor & AnchorStyles.Bottom) != 0) //and panel's Anchor property sets to Bottom
                && Size.Width != _collapsedWidth // and panel height is changed (it could happens only if parent control just has resized)
                && Parent != null) // and panel has the parent control
            {
                // main, calculate the parent control resize diff and add it to expandedHeight value:
                _expandedWidth += Parent.Width - _previousParentSize.Width;

                // reset resized Width (by base.OnSizeChanged anchor.Bottom handling) to collapsedHeight value:
                Size = new Size(Size.Width, _collapsedWidth);
            }

            // store previous size of parent control (however we need only height)
            if(Parent != null)
                _previousParentSize = Parent.Size;
            #endregion
        }

        [Browsable(false)]
        public bool allowExpand { get; set; }

        /// <summary>
        /// Marca se pode expandir ou se é estatico ou somente header
        /// </summary>
        [Category("ExpandCollapsePanel")]
        [Description("Expand or collapse panel content.")]
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
        
        private void AllowExpand()
        {
            if (allowExpand)
            {
                lblHeader.Location = new Point(4, 40);
                lblHeader.Size = new System.Drawing.Size(34, 151);
                _btnExpandCollapse.pictureBox1.Show();
                _btnExpandCollapse.label6.Show();

                _btnExpandCollapse.imgHeader.Hide();
                imgHeader = null;
            }
            else
            {
                lblHeader.Location = new Point(4, 2);
                lblHeader.Size = new System.Drawing.Size(34, this.Size.Height);
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

                lblHeader.Location = new Point(4, 30);
                lblHeader.Size = new System.Drawing.Size(34, 151);
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
