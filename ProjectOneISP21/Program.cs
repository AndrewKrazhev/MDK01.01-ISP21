using ProjectOneISP21;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    /*
    static void SceneIntro(int res )
    {
        string userChoose = "0";
        Console.WriteLine("==========================");
        Console.WriteLine("|| Подошёл к техникуму  ||");
        Console.WriteLine("==========================");
        Console.WriteLine("Ваши действия: \n1.Пошёл на пары \n2.Пошёл домой\n3.Попал в аварию\n4.Пошёл за шавухой");
        Console.Write(">");
        userChoose = Console.ReadLine();
        Console.WriteLine(userChoose[0]);
        res = (int)Char.GetNumericValue(userChoose[0]);
    }
    
    static int Scene0() {
        string userChoose = "0";
        int ch;
        Console.WriteLine("==========================");
        Console.WriteLine("|| Подошёл к техникуму  ||");
        Console.WriteLine("==========================");
        Console.WriteLine("Ваши действия: \n1.Пошёл на пары \n2.Пошёл домой\n3.Попал в аварию\n4.Пошёл за шавухой");
        Console.Write("> ");
        userChoose = Console.ReadLine();
        Console.WriteLine(userChoose[0]);
        ch = (int)Char.GetNumericValue(userChoose[0]);


        switch (ch) 
        {
            case 1:
                Console.WriteLine("Переход на 20 сцену");
                return 20;                
                break;
            case 2:
                Console.WriteLine("Переход на 10 сцену");
                return 10;
                break;                
            case 3:
                Console.WriteLine("Переход на 0 сцену");
                return 0;
                break;
            case 4:
                Console.WriteLine("Переход на 7 сцену");
                return 7;
                break;
            default:
                Console.WriteLine("Выбор вне диапозона, повторите ввод");
                Scene0(); return 0;
                break;
        }
    }
    static int Scene20()
    {
        string userChoose = "0";
        int ch;
        Console.WriteLine("==========================");
        Console.WriteLine("|| Подошёл к техникуму 2 ||");
        Console.WriteLine("==========================");
        Console.WriteLine("Ваши действия: \n1.Пошёл на пары \n2.Пошёл домой\n3.Попал в аварию\n4.Пошёл за шавухой");
        Console.Write("> ");
        userChoose = Console.ReadLine();
        Console.WriteLine(userChoose[0]);
        ch = (int)Char.GetNumericValue(userChoose[0]);


        switch (ch)
        {
            case 1:
                Console.WriteLine("Переход на 20 сцену");
                return 20;
                break;
            case 2:
                Console.WriteLine("Переход на 10 сцену");
                return 10;
                break;
            case 3:
                Console.WriteLine("Переход на 0 сцену");
                return 0;
                break;
            case 4:
                Console.WriteLine("Переход на 7 сцену");
                return 7;
                break;
            default:
                Console.WriteLine("Выбор вне диапозона, повторите ввод");
                Scene20(); return 0;
                break;
        }
    }
    */
    private static void Main(string[] args)
    {
        Scenes scene0 = new Scenes(0, "fdfdf");
        /*scene0.Name = "Сцена ноль";
        scene0.Number = 1;*/
        scene0.Show();

        FightScenes KillTheBill = new FightScenes();
        KillTheBill.Name = "Bill";
        KillTheBill.Number = 1;
        KillTheBill.Show();

    }
}