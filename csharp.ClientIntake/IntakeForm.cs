using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp.ClientIntake
{
    public partial class IntakeForm : Form
    {
        private Client client = new Client();
        public IntakeForm()
        {
            InitializeComponent();
        }
    }
}
