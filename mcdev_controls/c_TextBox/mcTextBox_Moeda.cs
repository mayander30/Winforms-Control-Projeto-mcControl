using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using mcdev_controls.Models;
using System.Windows.Forms;

namespace mcdev_controls.c_TextBox
{
    [Designer(typeof(TextBoxDesigner))]
    public partial class mcTextBox_Moeda : TextBox
    {
        public decimal _DECIMAIS_MOEDA { get; set; }
        public bool _SHOWSIMBOLO { get; set; }
        
        public mcTextBox_Moeda()
        {
            InitializeComponent();

            this.Enter += TirarMascara;
            this.Leave += RetornarMascara;
            this.KeyDown += new Validacoes().ApenasValorNumerico;

            this.TextAlign = HorizontalAlignment.Right;
        }
        
        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length > 0)
            {
                if (_SHOWSIMBOLO)
                {
                    txt.Text = double.Parse(txt.Text).ToString("C" + _DECIMAIS_MOEDA);
                }
                else
                {
                    txt.Text = double.Parse(txt.Text).ToString("N" + _DECIMAIS_MOEDA);
                }
            }
        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        
    }
}
