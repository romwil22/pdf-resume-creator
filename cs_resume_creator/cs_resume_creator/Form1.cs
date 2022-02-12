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
        
        public resume()
        {
            InitializeComponent();
        }

        private void resume_Load(object sender, EventArgs e)
        {

        }

        private void pdf_resume_Click(object sender, EventArgs e)
        {
            // WRITE PDF
            Document PDFresume = new Document();
            PdfWriter.GetInstance(PDFresume, new FileStream(@"C:\Users\Rom\Desktop\5TH YR 1ST SEM FILES\OOP\pdf-resume-creator\cs_resume_creator\cs_resume_creator\PILAPIL_ROMWIL_JAMES.pdf", FileMode.Create));
            LineSeparator hl = new LineSeparator(3f, 100f, BaseColor.DARK_GRAY, Element.ALIGN_CENTER, 1);

            Paragraph fname = new Paragraph(fullname_textbox.Text);
            Paragraph add = new Paragraph(address_richbox.Text);
            Paragraph emailMobile = new Paragraph(email_richbox.Text+" | Mobile No: "+mobile_textbox.Text+"\n\n");
            Paragraph carObj = new Paragraph("Career Objective"+"\n"+"     " + car_obj_richbox.Text+"\n\n");
            Paragraph profAtt = new Paragraph("Proffesional Atributes"+"\n"+"     " + prof_att_richbox.Text+"\n\n");
            Paragraph tert = new Paragraph("Education"+"\n\n"+"Tertiary: "+educ_richbox.Text+ "\n\n");
            Paragraph extAct = new Paragraph("Extraculicular Activity" + "\n" + "     " + extra_act_ricbox.Text + "\n\n");
            Paragraph cert = new Paragraph("Certificate, Workshops, and Seminar Attended" + "\n" + "     " + cert_etc_richbox.Text + "\n\n\n");

            PDFresume.Open();
            PDFresume.Add(fname);
            PDFresume.Add(add);
            PDFresume.Add(emailMobile);
            PDFresume.Add(hl);
            PDFresume.Add(carObj);
            PDFresume.Add(profAtt);
            PDFresume.Add(tert);
            PDFresume.Add(extAct);
            PDFresume.Add(cert);
            PDFresume.Close();

            MessageBox.Show("PDF file create successfully", "Information" ,MessageBoxButtons.OK);
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

        private void read_json_Click(object sender, EventArgs e)
        {
            // READ JSON
            string jsonFile = @"C:\Users\Rom\Desktop\5TH YR 1ST SEM FILES\OOP\pdf-resume-creator\cs_resume_creator\cs_resume_creator\resume_info.json";
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
    }
}
