using System;

namespace HelloWorld
{
    public class GenericClass<T>
    {
        private T data;
        public T value
        { 
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

    class Test
    {

        static void Main(string[] args)
        {


            GenericClass<string> name = new GenericClass<string>();
            name.value = "swathi";

            GenericClass<float> version = new GenericClass<float>();
            version.value = 5.0F;

            GenericClass<int> age = new GenericClass<int>();
            age.value = 22;
            Console.WriteLine(name.value);
            Console.WriteLine(age.value);
            Console.WriteLine(version.value);
        }
    }
}
