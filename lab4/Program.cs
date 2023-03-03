using System;
using System.Numerics;

namespace lab4
{
    public class Product
    {
        private double sneakers_price;
        private double jeans_price;

        public Product(double jeans_price)
        {
            this.jeans_price = jeans_price;
        }

        public Product(double sneakers_price, double jeans_price)
        {
            this.sneakers_price = sneakers_price;
            this.jeans_price = jeans_price;
        }
        
        public static double operator *(double count, Product product)
        {
            return count*product.sneakers_price + count * product.jeans_price;
        }
        public static double operator +(Product count, Product product)
        {
            return product.sneakers_price + count.sneakers_price + count.jeans_price + product.jeans_price;
        }
        public static double operator /(Product count, Product product)
        {
            return (product.sneakers_price + count.sneakers_price) / (count.jeans_price + product.jeans_price);
        }
        public static double operator %(Product count, Product product)
        {
            return (product.sneakers_price + count.sneakers_price) % (count.jeans_price + product.jeans_price);
        }
        public static bool operator <(Product count, Product product)
        {
            return (product.sneakers_price + count.sneakers_price) < (count.jeans_price + product.jeans_price);
        }
        public static bool operator >(Product count, Product product)
        {
            return (product.sneakers_price + count.sneakers_price) > (count.jeans_price + product.jeans_price);
        }
        public static bool operator !=(Product count, Product product)
        {
            return (product.sneakers_price + count.sneakers_price) != (count.jeans_price + product.jeans_price);
        }
        public static bool operator ==(Product count, Product product)
        {
            return (product.sneakers_price + count.sneakers_price) == (count.jeans_price + product.jeans_price);
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Product first = new Product(2000,1200);
            Product second = new Product(1001, 1500);

            double SumTwoclothes = first + second;
            double Count = 2 * first;
            double Substact = first / second;
            double remainder = first % second;
            bool pr = first > second;
            bool pr2 = first < second;
            bool eq1 = first == second;
            bool eq2 = first != second;
            
            Console.WriteLine("Sum All= "+SumTwoclothes);
            Console.WriteLine("CountFirst = " + Count);
            Console.WriteLine("Substact = " + Substact);
            Console.WriteLine("Pr1 = "+pr);
            Console.WriteLine("Pr2 = " + pr2);
            Console.WriteLine("Equals = " + eq1);
            Console.WriteLine("Equals2 = " + eq2);
            

        }

    }
}