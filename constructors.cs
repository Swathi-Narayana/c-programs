using System;

namespace HelloWorld
{
    public class GFG<T>
    {

        // private data members
        private T data;

        // using properties
        public T value
        {

            // using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }

    // Driver class
    class Test
    {

        // Main method
        static void Main(string[] args)
        {

            // instance of string type
            GFG<string> name = new GFG<string>();
            name.value = "GeeksforGeeks";

            // instance of float type
            GFG<float> version = new GFG<float>();
            version.value = 5.0F;

            // display GeeksforGeeks
            Console.WriteLine(name.value);

            // display 5
            Console.WriteLine(version.value);
        }
    }
}
