using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace xmlTAble
{
    public partial class Form1 : Form
    {
        XDocument doc;
        DataSet ds;
        const string STUDENT = "student";
        const string FNAME = "firstName";
        const string LNAME = "lastName";
        const string ADDRESS = "Address";
        const string STREET = "street";
        const string HOUSE = "house";
        const string GRADE = "grade";
        const string SUBJECT = "Subject";
        const string MARK = "";
        const string STUDENTS = "students";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFromXMl();
        }
        private void ReadFromXMl()
        {
            
            try
            {
                doc = XDocument.Load(ConfigurationManager.AppSettings["XmlFile"]);
                // dataGridView1.DataSource = doc.Elements("STUDENTS").FirstOrDefault().Elements("STUDENT").Select(st => new { id = st.Attribute("id").Value, first_name = st.Element(FNAME).Value, last_name = st.Element("LNAME").Value }).ToList();
                ds.ReadXml("student.xml");
        DataGridView1.DataSource = ds.Tables(0)
            }
            catch
            {
                toolStrip1.Text = "שגיאה";
            }

        }
    }
}
