using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verif_Mail
{
    public partial class VerificationEmail : Form
    {
        public VerificationEmail()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }


        
       

        public void BTN_Valider_Click(object sender, EventArgs e)
        {
            string msg = Lib.Verification_Email(TB_Mail.Text);
            if (msg == "")
            {
                MessageBox.Show("Adresse Confirme");
            }
            else
            {

                label1.Text = msg;
                MessageBox.Show("Adresse Erronee" + msg);
            }

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
