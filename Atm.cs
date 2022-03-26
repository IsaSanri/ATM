using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public  class Atm
    {
        public static string Stars = "\n *******************************************";
        private static List<Account> accountList;

        public void CardList()
        {
            accountList=new List<Account>();
            {
                new Account() { noCard =1234,idAccount=1122, AccountType="Savings", Balance=12550000},
                new Account() { noCard = 1456, idAccount = 2211, AccountType = "Savings", Balance = 150000 },
                new Account() { noCard = 1789, idAccount = 1456, AccountType = "Savings", Balance = 25000000 },
            };
        }


    public static void Initialize()
        {
            Console.Clear();
            Console.WriteLine("\n" + Stars);
            Console.WriteLine("\n *********** Bienvenido a su cajero automatico ***********");
            Console.WriteLine("\n Por favor presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\n Por favor ingrese su numero de tarjeta: ");
            Console.WriteLine("");
            
            int cardNumber = int.Parse(Console.ReadLine());

            if (accountList.Contains(cardNumber){


            }


            Menu(account,bank);
            
        }

        static void Menu(Account account, Bank bank)
        {
            string option;
            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine("\n" + Stars);
                Console.WriteLine("\n *********** Bienvenido a su cajero automatico ***********");
                Console.WriteLine("\n" + Stars);
                Console.WriteLine("\n Seleccione la operación que desea realizar:");
                Console.WriteLine("\n 1.Retirar dinero");
                Console.WriteLine("\n 2.Ingresar dinero");
                Console.WriteLine("\n 3.Consultar saldo");
                Console.WriteLine("\n 4.Cambiar contraseña");
                Console.WriteLine("\n 5.Cancelar operacion");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Withdraw(account);
                        break;

                    case "2":
                        Deposit(account);
                        break;

                    case "3":
                        Consult(account);
                        break;

                    case "4":
                        ChangePIN(bank);
                        break;

                    case "5":
                        Console.WriteLine("Gracias por usar este cajero");
                        System.Threading.Thread.Sleep(3000);
                        Initialize();
                        break;
                }

                Console.WriteLine();

            } while (option != "5");
        }

        public static void ValidateUser()
        {

        }

        public static void Consult(Account account)
        {

        }

        public static void Deposit(Account account)
        {
            Console.Clear();
            Console.WriteLine(Stars);
            Console.WriteLine("\n***************  DEPOSITO  ****************");
            Console.WriteLine("");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Por favor ingrese la cantidad de dinero que desea depositar");
            Console.WriteLine("");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Deposito exitoso");
            Console.Write($"\n Nuevo saldo disponible: {account.Deposit(amount)}");
            System.Threading.Thread.Sleep(3000);
            Initialize();
        }

        public static void Withdraw(Account account)
        {
            Console.Clear();
            Console.WriteLine(Stars);
            Console.WriteLine("\n***************  RETIRO  ****************");
            Console.WriteLine("");
            int amount=int.Parse(Console.ReadLine());
            if (amount > account.Balance)
            {
                Console.WriteLine("\n Saldo insuficiente");
                System.Threading.Thread.Sleep(3000);
                Initialize();
            }
            else
            {
                Console.WriteLine("\n Retiro exitoso");
                Console.Write($"\n Nuevo saldo disponible: {account.Withdraw(amount)}");
                System.Threading.Thread.Sleep(3000);
                Initialize();
            }
        }

        public static void ChangePIN(Bank bank)
        {
            

        }
    }

}
