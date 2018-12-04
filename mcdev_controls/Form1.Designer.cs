namespace mcdev_controls
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mcExpandVerticalCollapsePanel1 = new mcdev_controls.c_Headers.Vertical.mcExpandVerticalCollapsePanel();
            this.mcExpandCollapsePanel1 = new mcdev_controls.c_Headers.mcExpandCollapsePanel();
            this.mcPanelBorderRounded1 = new mcdev_controls.c_Painel.mcPanelBorderRounded();
            this.mcTextBox_Moeda1 = new mcdev_controls.c_TextBox.mcTextBox_Moeda();
            this.mcTextBox1 = new mcdev_controls.c_TextBox.mcTextBox(this.components);
            this.mcButton1 = new mcdev_controls.c_Generic.mcButton(this.components);
            this.mcLabelVertical1 = new mcdev_controls.c_Generic.mcLabelVertical();
            this.mcTextBox2 = new mcdev_controls.c_TextBox.mcTextBox(this.components);
            this.SuspendLayout();
            // 
            // mcExpandVerticalCollapsePanel1
            // 
            this.mcExpandVerticalCollapsePanel1._AllowExpand = true;
            this.mcExpandVerticalCollapsePanel1._Background_header = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.mcExpandVerticalCollapsePanel1._backheader = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.mcExpandVerticalCollapsePanel1._ImgHeader = null;
            this.mcExpandVerticalCollapsePanel1._lblHColor = System.Drawing.Color.Empty;
            this.mcExpandVerticalCollapsePanel1._LblHeaderColor = System.Drawing.Color.Empty;
            this.mcExpandVerticalCollapsePanel1.allowExpand = true;
            this.mcExpandVerticalCollapsePanel1.BackColor = System.Drawing.SystemColors.Control;
            this.mcExpandVerticalCollapsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mcExpandVerticalCollapsePanel1.ExpandedWidth = 139;
            this.mcExpandVerticalCollapsePanel1.ForeColor = System.Drawing.Color.White;
            this.mcExpandVerticalCollapsePanel1.IsExpanded = true;
            this.mcExpandVerticalCollapsePanel1.Location = new System.Drawing.Point(385, 13);
            this.mcExpandVerticalCollapsePanel1.Name = "mcExpandVerticalCollapsePanel1";
            this.mcExpandVerticalCollapsePanel1.Size = new System.Drawing.Size(139, 264);
            this.mcExpandVerticalCollapsePanel1.TabIndex = 6;
            this.mcExpandVerticalCollapsePanel1.TextHeader = "mcExpandVerticalCollapsePanel1";
            // 
            // mcExpandCollapsePanel1
            // 
            this.mcExpandCollapsePanel1._AllowExpand = true;
            this.mcExpandCollapsePanel1._Background_header = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.mcExpandCollapsePanel1._backheader = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.mcExpandCollapsePanel1._ImgHeader = null;
            this.mcExpandCollapsePanel1._lblHColor = System.Drawing.Color.Empty;
            this.mcExpandCollapsePanel1._LblHeaderColor = System.Drawing.Color.Empty;
            this.mcExpandCollapsePanel1.allowExpand = true;
            this.mcExpandCollapsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mcExpandCollapsePanel1.ExpandedHeight = 0;
            this.mcExpandCollapsePanel1.IsExpanded = true;
            this.mcExpandCollapsePanel1.Location = new System.Drawing.Point(149, 12);
            this.mcExpandCollapsePanel1.Name = "mcExpandCollapsePanel1";
            this.mcExpandCollapsePanel1.Size = new System.Drawing.Size(229, 121);
            this.mcExpandCollapsePanel1.TabIndex = 5;
            this.mcExpandCollapsePanel1.TextHeader = "mcExpandCollapsePanel1";
            // 
            // mcPanelBorderRounded1
            // 
            this.mcPanelBorderRounded1._background = System.Drawing.SystemColors.ActiveCaption;
            this.mcPanelBorderRounded1._RADIUS = 50F;
            this.mcPanelBorderRounded1.Location = new System.Drawing.Point(149, 150);
            this.mcPanelBorderRounded1.Name = "mcPanelBorderRounded1";
            this.mcPanelBorderRounded1.Size = new System.Drawing.Size(229, 127);
            this.mcPanelBorderRounded1.TabIndex = 4;
            // 
            // mcTextBox_Moeda1
            // 
            this.mcTextBox_Moeda1._DECIMAIS_MOEDA = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mcTextBox_Moeda1._SHOWSIMBOLO = false;
            this.mcTextBox_Moeda1.Location = new System.Drawing.Point(28, 67);
            this.mcTextBox_Moeda1.Name = "mcTextBox_Moeda1";
            this.mcTextBox_Moeda1.Size = new System.Drawing.Size(100, 20);
            this.mcTextBox_Moeda1.TabIndex = 3;
            this.mcTextBox_Moeda1.Text = "26,65";
            this.mcTextBox_Moeda1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mcTextBox1
            // 
            this.mcTextBox1.Location = new System.Drawing.Point(28, 13);
            this.mcTextBox1.Name = "mcTextBox1";
            this.mcTextBox1.Size = new System.Drawing.Size(100, 20);
            this.mcTextBox1.TabIndex = 1;
            // 
            // mcButton1
            // 
            this.mcButton1.Location = new System.Drawing.Point(31, 106);
            this.mcButton1.Name = "mcButton1";
            this.mcButton1.Size = new System.Drawing.Size(97, 27);
            this.mcButton1.TabIndex = 0;
            this.mcButton1.Text = "mcButton1";
            this.mcButton1.UseVisualStyleBackColor = true;
            // 
            // mcLabelVertical1
            // 
            this.mcLabelVertical1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcLabelVertical1.Location = new System.Drawing.Point(-3, 9);
            this.mcLabelVertical1.Name = "mcLabelVertical1";
            this.mcLabelVertical1.Size = new System.Drawing.Size(28, 124);
            this.mcLabelVertical1.TabIndex = 7;
            this.mcLabelVertical1.Text = "Controles TextBox";
            // 
            // mcTextBox2
            // 
            this.mcTextBox2.Location = new System.Drawing.Point(135, 333);
            this.mcTextBox2.Name = "mcTextBox2";
            this.mcTextBox2.Size = new System.Drawing.Size(162, 20);
            this.mcTextBox2.TabIndex = 8;
            this.mcTextBox2.Text = "mcTextBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 441);
            this.Controls.Add(this.mcTextBox2);
            this.Controls.Add(this.mcLabelVertical1);
            this.Controls.Add(this.mcExpandVerticalCollapsePanel1);
            this.Controls.Add(this.mcExpandCollapsePanel1);
            this.Controls.Add(this.mcPanelBorderRounded1);
            this.Controls.Add(this.mcTextBox_Moeda1);
            this.Controls.Add(this.mcButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private c_Generic.mcButton mcButton1;
        private c_TextBox.mcTextBox mcTextBox1;
        private c_TextBox.mcTextBox_Moeda mcTextBox_Moeda1;
        private c_Painel.mcPanelBorderRounded mcPanelBorderRounded1;
        private c_Headers.mcExpandCollapsePanel mcExpandCollapsePanel1;
        private c_Headers.Vertical.mcExpandVerticalCollapsePanel mcExpandVerticalCollapsePanel1;
        private c_Generic.mcLabelVertical mcLabelVertical1;
        private c_TextBox.mcTextBox mcTextBox2;

    }
}