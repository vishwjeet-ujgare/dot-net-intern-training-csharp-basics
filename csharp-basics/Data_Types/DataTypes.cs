using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.Data_Types
{
    class DataTypes
    {


        public void PointersDT() {
            
                //int number = 10;

                //int* ptr = &number;
                //Console.WriteLine($"Value :{number}");
                //Console.WriteLine($"Address :{(int)ptr}");
                //Console.ReadKey();
            
            
        }

        public void DefaultValuesOfBuildInDT() {
            Console.WriteLine($"Default Value of Byte: {default(byte)} ");
            Console.WriteLine($"Default Value of Integer: {default(int)}");
            Console.WriteLine($"Default Value of Float: {default(float)}");
            Console.WriteLine($"Default Value of Long: {default(long)}");
            Console.WriteLine($"Default Value of Double: {default(double)}");
            Console.WriteLine($"Default Value of Character: {default(char)}");
            Console.WriteLine($"Default Value of Boolean: {default(bool)}");
        }
        public void SizeOfPredefinedST() {
            Console.WriteLine($"Size of Bool: {sizeof(bool)}");
            Console.WriteLine($"Size of Byte: {sizeof(byte)}");
            Console.WriteLine($"Size of Character: {sizeof(char)}");
            Console.WriteLine($"Size of Integer: {sizeof(int)}");
            Console.WriteLine($"Size of Float: {sizeof(float)}");
            Console.WriteLine($"Size of Long: {sizeof(long)}");
            Console.WriteLine($"Size of Double: {sizeof(double)}");
         
            Console.ReadKey();
        }

        public void DataTypePerformance() {


            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            for (int i = 0; i <= 10000000; i++)
            {
                short s1 = 100;
                short s2 = 100;
                short s3 = 100;
            }
            stopwatch1.Stop();
            Console.WriteLine($"short took : {stopwatch1.ElapsedMilliseconds} MS");


            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            for (int i = 0; i <= 10000000; i++)
            {
                decimal s1 = 100;
                decimal s2 = 100;
                decimal s3 = 100;
            }
            stopwatch2.Stop();
            Console.WriteLine($"decimal took : {stopwatch2.ElapsedMilliseconds} MS");
        }

        public void NumericDTWithDecimal() {
            Single num1 = 4343.3f;
            Double num2 = 43434.43;
            Decimal num3 = 4343434.34343434m;

            float num4 = 8988.2f;
            double num5 = 43434.43;
            decimal num6 = 4343434.34343434m;


            Console.WriteLine($"single size {sizeof(Single)} Byte");
            Console.WriteLine($"Single Min size : {Single.MinValue} and Max size : {Single.MaxValue}");

            Console.WriteLine($"Double size {sizeof(Double)} Byte");
            Console.WriteLine($"Double Min size : {Double.MinValue} and Max size : {Double.MaxValue}");

            Console.WriteLine($"Decimal size {sizeof(Decimal)} Byte");
            Console.WriteLine($"Decimal Min size : {Decimal.MinValue} and Max size : {Decimal.MaxValue}");


            Console.WriteLine($"float size {sizeof(float)} Byte");
            Console.WriteLine($"float Min size : {float.MinValue} and Max size : {float.MaxValue}");


            Console.WriteLine("\n\n===============Understand Accuracy:===================\n");
            float a = 1.78986380830029492956829698978655434342477f; //7 digits Maximum
            double b = 1.78986380830029492956829698978655434342477; //15 digits Maximum
            decimal c = 1.78986380830029492956829698978655434342477m; //29 digits 

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);





        }
        public void NumericDTWithoutDecimal()
        {
            //Int16 num1 = 123;
            short num1 = 123;
            //Int32 num2 = 456;
            int num2 = 456;
            // Int64 num3 = 789;
            long num3 = 789;

            Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
            Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");

            Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value:{Int32.MaxValue}");
            Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");

            Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value:{Int64.MaxValue}");
            Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");


            Console.WriteLine("\n================UnSigned===============================");
            UInt16 pnum1 = 123;
            UInt32 pnum2 = 5000;
            UInt64 pnum3 = 24343;

            //short num1 = 123;
            //int num2 = 456;
            //long num3 = 789;

            Console.WriteLine($"UInt16 or short Min value : {UInt16.MinValue} and Max value:{UInt16.MaxValue}");
            Console.WriteLine($"UInt16 size :{sizeof(UInt16)} Byte");

            Console.WriteLine($"UInt32 or int Min value : {UInt32.MinValue} and Max value:{UInt32.MaxValue}");
            Console.WriteLine($"UInt32 size :{sizeof(UInt32)} Byte");

            Console.WriteLine($"ulong Min Value:{ulong.MinValue} and Max Value:{ulong.MaxValue}");
            Console.WriteLine($"ulong Size:{sizeof(ulong)} Byte");
        }
        public void StringDTDemo() {
            string firstName = "Vishwjeet";
            Console.WriteLine($"Value of firtNmae : {firstName}");

            var howManyBytes = firstName.Length * sizeof(Char);
            Console.WriteLine($"firstname Size: {howManyBytes}");
        }


        public void CharDTDemo() {

            //End of Unicode Range – \uFFFF is not assigned to any real character;
            //it is used to indicate invalid or unassigned Unicode code points.

            char ch = 'V';
            char ch2 = '₹';
            char ch3 = '☼';


            Console.OutputEncoding = Encoding.UTF8;//if removed ''₹'' will not print on console

            Console.WriteLine($"Value of ch : {ch}");
            Console.WriteLine($"Value of ch2 : {ch2}");
            Console.WriteLine($"Value of ch3 : {ch3}\n");

            Console.WriteLine($"Equivalent Number for {ch}: {(byte)ch}");
            Console.WriteLine($"Equivalent Number for {ch2}: {(byte)ch2}");
            Console.WriteLine($"Equivalent Number for {ch3}: {(int)ch3}\n");//here  declare int else we will lose data

            Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
            Console.WriteLine($"Char Size: {sizeof(char)} Byte");


        }
        
        public void ByteDTDemo(){
       
            byte b1 = 66;// Range is 0 to 255

            sbyte sb1 = -120;//Range is signed -127 to 228
            sbyte sb2 =  100;//Range is signed -127 to 228

            //You cannot store negative number using byte data type.
            //The following statement will give compile time error
            //byte b2 = -100;


            //The following Statement will give compile time error
            //The maximum value you can store in a byte variable is 255
            //byte b3 = 256;
            Console.WriteLine("======================Byte Unsigened Integer=====================");
            Console.WriteLine($"Value of b1 : {b1}");
            Console.WriteLine($"ASCII equivalent character of {b1} is {(char)b1}");
            Console.WriteLine($"Byte Min value : {byte.MinValue} and Max value is : {byte.MaxValue}");
            Console.WriteLine($"Size of byte : {sizeof(byte)} Bytes");
            
            Console.WriteLine("\n====================Byte signed Integer========================");
            Console.WriteLine($"Value of sb : {sb1}");
            Console.WriteLine($"ASCII equivalent character of {sb1} is {(char)sb1}");
            Console.WriteLine($"ASCII equivalent character of {sb2} is {(char)sb2}");
            Console.WriteLine($"Signed Byte Min value : {sbyte.MinValue} and Max value is : {sbyte.MaxValue} ");
            Console.WriteLine($"Size of signed byte : {sizeof(sbyte)} Bytes");


        }


    }
}
