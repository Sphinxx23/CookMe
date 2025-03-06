using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIS_Click(object sender, EventArgs e)
        {
            Views.Login.Login log = new Views.Login.Login(this);
            log.Show();
            this.Visible = false;
        }

        private void btRG_Click(object sender, EventArgs e)
        {
            Views.Login.Register reg = new Views.Login.Register(this);
            reg.Show();
            this.Visible = false;
        }
    }
}
