using ConsoleApp1;


class program
{
    static void Main(string[] args)
    {
        int balance = 500;
        int correctPin = 1234;

        Console.WriteLine("Enter the PIN code: ");
        int pin = int.Parse(Console.ReadLine());


        try
        {
            if (pin == correctPin)
            {
                while (true)
                {
                    Console.WriteLine("1. Show balance");
                    Console.WriteLine("2. Withdraw money from the balance");
                    Console.WriteLine("3. Add money to the balance");
                    Console.WriteLine("4. Change PIN code");


                    Console.WriteLine("Enter the choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your balance is {balance} AZN");
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Enter the amount to withdraw: ");
                                int withdraw = int.Parse(Console.ReadLine());
                                if (withdraw <= balance)
                                {
                                    balance -= withdraw;
                                    Console.WriteLine($"New balance is {balance} AZN");
                                }
                                else
                                {
                                    throw new notEnoughMoneyException("Not enough money!");
                                }
                            }
                            catch (notEnoughMoneyException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        case 3:
                            Console.WriteLine("Enter the amount to add: ");
                            int addMoney = int.Parse(Console.ReadLine());
                            balance += addMoney;
                            Console.WriteLine($"New balance is {balance}");
                            break;
                        case 4:
                            Console.WriteLine("Enter the new PIN: ");
                            int newPIN = int.Parse(Console.ReadLine());
                            pin = newPIN;
                            Console.WriteLine($"PIN code changed \nNew PIN is {pin}");
                            break;
                        default:
                            Console.WriteLine("Incorrect choice! please choice 1,2,3 or 4");
                            break;
                    }
                }
            }
            else
            {
                throw new IncorrectPINexception("Incorrect PIN!!! try again");
            }
        }
        catch (IncorrectPINexception ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex) 
        { 
            Console.WriteLine(ex.Message);
        }
    }


}
