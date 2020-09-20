using System;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace Project1
{
    class Class1
    {
        private static (int max_1, int min_1, int sum_1, char ch_1) Get_String_and_array(int[] array_func,string str,int size_array)
        {
            int max = array_func[0], min = array_func[0], sum = 0;
            for (int t = 0; t < size_array; t++) {
                if (min > array_func[t])
                    min = array_func[t];
                if (max < array_func[t])
                    max = array_func[t];

                sum += array_func[t];
                Console.WriteLine("i " + t);
                Console.WriteLine("sum " + sum);
                Console.WriteLine("min " + min);
                Console.WriteLine("max " + max);

            }
            var result = (max, min, sum, str[0]);
            return result;
        }

        static void Main(string[] args)
        {
            //1 задание
            //a)
            int a1 = 1;
            Console.WriteLine("int " + a1);

            string str = "b";
            Console.WriteLine("string " + str);

            char chr = 'a';
            Console.WriteLine("char " + chr);

            char b = Convert.ToChar(str);
            Console.WriteLine("char " + b);

            short c = 12;
            Console.WriteLine("short " + c);

            bool bol = false;
            Console.WriteLine("bool " + bol);

            byte byter = 102;
            Console.WriteLine("short " + byter);

            sbyte sbyter = 112;
            Console.WriteLine("sbyte " + sbyter);

            double doble = 12.2;
            Console.WriteLine("double " + doble);

            float flt = 30.6f;
            Console.WriteLine("float " + flt);

            uint ui = 12;
            Console.WriteLine("uint " + ui);

            long lg = 22;
            Console.WriteLine("long " + lg);

            ulong ulg = 36;
            Console.WriteLine("ulong " + ulg);

            decimal dcl = 36;
            Console.WriteLine("decimal " + dcl);

            //b)
            int x = 100;
            byte y = (byte)x;   //явное преобразование
            double dbl = (double)x;
            short shrt = (short)x;
            float folt = (float)x;
            sbyte sbyter_2 = (sbyte)x;

            int z = y;          //неявное преобразование
            double dbl1 = x;
            float folt1 = x;
            decimal ulg1 = x;
            long sbyter_2_1 = x;

            Console.Write("enter value: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a value for the second number: ");
            int a2_ = Convert.ToInt32(Console.ReadLine());
            //или другой вариант команды выше
            //int kod = Console.Read();
            Console.WriteLine("a2_: " + a2_);
            Console.WriteLine("a2: " + a2);

            //c)
            int a3 = 123;
            object o = a3;
            int j = (int)o;
            
            //d)
            var a4 = 12;
            a4 = +a1;
            
            //e)
            int? a5 = null;
            if (a5.HasValue)
            {
                Console.WriteLine("a5 nullable " + a5);
            }
            else
            {
                Console.WriteLine("a5 isequal to null");
            }
            //f)
            //var str1 = "astr";
            //int b1 = str1;

            //2) задание
            //a)
            string str3 = "helloy world", str4 = "in future i will be in ....", str5 = "Do you have money", str6;
            bool bol1 = ReferenceEquals(str3, str4);
            Console.WriteLine(bol1);

            //b) строки взяты из пункта а) 2 задания -
            str6 = str3 + str4 + str5;
            Console.WriteLine("Сцепление строк: " + str6);
            str6 = String.Copy(str3);
            Console.WriteLine("Копирование строк: " + str6);
            string text = "Path in my derictory on my computer";
            string[] words = text.Split(new char[] { ' ' });
            foreach(string s_ in words)
            {
                Console.WriteLine("word: " + s_);
            }
            const string substring_1= "String ";
            const string substring_1_ = "String for exrcise";
            substring_1.Replace(substring_1_, "Чебурек");
            string s_1 = "string new eeoeoeoeoo";
            string s_1_new = "nsting";
            string s_2 = s_1.Insert(5, s_1_new);
            Console.WriteLine("string: " + s_2);
            string for_example = "Helloy world";
            for_example = for_example.Trim(new char[] { 'd', 'y', 'w' });
            Console.WriteLine("string delete(Method Trim): " + s_2);
            string str_new = "Just text in variable";
            str_new = str_new.Substring(2);
            Console.WriteLine("string delete(Method Substring): " + str_new);
            str_new = str_new.Remove(2, 4);
            Console.WriteLine("string delete(Method Remove): " + str_new);



            //Console.WriteLine("Введите позицию(до 12): ");
            //int string_position = Convert.ToInt32(Console.ReadLine());
            //str6 = str3.Insert(string_position, str4);
            //Console.WriteLine("вставка построки в строку: " + str6);
            //string[] words = str5.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("Введите диапазон для вырезания подтекста из текста. Введите позицию первое число должно быть меньше второго(до 12): ");
            //int string_position_1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите диапазон для вырезания подтекста из текста. Введите позицию для второго числа(до 12): ");
            //int string_position_2 = Convert.ToInt32(Console.ReadLine());
            //if (string_position_2 < string_position_1)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    str6 = str3.Remove(string_position_1, string_position_2);
            //    Console.WriteLine("удаление заданной подстроки: " + str6);
            //}

            //с)
            string tempTxt_1 = "";
            string tempTxt_2 = null;
            bool boolstring = String.IsNullOrEmpty(tempTxt_1);
            Console.WriteLine("IsNullOrEmpty(tempTxt_1) " + boolstring);
            Console.WriteLine("Plus: " + (tempTxt_1 + tempTxt_2));
            Console.WriteLine("Equals: " + (tempTxt_1.Equals(tempTxt_2)));
            Console.WriteLine("CompareTo: " + tempTxt_1.CompareTo(tempTxt_2));
            Console.WriteLine("String.Concat: " + String.Concat(tempTxt_2, tempTxt_1));
            Console.WriteLine("Interpolation: " + $"{tempTxt_2}{tempTxt_1}");

            //d)
            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine($"StringBuilder строкa: {sb}");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            sb.Remove(1,5);
            Console.WriteLine($"StringBuilder строкa с удаленными элементами: {sb}");
            sb.Insert(1, "OOP");
            Console.WriteLine($"StringBuilder строкa с удаленными элементами: {sb}");
            sb.Append("!");

            

            //3)
            //a)
            // Объявляем двумерный массив
            Console.Write("Введите число строк: ");
            int a2_String = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число столбцов: ");
            int a2_Сolumn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите любое число: ");
            int a2_value = Convert.ToInt32(Console.ReadLine());


            int[,] myArr = new int[a2_String, 5];
            Random ran = new Random();
            // Инициализируем данный массив
            for (int i = 0; i < a2_String; i++)
            {
                Console.Write("[");
                for (j = 0; j < a2_Сolumn; j++)
                {
                    myArr[i, j] = ran.Next(0, a2_value);
                    Console.Write(" [{0}] ", myArr[i, j]);
                }
                Console.WriteLine("]");
            }
            //b)--
            int l;
            string[] weekDays = new string[] { "Sund", "Mon", "Tues", "Wed", "Thut", "Frid", "Sat" }; 
            for (int i = 0; i < 7; i++) {
                l = weekDays[i].Length;
                Console.WriteLine("Size " + i + " string = " + l + ".");
                Console.Write(" String " + i + " = " + weekDays[i] + "\n");
            }
            Console.WriteLine("Size array = " + weekDays.Length);
            Console.WriteLine("Enter number string: ");
            int a2_position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter string: ");
            str6 = Console.ReadLine();
            weekDays[a2_position] = str6;
            Console.WriteLine("string " + a2_position + " = " + weekDays[a2_position]);

            // Объявляем ступенчатый массив
            int[][] myArr1 = new int[3][] { new int[2], new int[3], new int[4] };
            for (int i = 0; i < myArr1.Length; i++)
            {
                for (j = 0; j < myArr1[i].Length; j++)
                {
                    Console.Write($"myArr[{i}][{j}] = ");
                    myArr1[i][j] = int.Parse(Console.ReadLine());
                }
            }
            
            //d)
            var arr_str = new object[0];
            var string_  = "";
            
            //4)задание
            //a)
            (int, string, char, string, ulong) type_ = (5, "string", 'b', "new string", 12 );
            (int, string, char, string, ulong) type_1 = (6, "b string", 'c', "new string", 12);

            Console.WriteLine("int, string, char, string, ulong:");
            Console.WriteLine(type_.Item1+ ", " + type_.Item2 + ", " + type_.Item3 + ", " + type_.Item4 + ", " + type_.Item5);
            Console.WriteLine("Element 1:"+type_.Item1 + ", Element 2:" + type_.Item3 + ", Element 3: " + type_.Item4);

            //c)
            int x_ = type_.Item1;
            string s = type_.Item2;
            string _ = type_.Item2;
            Console.WriteLine("work variable _:" + _);


            //d)
            Console.WriteLine("The result of comparing two tuples: " + ((IComparable)type_).CompareTo(type_1));

            //5)
            Console.WriteLine("Enter new string for array: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter size array: ");
            int size_array = int.Parse(Console.ReadLine());
            int[] array_func = new int [size_array];
            ran = new Random();
            Console.WriteLine("Array: ");
            for (int i = 0; i < size_array; i++)
            {
                array_func[i] = ran.Next(-size_array, size_array);
                Console.WriteLine("arr[" + i + "] = " + array_func[i]);

            }
            var data = (array_func, str, size_array);
            var result = Get_String_and_array(array_func, str, size_array);
            Console.WriteLine("Max value: "+ result.Item1 +" " + result.Item2 + " " + result.Item3 + " " + result.Item4 + " ");
            int ten = 10;
            int i2 = 2147483647 + ten;
            Console.WriteLine(checked(i2));
            //6)
            GMVI32C();
            GMVI32U();
            // Checked block.
            checked
            {
                int i3 = 2147483647 + ten;
                Console.WriteLine(i3);
            }
            //end
            Console.ReadKey();
        }
        static void GMVI32C()
        {
            checked
            {
                int MaxValue = Int32.MaxValue;
                Console.WriteLine("Int32.MaxValue (Checked)= " + MaxValue);
            }
        }
        static void GMVI32U()
        {
            unchecked
            {
                int i3 = Int32.MaxValue + 10;
                Console.WriteLine("Int32.MaxValue (Unchecked)= " +i3);
            }
        }
    }
}