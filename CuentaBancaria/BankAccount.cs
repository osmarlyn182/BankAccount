using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CuentaBancaria
{
   internal class BankAccount
    {
        public  string accountnumber;
        public  string accountname;
        public static double balance=0;


        public void amount(double deposito)
        {
            
            double ingresar = deposito;
           

            if (ingresar < 0)
            {
                MessageBox.Show("No se puede ingresar numeros negativos");
            }
            else
            {
                balance = ingresar;
                MessageBox.Show("Se añadido sastifactoriamente!");
            }
        }

        public void withdraw( double retirar)
        {
            double retiro = 0;

            if (retiro> balance)
            {

                MessageBox.Show("La cantidad es mayor que el balance.");

            }
            else
            {
                balance = balance-retirar;
                MessageBox.Show("Se ha retirado sastifactoriamente");
            }
        }
        public void get_balance()
        {
            MessageBox.Show("Su balance es " + balance);
        }
        //public void name(string n)
        //{
            
            
        //}
        //public void number(string num)
        //{

        //}
    }
}
