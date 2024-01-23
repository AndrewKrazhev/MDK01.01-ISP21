internal class Program
{
    private static void Main(string[] args)
    {
        //переменная для хранения выбора пользователя.
        string userChoose = "0";
        int chooseOne;
        //сцена 1.
        Console.WriteLine("==========================");
        Console.WriteLine("|| Подошёл к техникуму  ||");
        Console.WriteLine("==========================");
        Console.WriteLine("Ваши действия: \n1.Пошёл на пары \n2.Пошёл домой\n3.Попал в аварию\n4.Пошёл за шавухой");
        Console.Write(">");
        userChoose = Console.ReadLine();
        Console.WriteLine(userChoose[0]);
        int intVal = (int)Char.GetNumericValue(userChoose[0]);
        /*
        if (intVal == 1) { Console.WriteLine("Вы выбрали 1"); }
        if (intVal == 2) { Console.WriteLine("Вы выбрали 2"); }
        if (intVal == 3) { Console.WriteLine("Вы выбрали 3"); }
        if (intVal == 4) { Console.WriteLine("Вы выбрали 4"); }
        if (intVal == 0) { Console.WriteLine("Вы ничего не выбрали, повторите выбор"); }
        */
        switch (intVal) {
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
                Console.WriteLine();
                break;
        }

    }
}