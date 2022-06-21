using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama ve İşlemli Atama******");
           // Atama ve İşlemli Atama
            int x=3;
            int y=3;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/= 1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            Console.WriteLine("*****Mantıksal Operatörler******");
            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess= true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
            Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
            Console.WriteLine("Fine!");

            Console.WriteLine("*****İlişkisel Operatörler******");
            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a= 3;
            int b= 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc =a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);    
            sonuc = a>=b;      
            Console.WriteLine(sonuc);
            sonuc = a==b; 
            Console.WriteLine(sonuc); 
            sonuc = a!=b;
            Console.WriteLine(sonuc); 

            Console.WriteLine("*****Aritmatik Operatörler******");
            //Aritmatik Operatörler
            // *,/,+,-

            int sayi1=10;
            int sayi2=5;

            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            int sonuc2=sayi1*sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3=sayi1+sayi2;
            Console.WriteLine(sonuc3);
            int sonuc4=sayi1-sayi2;
            Console.WriteLine(sonuc4);
            sonuc1=sayi1++;
            Console.WriteLine(sayi1);

            //% : mod alır

            int sonuc5= 20%3;
            Console.WriteLine(sonuc5);


        }


    }
}
