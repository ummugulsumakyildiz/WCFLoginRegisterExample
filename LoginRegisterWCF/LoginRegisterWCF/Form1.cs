using LoginRegisterWCF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service1Client servis = new Service1Client();
            MessageBox.Show( servis.register("glsm","gulsum.akyildizz@gmail.com","123").ToString()); 
            MessageBox.Show(servis.login("glsm", "123").ToString());
            servis.Close();            
        }
    }
}
