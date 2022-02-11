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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.text;


namespace cs_resume_creator
{
    public partial class resume : Form
    {
        string jsonFile = @"C:\Users\Rom\Desktop\5TH YR 1ST SEM FILES\OOP\pdf-resume-creator\cs_resume_creator\cs_resume_creator\resume_info.json";
        public resume()
        {
            InitializeComponent();
        }

        private void resume_Load(object sender, EventArgs e)
        {

        }

        private void pdf_resume_Click(object sender, EventArgs e)
        {
            // JSON
            string readJsonFile = File.ReadAllText(jsonFile);
            Readjson jsonFileOutput = JsonConvert.DeserializeObject<Readjson>(readJsonFile);

            fullname_textbox.Text = jsonFileOutput.fullname;
            address_richbox.Text = jsonFileOutput.address;
            email_richbox.Text = jsonFileOutput.email;
            mobile_textbox.Text = jsonFileOutput.mobile;
            car_obj_richbox.Text = jsonFileOutput.car_obj;
            prof_att_richbox.Text = jsonFileOutput.prof_att;
            educ_richbox.Text = jsonFileOutput.tertiary;
            extra_act_ricbox.Text = jsonFileOutput.extra_act;
            cert_etc_richbox.Text = jsonFileOutput.cert;

            fullname_textbox.Enabled = true;
            address_richbox.Enabled = true;
            email_richbox.Enabled = true;
            mobile_textbox.Enabled = true;
            car_obj_richbox.Enabled = true;
            prof_att_richbox.Enabled = true;
            educ_richbox.Enabled = true;
            extra_act_ricbox.Enabled = true;
            cert_etc_richbox.Enabled = true;

        }

        public class Readjson
        {
            public string fullname { get; set; }
            public string address { get; set; }
            public string email { get; set; }
            public string mobile { get; set; }
            public string car_obj { get; set; }
            public string prof_att { get; set; }
            public string tertiary { get; set; }
            public string extra_act { get; set; }
            public string cert { get; set; }
        }
    }
}
