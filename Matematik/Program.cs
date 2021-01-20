using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(6, 9);

            dortIslem.Cikar(9, 12);

            dortIslem.Carp(9, 12);

            dortIslem.Bol(12,5);
        }
    }
}
