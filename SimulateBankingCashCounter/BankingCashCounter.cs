using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCashCounter
{
    public class BankingCashCounter
    {
        Queue<string> queue = new Queue<string>();
        public int amount = 200000;

        public void updateCash()
        {
            addPeople();
            while(queue.Count != 0)
            {
                Console.WriteLine("Please select a num : {0}", queue.Peek());
                Console.WriteLine("Enter 1 To Withdraw 2 To Deposit");
                int option = Convert.ToInt32(Console.ReadLine());

                if(option == 1)
                {
                    bool isSufficientBalance = false;
                    while(!isSufficientBalance)
                    {
                        Console.WriteLine("Enter amount to withdraw");
                        int withdraw = Convert.ToInt32(Console.ReadLine());

                        if(amount-withdraw >= 0)
                        {
                            amount -= withdraw;
                            isSufficientBalance = true;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance,please enter amount less than or equal to {0} : ", amount);
                        }
                    }
                    queue.Dequeue();
                }
                else if(option == 2)
                {
                    Console.WriteLine("Enter amount to deposit: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    amount += deposit;
                    queue.Dequeue();
                }

            }
            Console.WriteLine("Balance left : " + amount);
        }
        public void addPeople()
        {
            queue.Enqueue("Pooja");
            queue.Enqueue("Vishal");
            queue.Enqueue("Srushti");
            queue.Enqueue("Megha");
            queue.Enqueue("Aarti");

        }
    }
}
