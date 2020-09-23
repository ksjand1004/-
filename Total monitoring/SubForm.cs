using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_monitoring
{
    public partial class SubForm : Form
    {
        frmMain mainForm = new frmMain();
        public SubForm()
        {
            InitializeComponent();
        }
        public SubForm(frmMain _mainForm)
        {
            this.mainForm = _mainForm;
            InitializeComponent();
        }
    }
}
