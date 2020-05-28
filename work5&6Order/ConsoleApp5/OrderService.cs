using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ConsoleApp5 {

    public class OrderService
    {
        private List<Order> totalOrder = new List<Order>();
        public List<Order> TotalOrder
        {
            set { totalOrder = value; }
            get { return totalOrder; }
        }
        public void ShowOrder(int OrderNum)
        {
            Order wantedOrder ;
            if (totalOrder != null && totalOrder.Count > 0)
            {
                wantedOrder = FindOrder(OrderNum);
                if (wantedOrder == null)
                {
                    Console.WriteLine(  OrderNum + "号订单不存在 ");
                }
                else
                {
                    OrderItem WantedOrder = new OrderItem(wantedOrder);
                    Console.WriteLine("以下是订单号为：" + OrderNum + "的订单详情。");
                    WantedOrder.getOrder();
                }
            }
            else
            {
                Console.WriteLine("你还没有订单。");
            }

        }
        public void DelectOrder(int OrderNum)
        {
            totalOrder.Remove(FindOrder(OrderNum));
        }
        public Order FindOrder(int OrderNum)
        {
            return totalOrder.Where(s => s.OrderNumber == OrderNum).First() as Order;
        }
        public void Export()
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            {
                using (FileStream fs = new FileStream("s.xml", FileMode.Create))
                {
                    xmlserializer.Serialize(fs, totalOrder);
                }
            }
        }
        public void Import()
        {
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
                totalOrder = (List<Order>)xmlserializer.Deserialize(fs);
            }
        }
    }
}
