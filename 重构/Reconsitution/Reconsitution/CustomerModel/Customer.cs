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
    }
}
