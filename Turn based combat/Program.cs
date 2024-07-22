using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Turn_based_combat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int pcHp = 40;

            int playerAttack1 = 5;
            int playerAttack2 = 6;
            int pcAttack = 4;

            int healAmount = 5;

            Random random = new Random();

            while(playerHp > 0 && pcHp > 0) 
            {
                //player turn
                Console.WriteLine();
                Console.WriteLine("--Your turn--");
                Console.WriteLine("Enter 'Scratch' to use Scratch attack, 'Heal' to  use Heal, 'Ember' to use Ember");

                string choice = Console.ReadLine();
                if(choice == "Scratch")
                {
                    pcHp -= playerAttack1;
                    Console.WriteLine("You hit the enemy for " + playerAttack1 + "damage!" + "\n");
                    Console.WriteLine("The enemy pokemons tottal HP is " + pcHp + "\n");
                    Console.WriteLine("...");
                    Thread.Sleep(1000);
                }
                else if(choice == "Ember")
                {
                    pcHp -= playerAttack2;
                    Console.WriteLine("You hit the enemy for " + playerAttack2 + "damage!" + "\n");
                    Console.WriteLine("The enemy pokemons tottal HP is " + pcHp + "\n");
                    Console.WriteLine("...");
                    Thread.Sleep(1000);
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("You healed for" + healAmount + "HP!");
                    Console.WriteLine("Your tottal HP is " + playerHp + "\n");
                    Console.WriteLine("...");
                    Thread.Sleep(1000);
                }
                
                //enemy turn 

                if (pcHp > 0)
                   
                Console.WriteLine("--Enemy turn--");
                Thread.Sleep(1000);
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
