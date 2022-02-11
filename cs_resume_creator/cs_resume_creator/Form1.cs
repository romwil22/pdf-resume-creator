using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace cs_resume_creator
{
    public partial class resume : Form
    {
        public resume()
        {
            InitializeComponent();
        }

        private void resume_Load(object sender, EventArgs e)
        {
            address_richbox.Text = firstname_textbox.Text + "\n" + lastname_textbox.Text + "\n" + mi_label.Text;
        }
    }
}
