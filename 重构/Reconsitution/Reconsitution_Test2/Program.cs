using Reconsitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution_Test2
{
    /// <summary>
    /// 重构第二步  各司其职   解耦
    /// 1.类之间逻辑清楚各司其职，各自提供对外的接口，供外部调用。
    /// 2.易扩展：比如我现在需要增加一种HTML格式的打印结果
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Customer customer = InitCustomer();
            string printValue = customer.PrintToString();
            Console.WriteLine(printValue);
            Console.ReadLine();
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
    }
}
