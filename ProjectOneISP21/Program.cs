using System.Security.Cryptography.X509Certificates;

internal class Program
{

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
        /*
        if ( ch <= 4)
        {
            return (int)Char.GetNumericValue(userChoose[0]);
        }
        else { Scene0(); return 0; }*/

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
        /*
        if ( ch <= 4)
        {
            return (int)Char.GetNumericValue(userChoose[0]);
        }
        else { Scene0(); return 0; }*/

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
    private static void Main(string[] args)
    {
        int choose = 0;
                //сцена 1.
        /*
        Console.WriteLine("==========================");
        Console.WriteLine("|| Подошёл к техникуму  ||");
        Console.WriteLine("==========================");
        Console.WriteLine("Ваши действия: \n1.Пошёл на пары \n2.Пошёл домой\n3.Попал в аварию\n4.Пошёл за шавухой");
        Console.Write(">");
        userChoose = Console.ReadLine();
        Console.WriteLine(userChoose[0]);
        int intVal = (int)Char.GetNumericValue(userChoose[0]);
        */
        /*
        if (intVal == 1) { Console.WriteLine("Вы выбрали 1"); }
        if (intVal == 2) { Console.WriteLine("Вы выбрали 2"); }
        if (intVal == 3) { Console.WriteLine("Вы выбрали 3"); }
        if (intVal == 4) { Console.WriteLine("Вы выбрали 4"); }
        if (intVal == 0) { Console.WriteLine("Вы ничего не выбрали, повторите выбор"); }
        */
        
        while (choose != 777) {
        switch (choose)
        {
                case 0:
                    choose = Scene0();
                    break;

                case 20:
                choose = Scene20();
                break;
         case 42:
           // choose = Scene42();
            break;
            default:
            break;
        }
        }
        /*
        switch (Scene0()) {
            case 1:
                Console.WriteLine("Вы выбрали 1");
                Console.WriteLine("Пришли на пару");
                break;
            case 2:
                Console.WriteLine("Вы выбрали 2");
                Console.WriteLine("Пришли на пару");
                break;
            case 3:
                Console.WriteLine("Вы выбрали 3");
                Console.WriteLine("Пришли на пару");
                break;
            default:
                Console.WriteLine("Такого значения нет, повторите ввод");
                SceneIntro(choose);
                break;
        }
        */



    }
}