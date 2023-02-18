using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PersonBtn_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            PersonForm personForm= new PersonForm();
            personForm.Show();
        }
    }
}
