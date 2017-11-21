using System;

namespace Variables_and_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;
            Pi = 1; // will not work because Pi is a constant
        }
    }
}
