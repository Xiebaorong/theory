using Reconsitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution_Test1
{
    /// <summary>
    /// 重构第一步  分解重组
    /// 1.逻辑更加清楚，易阅读
    /// 2.通过封装提高了可复用性
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = InitCustomer();
            string value = Print(customer);
            Console.WriteLine(value);
            Console.ReadLine();
        }

        /// <summary>
        /// 打印
        /// </summary>
        static string Print(Customer customer)
        {
            if (customer == null)
                return "";

            StringBuilder printValue = new StringBuilder();

            printValue.Append($"顾客：{customer.Name}").AppendLine();

            //积分 价格
            double integral = 0, money = 0;

            foreach (var item in customer.Rentals)
            {
                printValue.Append($"租赁电影：{item.Movie.Title}    天数:{item.Days}").AppendLine();
                integral += CalculatingIntegral(item);
                money += CalculatingMoney(item);
            }

            printValue.Append($"本次积分：{integral}").AppendLine();
            printValue.Append($"本次消费：{money}").AppendLine();

            return printValue.ToString();
        }

        /// <summary>
        /// 初始化数据信息
        /// </summary>
        /// <returns></returns>
        private static Customer InitCustomer()
        {
            Customer customer = new Customer("刘先生");

            Movie movie = new Movie("归来", MovieType.Children);
            Rental rental = new Rental(movie, 10);

            Movie movie1 = new Movie("龙门飞甲", MovieType.New);
            Rental rental1 = new Rental(movie1, 4);

            customer.AddRental(rental);
            customer.AddRental(rental1);
            return customer;
        }

        /// <summary>
        /// 计算积分
        /// </summary>
        private static double CalculatingIntegral(Rental rental)
        {
            double integral = 0;
            switch (rental.Movie.MovieType)
            {
                case MovieType.Ordinary:
                    integral = CalculatingIntegral_Ordinary(rental.Days);
                    break;
                case MovieType.Children:
                    integral = CalculatingIntegral_Children(rental.Days);
                    break;
                case MovieType.New:
                    integral = CalculatingIntegral_New(rental.Days);
                    break;
                default:
                    break;
            }
            return integral;
        }

        /// <summary>
        /// 普通电影积分计算
        /// </summary>
        private static double CalculatingIntegral_Ordinary(int day)
        {
            double integral = 2;
            if (day > 3)
                integral += (day - 3) * 1.5;
            return integral;
        }

        /// <summary>
        /// 儿童电影积分计算
        /// </summary>
        private static double CalculatingIntegral_Children(int day)
        {
            double integral = 1;
            if (day > 5)
                integral += (day - 5) * 1.5;
            return integral;
        }

        /// <summary>
        /// 新电影积分计算
        /// </summary>
        private static double CalculatingIntegral_New(int day)
        {
            return day * 3;
        }

        /// <summary>
        /// 计算金额
        /// </summary>
        private static double CalculatingMoney(Rental rental)
        {
            double price = 0;
            switch (rental.Movie.MovieType)
            {
                case MovieType.Ordinary:
                    price += 10 + rental.Days * 2;
                    break;
                case MovieType.Children:
                    price += 5 + rental.Days * 1;
                    break;
                case MovieType.New:
                    price += 20 + rental.Days * 3;
                    break;
                default:
                    break;
            }
            return price;
        }
    }
}
