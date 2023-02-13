using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introdcution();

            //DoubleEquality();

            //TryCatch();

            //VerweisUndWertTyp();

            //StringBuilder();

        }

        private static void StringBuilder()
        {
            var myText = "";
            var sb = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {// es wird immer nue exemplare erzeugt -> Garbage Collecor (Gelb in proccess Diagramm)
                //myText = myText + new string('A', 10000);
                sb.Append(new String('A', 10000));
            }

            Console.ReadLine();
        }

        private static void VerweisUndWertTyp()
        {
            var wert01 = 10;

            var wert02 = wert01;

            Console.WriteLine("wert01: " + wert01 + "; wert02: " + wert02);

            wert01 = 20;

            Console.WriteLine("wert01: " + wert01 + "; wert02: " + wert02);

            var verweisTyp01 = new MyReferenceType();
            verweisTyp01.wert = 10;

            var verwiesTyp02 = verweisTyp01;

            Console.WriteLine($"verweisTyp01.wert: {verweisTyp01.wert}; verwiesTyp02.wert: {verwiesTyp02.wert}");

            verweisTyp01.wert = 20;

            Console.WriteLine($"verweisTyp01.wert: {verweisTyp01.wert}; verwiesTyp02.wert: {verwiesTyp02.wert}");


            var array1 = new int[] { 0 };

            var array2 = array1;

            Console.WriteLine($"array1: {array1[0]}; array2: {array2[0]}");

            array1[0] = 20;

            Console.WriteLine($"array1: {array1[0]}; array2: {array2[0]}");

            var text1 = new string(new char[] { '1', '0' }); // "10"

            var text2 = text1;

            Console.WriteLine($"text1: {text1}; text2: {text2}");

            text1 = "20";

            Console.WriteLine($"text1: {text1}; text2: {text2}");

            var myValueType1 = new MyValueType();
            myValueType1.wert = 10;
            myValueType1.verweisTyp = new MyReferenceType { wert = 10 };

            var myValueType2 = myValueType1;

            Console.WriteLine($"myValueType01.wert: {myValueType1.wert}; myValueType02.wert: {myValueType2.wert}");
            Console.WriteLine($"myValueType01.verweisTyp.wert: {myValueType1.verweisTyp.wert}; myValueType02.verweisTyp.wert: {myValueType2.verweisTyp.wert}");

            myValueType1.wert = 20;
            myValueType2.verweisTyp.wert = 20;

            Console.WriteLine($"myValueType01.wert: {myValueType1.wert}; myValueType02.wert: {myValueType2.wert}");
            Console.WriteLine($"myValueType01.verweisTyp.wert: {myValueType1.verweisTyp.wert}; myValueType02.verweisTyp.wert: {myValueType2.verweisTyp.wert}");

            Console.ReadLine();
        }

        private static void TryCatch()
        {
            string fehler = null;

            //if (fehler == null)
            //{

            //}
            //else
            //{
            //    fehler.ToLower();
            //}


            try
            {
                fehler.ToLower();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            Console.WriteLine(fehler);


            Console.ReadLine();
        }

        private static void DoubleEquality()
        {
            double value1 = 0.1 + 0.1 + 0.1;
            double value2 = 0.3;

            if (value1 == value2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            var tolerance = 0.00001;

            if (Math.Abs((value1 - value2)) < tolerance)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            Console.ReadLine();
        }

        private static void Introdcution()
        {
            //Console.WriteLine("Hello World!");

            byte myByte = 100;

            bool myBool = false;
            int myInt = 10;
            double myDouble = double.MaxValue;
            string myString = "myText";
            char myChar = 'c';

            var myBoll2 = true;
            var myInt2 = 10;
            var myDouble2 = 10.0;

            var nr1 = "10,0";
            var nr2 = nr1.Replace(',', '.');

            if (myBool == true)
            {
                //
            }
            else
            {
                //
            }

            if (myBool != true)
            {

            }
            else if (myInt2 < 11)
            {

            }
            else if (myDouble2 < 12)
            {

            }
            else
            {

            }

            if (myBool != true)
                myBool = false;


            switch (myBool)
            {
                case true:
                    //process...
                    myBool = false;
                    break;

                case false:
                    // processs
                    myBool = true;
                    break;

                default:
                    break;
            }

            var myShape = Shape.Circle;

            switch (myShape)
            {
                case Shape.Quad:
                    break;

                case Shape.Circle:
                    break;

                case Shape.Triangle:
                    break;

                default:
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            var j = 10;
            do
            {
                Console.WriteLine(j);
                // process
                j = j + 1;

            } while (j < 20);


            var k = 20;
            while (k < 30)
            {
                Console.WriteLine(k);
                k++;
            }




            var maxNrIteration = 10000;

            for (int i = 0; i < maxNrIteration; i++)
            {

            }


            var myIntArray = new int[] { 0, 2, 5, 8 };

            var myIntegerList = new List<int>();

            foreach (var myIntegerValue in myIntArray)
            {
                Console.WriteLine(myIntegerValue);

                // nachteil es ghet nicht:
                // myIntegerValue = 10;

                if (myIntegerValue < 5)
                {
                    myIntegerList.Add(myIntegerValue);
                }
            }

            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = 10;
            }

            int nr = 1;

            nr++;
            nr--;
            nr += 5;
            nr *= 2; // = nr = nr * 2
            nr /= 4; // = nr = nr / 3

            Console.ReadLine();
        }
    }

    public enum Shape
    {
        Quad,
        Circle,
        Triangle
    }
}
