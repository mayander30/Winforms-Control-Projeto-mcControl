namespace mcdev_controls.c_Headers
{
    partial class mcExpandCollapsePanel
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
            this.lblHeader = new System.Windows.Forms.Label();
            this._btnExpandCollapse = new mcdev_controls.c_Headers.ExpandCollapseButton_B();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Transparent;
            this.lblHeader.Location = new System.Drawing.Point(35, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(51, 16);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "label1";
            // 
            // _btnExpandCollapse
            // 
            this._btnExpandCollapse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnExpandCollapse.ButtonSize = mcdev_controls.c_Headers.ExpandCollapseButton_B.ExpandButtonSize.Normal;
            this._btnExpandCollapse.ButtonStyle = mcdev_controls.c_Headers.ExpandCollapseButton_B.ExpandButtonStyle.Normal;
            this._btnExpandCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnExpandCollapse.IsExpanded = false;
            this._btnExpandCollapse.Location = new System.Drawing.Point(0, 0);
            this._btnExpandCollapse.MaximumSize = new System.Drawing.Size(0, 40);
            this._btnExpandCollapse.Name = "_btnExpandCollapse";
            this._btnExpandCollapse.Size = new System.Drawing.Size(298, 31);
            this._btnExpandCollapse.TabIndex = 0;
            // 
            // ExpandCollapsePanel
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this._btnExpandCollapse);
            this.Name = "ExpandCollapsePanel";
            this.Size = new System.Drawing.Size(298, 146);
            this.Load += new System.EventHandler(this.ExpandCollapsePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mcdev_controls.c_Headers.ExpandCollapseButton_B _btnExpandCollapse;
        public System.Windows.Forms.Label lblHeader;
    }
}
