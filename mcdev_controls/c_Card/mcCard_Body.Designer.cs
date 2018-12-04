namespace mcdev_controls.c_Card
{
    partial class mcCard_Body
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
            this.lblTitle = new pControlsDev.Generic.LabelJos();
            this.lblInfo_1 = new pControlsDev.Generic.LabelJos();
            this.lblInfo_2 = new pControlsDev.Generic.LabelJos();
            this.btnAcao = new pControlsDev.Generic.ButtonJos();
            this.imgLeft = new System.Windows.Forms.PictureBox();
            this.line = new pControlsDev.Generic.LabelJos();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TITULO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo_1
            // 
            this.lblInfo_1.AutoSize = true;
            this.lblInfo_1.Location = new System.Drawing.Point(72, 36);
            this.lblInfo_1.Name = "lblInfo_1";
            this.lblInfo_1.Size = new System.Drawing.Size(41, 13);
            this.lblInfo_1.TabIndex = 1;
            this.lblInfo_1.Text = "INFO 1";
            // 
            // lblInfo_2
            // 
            this.lblInfo_2.AutoSize = true;
            this.lblInfo_2.Location = new System.Drawing.Point(72, 61);
            this.lblInfo_2.Name = "lblInfo_2";
            this.lblInfo_2.Size = new System.Drawing.Size(41, 13);
            this.lblInfo_2.TabIndex = 2;
            this.lblInfo_2.Text = "INFO 2";
            // 
            // btnAcao
            // 
            this.btnAcao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAcao.Location = new System.Drawing.Point(0, 100);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(168, 23);
            this.btnAcao.TabIndex = 3;
            this.btnAcao.Text = "Action";
            // 
            // imgLeft
            // 
            this.imgLeft.Location = new System.Drawing.Point(4, 33);
            this.imgLeft.Name = "imgLeft";
            this.imgLeft.Size = new System.Drawing.Size(62, 52);
            this.imgLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLeft.TabIndex = 4;
            this.imgLeft.TabStop = false;
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line.Location = new System.Drawing.Point(4, 94);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(161, 1);
            this.line.TabIndex = 5;
            // 
            // mcCard_Body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.line);
            this.Controls.Add(this.imgLeft);
            this.Controls.Add(this.btnAcao);
            this.Controls.Add(this.lblInfo_2);
            this.Controls.Add(this.lblInfo_1);
            this.Controls.Add(this.lblTitle);
            this.Name = "mcCard_Body";
            this.Size = new System.Drawing.Size(168, 123);
            this.Load += new System.EventHandler(this.mcCard_Body_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pControlsDev.Generic.LabelJos line;
        public pControlsDev.Generic.LabelJos lblTitle;
        public pControlsDev.Generic.LabelJos lblInfo_1;
        public pControlsDev.Generic.LabelJos lblInfo_2;
        public pControlsDev.Generic.ButtonJos btnAcao;
        public System.Windows.Forms.PictureBox imgLeft;
    }
}
