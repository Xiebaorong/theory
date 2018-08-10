using Reconsitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution_Test3
{
    /// <summary>
    /// 重构第三步 面向对象 设计模式
    /// 1.耦合性更低
    /// 2.类封密性更高
    /// 3.更易扩展 而不会影响其它逻辑，比如我现在新添加一种电影类型，那么我只需要在添加一个新的计算类就可以了
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
