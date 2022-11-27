// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

  double[,] arrCreate ()

    {

        int m;
        int n;

        string tmp = string.Empty;

        Console.WriteLine("введите размер массива целым числом по m:");

        tmp =  Console.ReadLine();

        bool check = int.TryParse(tmp, out m);

        if (check == false)
        {
            Console.WriteLine("вы ввели не целое число");
            return null;
        }

        tmp = string.Empty;

        Console.WriteLine("введите размер массива целым числом по m:");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out n);

        if (check == false)
        {
            Console.WriteLine("вы ввели не целое число");
            return null;
        }


        Random rndInt = new Random();

        Random rndDouble = new Random();

        double[,] nums = new double[m,n];


        for (int i = 0; i < nums.GetLength(0) ; i++ )

        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
            nums[i,j] = rndDouble.NextDouble()+rndInt.Next(-100, 100);
            }

        }
        
        return nums;
    }


     void arrPrint ( double[,] nums)
     {

        
        for (int i = 0; i < nums.GetLength(0) ; i++ )

        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
            Console.Write(nums[i,j]+" ");
            }

        Console.WriteLine();

        }

     }


    arrPrint ( arrCreate ());

