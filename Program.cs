using System;

class Program
{
    static void Main(string[] args)
    {
        //Tipos de Datos

        bool b1 = true;
        bool b2 = false;

        byte byte1 = 15;
        byte byte2 = 10;

        char ch1 = 'A';
        char ch2 = 'C';

        int int1 = 1489;
        int int2 = 9531;

        short short1 = 25974;
        short short2 = 15489;

        float fl1 = 0.895642F;
        float fl2 = 0.163561134F;

        double dbl1 = 68.69D;
        double dbl2 = 53.69D;

        long lg1 = 5894865132132316;
        long lg2 = 6546546215316584;

        decimal dcml1 = 2.8984365652315641M;
        decimal dcml2 = 3.6465454486156568M;

        string str1 = "Hello";
        string str2 = "World";
      
      // Operaciones

        byte sumby = (byte)(byte1 + byte2);
        short diff = (short)(short1 - short2);
        int mult = int1 * int2;
        float div = fl1 / fl2;
        double mod =  dbl1 % dbl2;

        bool mayorQue = lg1 > lg2;
        bool menorQue = dcml1 < dcml2;
        bool equalTo = ch1 == ch2;
        bool mayorIgQ = byte2 >= byte1;
        bool diffD = str1 != str2; 
        bool lessEqT = fl2 <= lg2;
        bool equalTo2 = b1 == b2;

    
        // Print results
        Console.WriteLine("Operations");
        Console.WriteLine(byte1 +  "+"  + byte2);
        Console.WriteLine("Sum: " + sumby);
        Console.WriteLine("");
        Console.WriteLine(short1 +  "-"  + short2);
        Console.WriteLine("Difference: " + diff);
        Console.WriteLine("");
        Console.WriteLine(int1 +  "*"  + int2);
        Console.WriteLine("Product: " + mult);
        Console.WriteLine("");
        Console.WriteLine(fl1 +  "/"  + fl2);
        Console.WriteLine("Quotient: " + div);
        Console.WriteLine("");
        Console.WriteLine(dbl1 +  "%"  + dbl2);
        Console.WriteLine("Modulo: " + mod);
        Console.WriteLine("");
        Console.WriteLine(lg1 +  ">"  + lg2);
        Console.WriteLine("Greater than: " + mayorQue);
        Console.WriteLine("");
        Console.WriteLine(dcml1 +  "<"  + dcml2);
        Console.WriteLine("Less than: " + menorQue);
        Console.WriteLine("");
        Console.WriteLine(ch1 + "=" + ch2);
        Console.WriteLine("Equal to: " + equalTo);
        Console.WriteLine("");
        Console.WriteLine(byte2 + ">=" + byte1);
        Console.WriteLine("Greater or Equal to: " + mayorIgQ);
        Console.WriteLine("");
        Console.WriteLine(str1 + "!=" + str2);
        Console.WriteLine("Not Equal to: " + diffD);
        Console.WriteLine("");
        Console.WriteLine(fl2 + "<=" + lg2);
        Console.WriteLine("Less or Equal to: " + lessEqT);
        Console.WriteLine("");
        Console.WriteLine(b1 + "=" + b2);
        Console.WriteLine("Equal to: " + equalTo2);
        Console.WriteLine("");



    }


    
}
