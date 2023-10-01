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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {

            double dep =0;
             Double.TryParse(txtDeposito.Text, out dep);
            BankAccount account = new BankAccount();
            account.amount(dep);

        }
    }
}
