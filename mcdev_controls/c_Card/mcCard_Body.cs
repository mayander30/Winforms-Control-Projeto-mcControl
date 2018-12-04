using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcdev_controls.c_Card
{
    public partial class mcCard_Body : UserControl
    {
        public mcCard_Body()
        {
            InitializeComponent();
        }

        private void mcCard_Body_Load(object sender, EventArgs e)
        {
            if (imgLeft.Image != null)
            {
                imgLeft.Visible = true;

                lblInfo_1.Location = new Point(80, 36);
                lblInfo_2.Location = new Point(80, lblInfo_1.Location.Y + lblInfo_1.Height + 5);
            }
            else
            {
                imgLeft.Visible = false;

                lblInfo_1.Location = new Point(5, 36);
                lblInfo_2.Location = new Point(5, lblInfo_1.Location.Y + lblInfo_1.Height + 5);
            }
        }
    }
}
