using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution
{
    /// <summary>
    /// 顾客类
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 租赁列表
        /// </summary>
        public List<Rental> Rentals { get; private set; } = new List<Rental>();


        public Customer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 添加租赁信息
        /// </summary>
        public void AddRental(Rental rental)
        {
            this.Rentals.Add(rental);
        }

        /// <summary>
        /// 打印
        /// </summary>
        public string PrintToString()
        {
            StringBuilder printValue = new StringBuilder();

            printValue.Append($"顾客：{this.Name}").AppendLine();

            //积分 价格
            double integral = 0, money = 0;

            foreach (var item in this.Rentals)
            {
                printValue.Append($"租赁电影：{item.Movie.Title}    天数:{item.Days}").AppendLine();
                integral += item.CalculatingIntegral();
                money += item.CalculatingMoney();
            }

            printValue.Append($"本次积分：{integral}").AppendLine();
            printValue.Append($"本次消费：{money}").AppendLine();

            return printValue.ToString();
        }
    }
}
