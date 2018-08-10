using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.ReadLine();
        }

        static void Print()
        {

            StringBuilder printValue = new StringBuilder();

            Customer customer = new Customer("刘先生");
            printValue.Append($"顾客：{customer.Name}");
            printValue.AppendLine();

            Movie movie = new Movie("归来", MovieType.Children);
            Rental rental = new Rental(movie, 10);
            printValue.Append($"租赁电影：{rental.Movie.Title}    天数:{rental.Days}");
            printValue.AppendLine();

            Movie movie1 = new Movie("龙门飞甲", MovieType.New);
            Rental rental1 = new Rental(movie1, 4);

            printValue.Append($"租赁电影：{rental1.Movie.Title}    天数:{rental1.Days}");
            printValue.AppendLine();

            customer.AddRental(rental);
            customer.AddRental(rental1);

            //积分
            double integral = 0;
            //价格
            double price = 0;

            foreach (var item in customer.Rentals)
            {
                switch (item.Movie.MovieType)
                {
                    case MovieType.Ordinary:
                        integral += 2;
                        if (item.Days > 3)
                            integral += (item.Days - 3) * 1.5;
                        price += 10 + item.Days * 2;
                        break;
                    case MovieType.Children:
                        integral += 1;
                        if (item.Days > 5)
                            integral += (item.Days - 5) * 1.5;
                        price += 5 + item.Days * 1;
                        break;
                    case MovieType.New:
                        integral += item.Days * 3;
                        price += 20 + item.Days * 3;
                        break;
                    default:
                        break;
                }
            }

            printValue.Append($"本次积分：{integral}");
            printValue.AppendLine();

            printValue.Append($"本次消费：{price}");
            printValue.AppendLine();

            Console.WriteLine(printValue.ToString());
        }
    }
}
