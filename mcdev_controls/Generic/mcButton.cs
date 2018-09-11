using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcdev_controls.Generic
{
    public partial class mcButton : Button
    {
        public mcButton()
        {
            InitializeComponent();
        }

        public mcButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
