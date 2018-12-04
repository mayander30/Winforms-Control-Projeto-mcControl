using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcdev_controls.c_Dialog
{

    public partial class mcInput_Dialog : Form
    {
        public int _SEGUNDOS_FECHAR { get; set; }

        public mcInput_Dialog(String title = "", String msg = "")
        {
            InitializeComponent();

            if (!String.IsNullOrEmpty(title))
            {
                lblTitle.Text = title;
            }
            else
            {
                lblTitle.Text = "";
            }
                        
            this.Focus();
        }
        
        private void Message_Dialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Escape)){
                this.txtInput.Text = "";
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }
                
        #region mouseEvent Drag

        private bool mouseDown;
        private Point lastLocation;

        private void Message_Dialog_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Message_Dialog_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Message_Dialog_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            if (_SEGUNDOS_FECHAR > 0)
            {
                Timer timer = new Timer(); 
                timer.Interval = (_SEGUNDOS_FECHAR*1000); 
                timer.Tick += delegate
                {
                    this.DialogResult = DialogResult.Yes; 
                };
                timer.Start(); // inicia o timer
            }

            base.OnLoad(e);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            this.DialogResult = DialogResult.No;
            this.Close();
        }

    }
}
