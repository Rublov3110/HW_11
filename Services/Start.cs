using HW_11.Collections;
using HW_11.Comparers;
using HW_11.Interface;

namespace HW_11.Services
{
    public class Start : IStart
    {
        private Display _display;
        public Start()
        {
            _display = new Display();
        }

        public void Run()
        {
            var basket = new Basket<int>();

            for (var i = 0; i < 10; i++)
            {
                basket.Add(i);
            }

            _display.DisplayBasket(basket);

            var nums = new int[] { 11, 22, 33, 1, 2 };

            basket.AddRange(nums);

            _display.DisplayBasket(basket);

            var list = new List<int>(new int[] { 77, 88, 99 });

            basket.AddRange(list);

            _display.DisplayBasket(basket);

            basket.Remove(22);

            _display.DisplayBasket(basket);

            basket.RemoveAt(3);

            _display.DisplayBasket(basket);

            basket.Sort(new DefaultComparer());

            _display.DisplayBasket(basket);
        }
    }
}
