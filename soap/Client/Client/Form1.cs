using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHPSoapService.mySOAPPortTypeClient client = new PHPSoapService.mySOAPPortTypeClient();
            string czwartyText = comboBox1.Text;
            if (czwartyText == "Tak") czwartyText = "True";
            if (czwartyText == "Nie") czwartyText = "False";
            label6.Text = client.dodajKsiazke(textBox1.Text, textBox2.Text, textBox3.Text, czwartyText);

        }

    }
}
