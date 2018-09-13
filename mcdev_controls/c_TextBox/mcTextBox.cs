using mcdev_controls.C_TextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcdev_controls.c_TextBox
{
    [Designer(typeof(TextBoxDesigner))]
    public partial class mcTextBox : TextBox
    {
        public mcTextBox()
        {
            InitializeComponent();
        }

        public mcTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
