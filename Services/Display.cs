using HW_11.Collections;
using HW_11.Interface;

namespace HW_11.Services
{
    public class Display : IDisplay
    {
        public void DisplayBasket<T>(Basket<T> basket)
        {
            foreach (var item in basket)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
