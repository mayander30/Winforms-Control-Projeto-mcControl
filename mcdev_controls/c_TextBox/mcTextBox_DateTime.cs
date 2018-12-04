using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcdev_controls.c_TextBox
{
    public enum TipoFormato
    {
        Data,
        Data_Hora,
        Ano,
        Ano_Mes,        
        Hora,
        Hora_Segundo
    }

    [Designer(typeof(TextBoxDesigner))]
    public partial class mcTextBox_DateTime : DateTimePicker
    {
        [Browsable(false)]
        public TipoFormato formato_campo { get; set; }
        public TipoFormato _FORMAT 
        {   get { return formato_campo; } 
            set {
                formato_campo = value;
                SetaFormato();
            } 
        }

        public mcTextBox_DateTime()
        {
            InitializeComponent();

            SetaFormato();
        }

        public void SetaFormato()
        {
            if (_FORMAT == TipoFormato.Data)
            {
                this.CustomFormat = "dd/MM/yyyy";
                this.Format = DateTimePickerFormat.Custom;
                this.ShowUpDown = false;
            }
            else if (_FORMAT == TipoFormato.Data_Hora)
            {
                this.CustomFormat = "dd/MM/yyyy HH:mm:ss";
                this.Format = DateTimePickerFormat.Custom;
                this.ShowUpDown = false;
            }
            else if (_FORMAT == TipoFormato.Ano)
            {
                this.CustomFormat = "yyyy";
                this.ShowUpDown = true;
                this.Format = DateTimePickerFormat.Custom;
            }
            else if (_FORMAT == TipoFormato.Ano_Mes)
            {
                this.CustomFormat = "yyyy/MM";
                this.Format = DateTimePickerFormat.Custom;
                this.ShowUpDown = false;
            }
            else if (_FORMAT == TipoFormato.Hora)
            {
                this.CustomFormat = "HH:mm";
                this.Format = DateTimePickerFormat.Custom;
                this.ShowUpDown = true;
            }
            else if (_FORMAT == TipoFormato.Hora_Segundo)
            {
                this.CustomFormat = "HH:mm:ss";
                this.Format = DateTimePickerFormat.Time;
                this.ShowUpDown = true;
            }
        }
        
    }
}
