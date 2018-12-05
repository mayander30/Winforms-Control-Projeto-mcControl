namespace mcdev_controls.c_Card
{
    partial class mcExpandCard
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
            this.lbl_separator = new System.Windows.Forms.Label();
            this.imgExpand = new System.Windows.Forms.PictureBox();
            this.imgHeader = new System.Windows.Forms.PictureBox();
            this.painel_header = new System.Windows.Forms.Panel();
            this.painel_content = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
            this.painel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Transparent;
            this.lblHeader.Location = new System.Drawing.Point(36, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(51, 16);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "label1";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblHeader.MouseLeave += new System.EventHandler(this.painel_header_MouseLeave);
            this.lblHeader.MouseHover += new System.EventHandler(this.painel_header_MouseHover);
            // 
            // lbl_separator
            // 
            this.lbl_separator.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_separator.Location = new System.Drawing.Point(28, 6);
            this.lbl_separator.Name = "lbl_separator";
            this.lbl_separator.Size = new System.Drawing.Size(2, 12);
            this.lbl_separator.TabIndex = 27;
            // 
            // imgExpand
            // 
            this.imgExpand.Image = global::mcdev_controls.Properties.Resources.Expand;
            this.imgExpand.Location = new System.Drawing.Point(10, 6);
            this.imgExpand.Name = "imgExpand";
            this.imgExpand.Size = new System.Drawing.Size(13, 12);
            this.imgExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgExpand.TabIndex = 26;
            this.imgExpand.TabStop = false;
            this.imgExpand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.imgExpand.MouseLeave += new System.EventHandler(this.painel_header_MouseLeave);
            this.imgExpand.MouseHover += new System.EventHandler(this.painel_header_MouseHover);
            // 
            // imgHeader
            // 
            this.imgHeader.Location = new System.Drawing.Point(6, 2);
            this.imgHeader.Name = "imgHeader";
            this.imgHeader.Size = new System.Drawing.Size(23, 20);
            this.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgHeader.TabIndex = 28;
            this.imgHeader.TabStop = false;
            this.imgHeader.Visible = false;
            // 
            // painel_header
            // 
            this.painel_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.painel_header.Controls.Add(this.imgExpand);
            this.painel_header.Controls.Add(this.lbl_separator);
            this.painel_header.Controls.Add(this.lblHeader);
            this.painel_header.Controls.Add(this.imgHeader);
            this.painel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_header.Location = new System.Drawing.Point(0, 0);
            this.painel_header.Name = "painel_header";
            this.painel_header.Size = new System.Drawing.Size(298, 22);
            this.painel_header.TabIndex = 29;
            this.painel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.painel_header.MouseLeave += new System.EventHandler(this.painel_header_MouseLeave);
            this.painel_header.MouseHover += new System.EventHandler(this.painel_header_MouseHover);
            // 
            // painel_content
            // 
            this.painel_content.BackColor = System.Drawing.SystemColors.ControlDark;
            this.painel_content.Location = new System.Drawing.Point(-1, 21);
            this.painel_content.Name = "painel_content";
            this.painel_content.Size = new System.Drawing.Size(299, 99);
            this.painel_content.TabIndex = 2;
            // 
            // mcExpandCard
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.painel_header);
            this.Controls.Add(this.painel_content);
            this.Name = "mcExpandCard";
            this.Size = new System.Drawing.Size(298, 226);
            this.Load += new System.EventHandler(this.mcExpandCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
            this.painel_header.ResumeLayout(false);
            this.painel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_separator;
        public System.Windows.Forms.PictureBox imgExpand;
        public System.Windows.Forms.PictureBox imgHeader;
        private System.Windows.Forms.Panel painel_header;
        private System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Panel painel_content;
    }
}
