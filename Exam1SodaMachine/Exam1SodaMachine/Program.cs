using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //This example is meant to simulate the input of choosing grape soda and having the soda machine properly 
            //take the selection in along with the payment from the customer. The program should then accurately determine if 
            //the payment submitted is enough, detemrine if change needs to be dispensed, then proceeds to construct a new list
            //of coin objects to return the right change (while also removing the relevant coin from its own register),
            //it should also then dispense one soda can from its inventory by removing the can from its own inventory.

            //I know that putting everything together logically in regards to classes and methods is probably my weakest point, but
            //I think I'm getting a better grasp from when we initially started learning C#. I know that this program is FAR from 
            //proper/efficient. As the time got closer, I began to panic because I'm definitely slower at establishing what the flow
            //organization of my program should be, but I think I ultimately get closer to the desired end result before too too long.

            Register coinPool = new Register();
            Inventory testInventory = new Inventory();

            SodaMachine DavidsSodaMachine = new SodaMachine(new Register(), new Inventory());
            List<Coin> payment = new List<Coin>();
            for (int i = 1; i <= 3; i++)
            {
                payment.Add(coinPool.Quarter);
            }
            DavidsSodaMachine.VendSoda("Grape", payment);
            Console.ReadLine();     
        }
    }
}
