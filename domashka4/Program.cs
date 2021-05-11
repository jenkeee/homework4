﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace domashka4
{
    #region задание 1
    class Mymassiv
    {
        int[] a; // создадим переменную для масива.


        //  Создание массива и заполнение его случайными числами от min до max
        public Mymassiv(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        // узнаем максимальное число в масиве
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        //узнаем минимальное число в масиве 
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        // выведем 10 пар масива
        public int My_pare // пары свойством
        {
            get {
                int count = 0;
                for (int i = 0; i < 19; i = i+2)
                {
                    if (i >= 20) break;
                    if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
                    { count++;
                        
                        Console.WriteLine("                             ||  Эта пара удовлетворяет условие");
                            }// 
                    Console.WriteLine($"Пара № {(i/2)+1}) {a[i]} {a[i + 1]}");
                    Console.WriteLine($"___________________________________________________________________________");
                }
                Console.WriteLine("Количество пар: " + count);
                return 0;
            }
        }


        //    var b = 0;
        //    int pare = a[0];
        //    // пишу i < 18; потому что буду писать пару чисел, если спросить индекс которого нет, получим краш
        //    for (int i = 0; i < 18; i = i++)
        //    {if (i >= 20) break;
        //        int pare_num = i + 1;
        //        int sec_pare = pare_num + 1;
        //        //Console.WriteLine($"Пара № {pare_num}) {a[i]} {a[i + 1]}"); // пробовал эту запись, оно не работает // бесконечность не предел
        //        Console.WriteLine("Пара чисел: {0} и {1}", a[i], a[i + 1]);
        //    }
           

        //}


        //public int Divisibility3() // это подглядел не понравилось
        //{
        //    int count = 0;
        //    for (int i = 0; i < 18; i++)
        //    {
        //        if (i >= 20) break;
        //        if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
        //            count++;
        //        Console.WriteLine("Пара чисел: {0} и {1}", a[i], a[i + 1]);
        //    }
        //    Console.WriteLine("Количество пар: " + count);
        //    return count;
        //}


        // метод который выводит числа в масиве в виде строки
        public override string ToString()
        {
            string s = "";
            foreach (int v in a) // пишит каждый индекс масива в строку последовательно + в конце добавляем пробел +""
                s = s + v + " ";
            return s;
        }

        private int[] arr;


        public Mymassiv(int[] arr)
        {
            this.arr = arr;
        }

        /// <summary>
        /// Возвращаем значение элемента массива по индексу
        /// </summary>
        /// <param name="index">Индекс элемента массива</param>
        /// <returns>Значение</returns>
        public int GetValue(int index)
        {
            return arr[index];
        }

        public int GetLength()
        {
            return this.arr.Length;
        }


    }
    #endregion

    class Program
    {
        #region menu
        static int GetValue(string message) // метод который проверит ты ввел инт32 или нет в переменную num_after
        {
            string num_before;
            bool flag_parse;
            int num_after; // нам потребуется спросить номер кейса задачи и у нас есть функционал проверки на то чтобы значение было int 32 и соответсвовало кейсам далее
            do
            {
                Console.WriteLine("int.TryParse(num_before, out num_after);");
                Console.Clear();
                Console.WriteLine("Введите номер задачи от 1 до 5. принимаются только целые числа."); // спецально так записал, варианты вывода проверял
                num_before = Console.ReadLine(); // запишем num_before
                                                 //  Если перевод произошел неправильно, то результатом будет false
                flag_parse = int.TryParse(num_before, out num_after); // если метод .tryparse сможет сделать int из строки s то он сделает out в num_after тоесть передаст значение num_before в num_after и
                                                                      // сообшит переменной flag true,
                                                                      //  если не получится int32 то сообшит во flag false 
            }
            while (!flag_parse);  //  Пока переворачивает булевое значение flag_parse
            return num_after; // если вечный цикл закончится, метод вернет num_after
        }
        static void Main(string[] args)
        {
            string first_name = "DART";
            string last_name = "VAIDER";
            bool flag_switch = true; //ненужный флаг в моем случае 
            int value; // описываем переменную велью как инт
            do
            {
                Console.Title = ("Меню");
                Console.Clear();
                Console.WriteLine("Введите номер задачи 1-3.");
                value = GetValue(""); // даем значение велью методом GetValue // и там метод уже либо пропустит int32 либо будет бесконечно вызыватся, пока ты не напишиш цифры удовлетворяющие условия
                // гет валью дает нам проверку на вводимы знаки, а диапазон мы сдесь даже не ставили У НАС ВСЕГО 3 КЕЙСА


                switch (value)
                {
                    case 1:
                        dz1();
                        break;
                    case 2:
                        dz2();
                        break;
                    case 3:
                        dz3();
                        break;
                        /* default:      // тут она не нужна дефаулт, но оставил для примера // выше проверка убивает смысл дкефаулта
                             flag_switch = !flag_switch; // думаю как сделать проверку на X при чем тут не равно b  // как я понял                     
                             Console.Write("у меня есть только 3 задачи, не хочу играть, не по правилас, вводи 1-3");
                             break;*/


                }
            } while (true);  // только если выполним кейс пройдем дальше, получим true, но тут и так лежит тру
        }

        #endregion
        #region 1.	Дан  целочисленный  массив  
        /// <summary>
        ///1.	Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
        ///Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
        ///В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
        /// </summary>
        static void dz1()
        {

            int[] array03 = { 7, 9, 10, 1, 3, 5 }; // просто так создал масив
            bool flag_m;
            Mymassiv masiv_a = new Mymassiv(20, -10_000, 10_000); // инициализируем масив в переменную masiv_a описанную в классе Mymassiv           
            Console.WriteLine(masiv_a.ToString());
            Console.WriteLine($"Сверху ты видишь 20 чисел в диапазоне от -10000 до 10000, числа рандомные и описанны в классе Mymassiv Random rnd = new Random();");
            Console.WriteLine();
            Console.WriteLine(masiv_a.Max);
            Console.WriteLine($"Максимальное число ");
            Console.WriteLine();
            Console.WriteLine(masiv_a.Min);
            Console.WriteLine($"Минимальное число");
                       Console.WriteLine();
            Console.WriteLine($"У нас получается 10 пар чисел, сейчас я выведу их на экран");
            Console.WriteLine();
            Console.WriteLine(masiv_a.My_pare);

            // masiv_a.Divisibility3(); // не понравилось 
            ///////////////////////////////////////////////////////////////////////////////////// Просто поиграюсь с определенным мной масивом /////////////////////////////////

            Console.WriteLine();
            /// создаю переменную i(только внутри цикла) / i = 0 и если i меньше длины масива при выполнение цикла мы увеличим i на +1
            for (int i = 0; i < array03.Length; i++)  // i = 0 и равно индексу первого элемента масива
            {
                Console.WriteLine($"{array03[i]}");// последовательно пишем  Console.WriteLine($"{array03[0]} / элемент масива с индексом 0 и после того как сделаем цикл увеличим i на +1 / очень удобно язык сделан
            }

            Console.WriteLine();
            Console.ReadKey();

            for (int i = 0; i < array03.Length; i++) // повторим условие цикла выше 
            {
                array03[i] = array03[i] * array03[i]; // тут мы перемножим число на само себя и перепишем значение соответсвенно его индексу
            }

            for (int i = 0; i < array03.Length; i++)  // напишем в строку новое значение индексов масива array03
            {
                Console.Write($"{array03[i]}  "); // writeline поменяли на write чтобы вывести масив в строку
            }
            //flag_m = int.TryParse(masiv_a.(), out drob1.up_str);
            /////////////////////////////////////////////////////////////////////////////////////// вроде разобрал манипаляции с индексами, вернусь к дз/////////////////////////////////////////////////////////////////
            Console.ReadLine();
        }

        #endregion
        #region задание 2
        /// <summary>
        /// 2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
        /// </summary>
        static void dz2()
        {
            //Mymassiv a = new Mymassiv(10, 0, 100);
        }

        #endregion
        #region задание 2
        /// <summary>
        /// 2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
        /// </summary>
        static void dz3()
        {
            Console.Title = ("2. Рассчитать и вывести индекс массы тела(ИМТ).");
            double weight, high;
            Console.Write("Введите ваш вес в кг: ");
            weight = Convert.ToDouble(Console.ReadLine());
            weight += Math.Round(weight, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine($"я округлил переменную weight = {weight} до toEven, эксперементирую дальше");
            //if (weight != double)
            { }
            Console.Write("Введите ваш рост в см: ");
            high = Convert.ToInt32(Console.ReadLine());
            double I = weight / (Math.Pow(high / 100, 2));// weight / (high/100 * high/100);  // (Math.Pow(x / y, 2)) - возводит в степень 2 // Math.Sqrt извлекает квадрат
            Console.WriteLine("I = {0:f4}", I);
        }

        #endregion






    }
}

