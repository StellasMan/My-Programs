using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundApp
{
    public partial class QuerySecondsDlg : Form
    {
        public uint m_uiSeconds = 0;

        public QuerySecondsDlg()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            m_uiSeconds = (uint)nudSeconds.Value;
        }
    }
}
