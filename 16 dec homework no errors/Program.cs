using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace _16_dec_homework_no_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("yazini daxil edin");
            string text = Console.ReadLine();
            FixSentense(ref text);
            Console.WriteLine(text);
            string str = "salam necesen ";
            FindWordsCount(str);
            Console.WriteLine(str);


        }

        //Verilmiş string dəyərindəki bütün sözlərin arasında bir
            //boşluq qalacaq vəziyyətə salan metod.(Metoda "  Men   rusca    bilmirem" dəyəri göndərilərsə
            //onu "Men rusca bilmirem" halına gətirməlidir.
        static void FixSentense(ref string str)
        {
            str = str.Trim();
            string Newstr = "";
            var arr = str.Split(' ');
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]!="")
                {
                    Newstr += arr[i];
                    if (i < arr.Length - 1)
                        Newstr += ' ';


                    //if (Newstr != "")
                     //   Newstr += " ";

                   // Newstr += arr[i];
                }
            }
            str = Newstr;
        }
        //Verilmiş string dəyərdəki sözlərin sayını tapan metod(boşluqlarla ayrılmış bütün ifadələr)

        static int FindWordsCount(string str)
        {
            FixSentense(ref str);
            return str.Split(' ').Length;
        }


        //Parameter olaraq integer array variable-ı(reference) və bir integer
        //value qəbul edən və həmin integer value-nu integer array-ə yəni
        //element kimi əlavə edən metod.
        static void Add(ref int[] arr,int value)
        {
            int[] newArr = new int[arr.Length + 1];

                for(int i=0;i<arr.Length;i++)
                {
                  newArr[i] = arr[i];
                }
            newArr[newArr.Length - 1] = value;
            arr = newArr;

        }
        // Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod
        // .Fullname arrayinin icindeki butun value-lar ad+" "+soyad formatindadir.Misalcun "Hikmet Abbasov".
        // Misalcun gelen arraydeki deyerler { "Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"}
       // olarsa return olunan arraydeki deyerler {"Hikmet","Abdulla","Cemile"}
       //olmalidir
       static string[] MakeFirstnamesArr(string[] fullname)
        {
            string[] arr = new string[fullname.Length];
            for(int i=0;i<fullname.Length;i++)
            {
                arr[i] = fullname[i].Split(' ')[0];
            }
            return arr;

        }
        //- Verilmiş string dəyərin bir fullname olub
        //olmadığını yoxlayan metod.(Dəyərin fullname olma şərti daxilində yalnız hərflərin
        //ola bilməsi, yalnız 2 sözdən ibarət olması və hər bir sözün böyük
        //hərfə başlayıb kiçik hərflərlə davam etməsidir.
        static bool Iscapitalized(string str)
        {
            if (!char.IsUpper(str[0])) ;
            return false;
            for(int i=0; i<str.Length;i++)
            {
                if (!char.IsLower(str[i])) ;
                return false;
            }
            return true;
        }
        static bool Isfullname(string str)
        {
            var words = str.Split(' ');
            if (words.Length != 2) ;
            return false;
            if (!Iscapitalized(words[0] )|| !Iscapitalized(words[1]));
            return false;
            return true;
        }

    }
}

