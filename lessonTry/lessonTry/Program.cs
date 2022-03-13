using System;

namespace lessonTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Strings
            //string str;
            //bool strBool;
            //int strInt;
            //string word = "   Hello World!  ";

            // Butun herfleri boyuk edir
            //str = word.ToUpper();

            // Butun herfleri kicik edir
            //str = word.ToLower();

            // Deyerlerin beraber olub olmamasina uyugun olaraq true false qaytarir
            //string word2 = "Hello world!";
            //strBool = word.Equals(word2);

            // evvelde ve sondaki bosluqlari silir
            //str = word.Trim();
            // evveldeki boslugu silir
            //str = word.TrimStart();
            // sondaki boslugu silir
            //str = word.TrimEnd();

            //Göstərilən alt sətir bu sətirdə tapılarsa, o, true, əks halda false qaytarır.
            //string word3 = "Hell";
            //strBool = word.Contains(word3);

            // stringdeki herfleri yeni herfle evez edir
            //str = word.Replace('H', 'W');

            // sətir obyektlərini birləşdirmək üçün istifadə olunur
            //string word4 = "C#";
            //str = string.Concat(word, word4);

            // herfin hansi indexde oldugunu qaytarir
            //strInt = word.IndexOf("e");
            // herfin sondan indexin qaytarir
            //strInt = word.LastIndexOf("l");

            // 1 parametr verende o indexden sonrani silir (index daxil), 2parametr verilerse o indexler arasini silir
            //str = word.Remove(5);
            //str = word.Remove(5, 6);

            // eger string bosdusa(empty) true qaytarir eks halda false
            //strBool = string.IsNullOrEmpty(word);

            //göstərilən sətirin boş olduğunu və ya yalnız boşluq simvollarından ibarət olduğunu yoxlamaq üçün istifadə olunur. True və ya False boolean dəyərini qaytarır
            //strBool = string.IsNullOrWhiteSpace(word);


            //Console.WriteLine(str);
            //Console.WriteLine(strBool);
            //Console.WriteLine(strInt);

            #endregion

            #region Arrays

            int[] arr = { 23, 34, 54, 644, 34, 242 };
            //string result = String.Join(",", arr);
            //Console.WriteLine(result);

            //string word = "Hello C Sharp";
            //string[] word2 = word.Split(' ');
            //foreach (string word3 in word2)
            //{
            //    Console.WriteLine(word3);
            //}

            // Bütün bir ölçülü Massivin elementlərini çeşidləmək üçün istifadə olunur
            //Array.Sort(arr);
            //Bütün birölçülü Massivin elementlərinin ardıcıllığını tərsinə çevirmək üçün istifadə olunur
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,,] arr2 = {
            //    {
            //        {5, 7}, {3, 6}
            //    },
            //    {
            //        {54, 6}, {43, 4}
            //    },
            //    {
            //        {52, 16}, {12, 23}
            //    },
            //};
            // Rank Massivin dərəcəsini (ölçülərin sayını) almaq üçün istifadə olunur. nece olculu olmasini
            //Console.WriteLine(arr2.Rank);
            //Console.WriteLine(arr2[2, 0, 1]); //// output 16

            // RESIZE
            //int[] arr3 = new int[5];
            //arr3[0] = 1;
            //arr3[1] = 2;
            //arr3[2] = 3;
            //arr3[3] = 4;
            //arr3[4] = 5;
            //Array.Resize(ref arr3, 3);
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i]);
            //}

            //Array.Resize(ref arr, 7);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[6] = 344;
            //    Console.WriteLine(arr[i]);
            //}




            #endregion
        }
    }
}
