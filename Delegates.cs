using System;
namespace HelloWorld
{ 
    class Delegates
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("sum is"+ c);
        }
        public void subtract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("subtraction is"+ c);
        }

     
        public static void Main(String[] args)
        {


            Delegates obj = new Delegates();
            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);
            //del_obj1(100, 40);
            //del_obj2(100, 40);

    // call this funtions with the delegates as well
            del_obj1.Invoke(100, 40);
            del_obj2.Invoke(100, 60);
        }
    }
}
    

