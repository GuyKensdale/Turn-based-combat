using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_based_combat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int pcHp = 40;

            int playerAttack = 5;
            int pcAttack = 4;

            int healAmount = 5;

            Random random = new Random();

            while(playerHp > 0 && pcHp > 0) 
            {
                //player turn
                Console.WriteLine();
                Console.WriteLine("--Your turn--");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();
                if(choice == "a")
                {
                    pcHp -= playerAttack;
                    Console.WriteLine("You hit the enemy for " + playerAttack + "damage!" + "\n");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("You healed for" + healAmount + "HP!");
                    Console.WriteLine("Your tottal HP is " + playerHp + "\n");
                }
                
                //enemy turn 

                if (pcHp > 0)
                   
                Console.WriteLine("--Enemy turn--");
                {
                    Console.WriteLine("it's the enemys turn ");
                    int pcChoice = random.Next(0,2);
                    if(pcChoice == 0)
                    {
                        playerHp -= pcAttack;
                        Console.WriteLine("Enemy attack deals " + pcAttack);
                        Console.WriteLine("Your tottal HP is " + playerHp + "\n");
                    }
                    else {
                        pcHp += healAmount;
                        Console.WriteLine("The enemy heals for " + healAmount);
                        Console.WriteLine("Their total HP is " + pcHp + "\n");
                    }
                }
            }

        if(playerHp > 0)
            {
                Console.WriteLine("Congratulations, you have won");
                Console.ReadLine();
            }
        else
            {
                Console.WriteLine("You lost try again");
                Console.ReadLine();
            }
        }
       
    }
}
