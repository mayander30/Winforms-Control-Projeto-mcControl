using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcdev_controls.Models
{
    public class Validacoes
    {
        public void ApenasValorNumerico(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad0 || 
                e.KeyCode == Keys.NumPad1 ||
                e.KeyCode == Keys.NumPad2 ||
                e.KeyCode == Keys.NumPad3 ||
                e.KeyCode == Keys.NumPad4 ||
                e.KeyCode == Keys.NumPad5 ||
                e.KeyCode == Keys.NumPad6 ||
                e.KeyCode == Keys.NumPad7 ||
                e.KeyCode == Keys.NumPad8 ||
                e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.Back)
            {
                return;
            }
            
            TextBox txt = (TextBox)sender;

            KeysConverter ke = new KeysConverter();
            String keyP = ke.ConvertToString(e.KeyCode);

            if (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                if ((e.KeyCode == Keys.V && e.Control))
                {
                    String conteudo = Clipboard.GetText();
                    try
                    {
                        double cont = Convert.ToDouble(conteudo);
                        e.SuppressKeyPress = false;
                    }
                    catch
                    {
                        e.SuppressKeyPress = true;
                    }

                }
                else if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal)
                    {
                        e.SuppressKeyPress = txt.Text.Contains(',');
                    }
                    else
                    {
                        e.SuppressKeyPress = true;
                    }
                }
            }

            

        }

        public void ApenasValorNumerico_int(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 ||
                e.KeyCode == Keys.NumPad1 ||
                e.KeyCode == Keys.NumPad2 ||
                e.KeyCode == Keys.NumPad3 ||
                e.KeyCode == Keys.NumPad4 ||
                e.KeyCode == Keys.NumPad5 ||
                e.KeyCode == Keys.NumPad6 ||
                e.KeyCode == Keys.NumPad7 ||
                e.KeyCode == Keys.NumPad8 ||
                e.KeyCode == Keys.NumPad9 ||
                e.KeyCode == Keys.Back ||
                char.IsDigit((char)e.KeyCode))
            {
                return;
            }
            else
            {
                if ((e.KeyCode == Keys.V && e.Control))
                {
                    String conteudo = Clipboard.GetText();
                    try 
                    {
                        decimal cont = Convert.ToDecimal(conteudo);
                        e.SuppressKeyPress = false;
                    }
                    catch
                    {
                        e.SuppressKeyPress = true;
                    }
                    
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }

        }
    }
}
