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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public void datos()
        //{
        //    BankAccount bk = new BankAccount();
        //    bk.accountname = txtAccountHolder.Text;
        //    bk.accountnumber = txtAccountNumber.Text;
        //    MessageBox.Show(bk.accountname + bk.accountnumber);

        //}

        private void btnSignin_Click(object sender, EventArgs e)
        {

           
            BankAccountinfo ba = new BankAccountinfo();
            ba.datos = "Hola, "+txtAccountHolder.Text+" Bienvenido a tu cuenta bancaria no. " + txtAccountNumber.Text;
            ba.Show();
           
            
           
            
            
        }
        
    }
}
