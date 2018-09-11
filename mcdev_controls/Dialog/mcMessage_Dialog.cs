using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcdev_controls.Dialog
{
    public enum TipoIcoMsgBox
    {
        ICO_SUCESSO,
        ICO_ALERTA,
        ICO_ERRO,
        SEMICONE
    }

    public partial class mcMessage_Dialog : Form
    {
        public int _SEGUNDOS_FECHAR { get; set; }
        public TipoIcoMsgBox _tipoMsgBox { get; set; }

        public mcMessage_Dialog(String title = "", String msg = "")
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

            this.lblMensagem.Text = msg;
                        
            this.Focus();
        }
        
        private void Message_Dialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Escape)){
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
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

            if (_tipoMsgBox == TipoIcoMsgBox.ICO_ERRO)
            {
                pictureBox1.Image = mcdev_controls.Properties.Resources.sign_error;
                lblMensagem.Location = new Point(39, 37);
            }
            else if (_tipoMsgBox == TipoIcoMsgBox.ICO_ALERTA)
            {
                pictureBox1.Image = mcdev_controls.Properties.Resources.sign_warning;
                lblMensagem.Location = new Point(39, 37);
            }
            else if (_tipoMsgBox == TipoIcoMsgBox.ICO_SUCESSO)
            {
                pictureBox1.Image = mcdev_controls.Properties.Resources.sign_success;
                lblMensagem.Location = new Point(39, 37);
            }
            else
            {
                pictureBox1.Hide();
                lblMensagem.Location = new Point(10, 37);
            }

            this.Height = lblMensagem.Height + 75;
            if (lblTitle.Width < lblMensagem.Width)
            {
                this.Width = lblMensagem.Width + 70;
            }
            else
            {
                this.Width = lblTitle.Width + 70;
            }

            base.OnLoad(e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Message_Dialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(lblMensagem.Text);
            }
        }        
    }
}
