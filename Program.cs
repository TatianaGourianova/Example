using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_laba
{

    class Polyhedron
    {
        public const int maxSize = 450;

        
        public static int count=0;
        readonly int testRead;
        const int testConst=5;
        private int size;
        private float square;
        private string name;


        



        public int Size
        {
            get { return size; }
       
            set
            {
                if (value < 1)
                    size = 2;
               
                else
                    size = value;
                    //name = value;
            }
           
        }
        public float Square
        {
            get { return square; }

             set
            {
                if (value < 1)
                    square = 1;
                else
                    square = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value== "")
                    name = "no name figure";
                else
                    name = value;
            }
        }

        public Polyhedron() {
            name = "some figure";
            size= 15;
            square=30;
            count++;
            testRead = 15;
            Print();
            }
       
        public Polyhedron(string name, int size,int square)
        {
           this.name = name;
           this.size = size;
           this.square = square;
            count++;
            Print();
        }
        static Polyhedron()
        {
            Console.WriteLine("static constructor was called");
        }
        public void Print()
        {
            Console.WriteLine("size:" + size);
            Console.WriteLine("square:" + square);
            Console.WriteLine("name:" + name);
        }
    }

    public static class Math
    {
       
        public static double perimetr(int FirstArg, int SecondArg)
        {

            return FirstArg * SecondArg;
        }

        public static double squareOfPolyhedron(  double radius, int  halfPerimetr, int side, int countOfLines,double height,out double res)
        {

             res= radius*halfPerimetr*side*countOfLines*height/2;
            Console.WriteLine("square is:"+ res);
            return res;
           
        }

      public  static void GetData(ref int x,ref int y, out int area, out int perim)
        {
            area = x * y;
            perim = (x + y) * 2;
        }


    public static void canWhePutInBox(ref double sqareOfBox,ref double line,ref int countOfLines ,ref float hight,out double res)
        {
            for(int i = 0; i <= countOfLines; i++)
            {
               line= line + line;
            }
            res = line * hight;
            if (res > sqareOfBox)
            {
                Console.WriteLine("sqare of figure more then size of box");
            }
            else
            {
                Console.WriteLine("yes Whe can put figure in box");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Polyhedron rect = new Polyhedron();
            Console.WriteLine();
            Polyhedron figur = new Polyhedron();
            Polyhedron triangle = new Polyhedron("triangle", 25, 132);
       
            Console.WriteLine("count of figures:" + Polyhedron.count);
            Console.WriteLine();
            Polyhedron sz = new Polyhedron();
            sz.Size = 0;
            Polyhedron stat = new Polyhedron();
            /* Figure rectangle = new Figure();
             rectangle.Print();
             Figure.count++;*/

            var data = Polyhedron.count;
            var example = new Polyhedron();
            double res;
            Math.squareOfPolyhedron(3, 5, 12,2,1,out res);
            Console.WriteLine("squareOfPolyhedron is:" + res);
            Console.WriteLine("=================================================");
            int area;
            int perimetr;
            int fir=4;
            int sec= 5;
           Math.GetData(ref fir,ref sec, out area, out perimetr);
            Console.WriteLine("square : " + area);
            Console.WriteLine("hash code:" + area.GetHashCode());
            Console.WriteLine("perimetr : " + perimetr);
            Console.WriteLine("is equal:" + perimetr.Equals(area));
            double result;
            float h = 4;
            double line=13;
            int countOflines=5;
            double sqareOfBox = 965;
            Math.canWhePutInBox(ref sqareOfBox, ref line, ref countOflines, ref h, out result);
            var anon = new { size = 15, Message = "rownd" };
            Console.WriteLine(anon.size +" "+ anon.Message);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

