using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1SodaMachine
{
    class SodaMachine
    {
        Inventory inventory;
        Register register;
        List<Coin> changeToDispense;

        public SodaMachine(Register register, Inventory inventory)
        {
            this.inventory = inventory;
            this.register = register;
        }
        public void VendSoda(string selection, List<Coin> payment)
        {
            bool isThereEnoughPayment = false;
            if (selection == "Grape")
            {
                isThereEnoughPayment = VerifyPayment(inventory.GrapeSodaCan, payment);
                if (isThereEnoughPayment == true)
                {
                    AcceptPayment(inventory.GrapeSodaCan, payment, register);
                    DispenseSoda(inventory.GrapeSodas, inventory.GrapeSodaCan);
                }

            }
            else if(selection == "Orange")
            {

            }
            else if (selection == "Lemon")
            {

            }
        }
        public void DispenseSoda<T>(List<T> sodas, T soda)
        {
            sodas.Remove(soda);
        }
        public void DispenseChange(double change, Register register)
        {
            while (change > 0)
            {
                if ((change * 10) % (Math.Round(register.Quarter.Value, 2) * 10) == 0)
                {
                    register.Quarters.RemoveAt(0);
                    change -= register.Quarter.Value;
                    changeToDispense.Add(register.Quarter);
                }
                if ((change * 10) % (Math.Round(register.Dime.Value, 2) * 10) == 0)
                {
                    register.Dimes.RemoveAt(0);
                    change -= register.Dime.Value;
                    changeToDispense.Add(register.Dime);
                }
                if ((change * 10) % (Math.Round(register.Nickel.Value, 2) * 10) == 0)
                {
                    register.Nickels.RemoveAt(0);
                    change -= register.Nickel.Value;
                    changeToDispense.Add(register.Nickel);
                }
                if ((change * 10) % (Math.Round(register.Penny.Value, 2) * 10) == 0)
                {
                    register.Pennies.RemoveAt(0);
                    change -= register.Penny.Value;
                    changeToDispense.Add(register.Penny);
                }
            }
        }
        public void AcceptPayment(Soda soda, List<Coin> payment, Register register)
        {
            double changeToDispense = 0;
            double totalPaymentAmount = 0;
            for (int i = 0; i < payment.Count; i++)
            {
                totalPaymentAmount += payment[i].Value;
            }
            changeToDispense = Math.Round((totalPaymentAmount - soda.Price), 2);
            if (changeToDispense > 0)
            {
                DispenseChange(changeToDispense, register);
            }
        }
        public bool VerifyPayment(Soda soda, List<Coin> payment)
        {
            double totalPaymentAmount = 0;
            for(int i = 0; i < payment.Count; i++)
            {
                totalPaymentAmount += payment[i].Value;
            }
            return (totalPaymentAmount >= soda.Price);
        }
    }
}
