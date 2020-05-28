using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5 {

  
 
    class OrderItem
    {
        private Order order;
        public OrderItem(Order a)
        {
            this.order = a;
        }
        public void getOrder()
        {
            Console.WriteLine("订单号：" + order.OrderNumber);
            Console.WriteLine("客户名：" + order.Customer.CustomerName);
            Console.WriteLine("--------------------------------");
            double Sum = 0;
            if (order.Item != null)
            {
                foreach (Item item in order.Item)
                {
                    Console.WriteLine(item.ToString());
                    Sum += item.ItemTotalPirce;
                    Console.WriteLine("--------------------------------");
                }
            }
            else
            {
                Console.WriteLine("该订单没有商品。");
            }
            Console.WriteLine("所有商品总价为：" + Sum);
        }
    }
}
