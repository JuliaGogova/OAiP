using System;
class Zadacha
{
    static void Main()
    {
        int[] Dveri = new int[101] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
             21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39,40, 41, 42,
             43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58,59, 60, 61, 62, 63, 64,
             65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86,
             87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101}; //Создается массив дверей 


        for (int a = 0; a <= 100; a++) //Массив заполняется числами
            Dveri[a] = 0; //Все двери закрыты = 0
        

        for (int b = 1; b <= 100; b++) //Добавляются "люди" которые будут открывать двери
        {


            for (int c = b; c <= 100; c += b) //Перебор самих дверей
            {
                if (Dveri[c] == 0)
                {
                    Dveri[c] = 1;
                }
                else
                {
                    Dveri[c] = 0;
                }
            }
        }


        for (int F = 0; F <= 100; F++) //Вывод открытых дверей
        {
            if (Dveri[F] == 1)
            {
                Console.WriteLine(F + " -ая дверь открыта");
            }
        }
    }
}