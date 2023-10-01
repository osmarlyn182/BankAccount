using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaBancaria
{
    public partial class BankAccountinfo : Form
    {
        public string datos;    
        public BankAccountinfo()
        {
            
            InitializeComponent();
            //BankAccount kb = new BankAccount();
            //Form1 frm = new Form1();
            //frm.datos();
            //string name = kb.accountname;
            //string number = kb.accountnumber;
            //lblBienvenidaBA.Text = "Hola, " + name + " bienvienido a su cuenta bancaria no. " + number;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankAccount ac=new BankAccount();
            ac.get_balance();
        }

        private void BankAccountinfo_Load(object sender, EventArgs e)
        {
            lblBienvenidaBA.Text = datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formu = new Deposito();
            formu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Retiro();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBienvenidaBA_Click(object sender, EventArgs e)
        {
            
            //BankAccount ba = new BankAccount();
            
        }
    }
}
