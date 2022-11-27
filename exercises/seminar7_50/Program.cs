// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

        int[,] arrCreate ()

            {
                int m;
                int n;

                Random rndInt = new Random();

                m = rndInt.Next(1, 10);
                n = rndInt.Next(1, 10);

                int[,] nums = new int[m,n];

                for (int i = 0; i < nums.GetLength(0) ; i++ )

                {
                    for (int j = 0; j < nums.GetLength(1) ; j++ )
                    {
                    nums[i,j] = rndInt.Next(-100, 100);
                    }
                }
            
                return nums;
            }
            

        int inpInd0;
        int inpInd1;
        int genInd0;
        int genInd1;

        int[,] nums = arrCreate ();

        genInd0 = nums.GetLength(0) - 1;

        genInd1 = nums.GetLength(1) - 1;

        string tmp = string.Empty;

        Console.WriteLine($"введите целым числом большим или равным 0 индекс массива по измерению 0 (последний элемент имеет индекс {genInd0}):");

        tmp =  Console.ReadLine();

        bool check = int.TryParse(tmp, out inpInd0);

        if (check == false || inpInd0 < 0 )
        {
            Console.WriteLine("неверный ввод");
            Environment.Exit(0);
        }

        tmp = string.Empty;

        Console.WriteLine($"введите целым числом большим или равным 0 индекс массива по измерению 1 (последний элемент имеет индекс {genInd1}):");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out inpInd1);

        if (check == false || inpInd1 < 0)
        {
            Console.WriteLine("неверный ввод");
            Environment.Exit(0);
        }

        if(inpInd0 > genInd0 || inpInd1 > genInd1 ) 
        {
            Console.WriteLine($"массив имеет максимальные индексы [{genInd0}] [{genInd1}] , вы ввели индексы несуществующего элемента ");
        }
        else 
        {
            Console.WriteLine($"элемент массива  [{inpInd0}] [{inpInd1}] имеет значение {nums[inpInd0,inpInd1]} ");
        }