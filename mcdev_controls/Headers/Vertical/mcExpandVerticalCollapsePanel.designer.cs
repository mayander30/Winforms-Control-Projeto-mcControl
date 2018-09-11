using mcdev_controls.Generic;
namespace mcdev_controls.Headers.Vertical
{
    partial class mcExpandVerticalCollapsePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new mcdev_controls.Generic.mcLabelVertical();
            this._btnExpandCollapse = new mcdev_controls.Headers.Vertical.ExpandVerticalCollapseButton();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(2, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(34, 151);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "labelJosVertical1";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btnExpandCollapse
            // 
            this._btnExpandCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._btnExpandCollapse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnExpandCollapse.ButtonSize = mcdev_controls.Headers.Vertical.ExpandVerticalCollapseButton.ExpandButtonSize.Small;
            this._btnExpandCollapse.ButtonStyle = mcdev_controls.Headers.Vertical.ExpandVerticalCollapseButton.ExpandButtonStyle.Normal;
            this._btnExpandCollapse.IsExpanded = false;
            this._btnExpandCollapse.Location = new System.Drawing.Point(-1, -1);
            this._btnExpandCollapse.Name = "_btnExpandCollapse";
            this._btnExpandCollapse.Size = new System.Drawing.Size(41, 192);
            this._btnExpandCollapse.TabIndex = 2;
            // 
            // ExpandVerticalCollapsePanel
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this._btnExpandCollapse);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ExpandVerticalCollapsePanel";
            this.Size = new System.Drawing.Size(139, 190);
            this.Load += new System.EventHandler(this.ExpandCollapsePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ExpandVerticalCollapseButton _btnExpandCollapse;
        private mcLabelVertical lblHeader;
    }
}
