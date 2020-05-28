using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        public static int Ordernumber = 0;
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            l1:
            {
                Console.WriteLine("命令列表：0.增加订单 1.修改订单 2.删除订单 3.查询订单");
               Console.WriteLine("4.将订单序列化与反序列化");
                Console.Write("请选择你要做的操作：");
            }
            switch (Console.ReadLine())
            {
                case "0":
                    {
                        Console.Clear();
                        List<Item> allItem = new List<Item>();
                        int Ordernum = ++Ordernumber;
                        Console.Write("请输入顾客姓名:");
                        Customer a = new Customer() { CustomerName = Console.ReadLine() };
                        l2:
                        {

                            Console.Write("请输入商品名：");
                            string Itemname = Console.ReadLine();

                            int Itemnum = 0;
                            Console.Write("请输入商品数量：");
                            while (!Int32.TryParse(Console.ReadLine(), out Itemnum))
                            {
                                Console.WriteLine("请输入数字：");
                            }

                            Console.Write("请输入商品单价：");
                            Double Itemprice = 0;
                            while (!Double.TryParse(Console.ReadLine(), out Itemprice))
                            {
                                Console.WriteLine("请输入数字：");
                            }

                            Item NewItem = new Item()
                            {
                                ItemName = Itemname,
                                ItemNum = Itemnum,
                                Perprice = Itemprice
                            };
                            allItem.Add(NewItem);
                        }
                        Order t = new Order()
                        {
                            OrderNumber = Ordernum,
                            Customer = a,
                            Item = allItem
                        };
                        orderService.TotalOrder.Add(t);

                        Console.WriteLine("该商品添加完成，该订单的订单号为：" + Ordernum);
                        l3:
                        {
                            Console.WriteLine("是否在该订单中继续添加商品？");
                            Console.WriteLine("0:是");
                            Console.WriteLine("1:否");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 0:
                                    {
                                        goto l2;
                                    }
                                case 1:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("输入无效指令，请继续输入：");
                                        goto l3;
                                    }
                            }
                            break;
                        }

                    }
                    
                case "1":
                    {
                        Console.Clear();
                        Console.Write("请选择你要进行修改的订单的订单号：");
                        int OrderNumber = Int32.Parse(Console.ReadLine());
                        orderService.ShowOrder(OrderNumber);
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("以下是你可以进行的操作：");
                        Console.WriteLine("0:修改客户名");
                        Console.WriteLine("1:增添商品");
                        Console.WriteLine("2:删除商品");
                        Console.WriteLine("请选择你要做的修改操作：");
                        switch (Int32.Parse(Console.ReadLine()))
                        {
                            case 0:
                                {
                                    Console.Clear();

                                    Console.WriteLine("请输入新的用户名：");
                                    orderService.FindOrder(OrderNumber).ChangeCustomer(Console.ReadLine());
                                    break;
                                }
                            case 1:
                                {
                                    
                                    Console.Write("请输入商品名：");
                                    string Itemname = Console.ReadLine();
                                   
                                   

                                    int Itemnum = 0;
                                    Console.WriteLine("请输入商品数量：");
                                    while (!Int32.TryParse(Console.ReadLine(), out Itemnum))
                                    {
                                        Console.WriteLine("请输入数字：");
                                    }

                                    Console.Write("请输入商品单价：");
                                    Double Itemprice = 0;
                                    while (!Double.TryParse(Console.ReadLine(), out Itemprice))
                                    {
                                        Console.WriteLine("请输入数字：");
                                    }

                                    Item NewItem = new Item()
                                    {
                                        ItemName = Itemname,
                                        ItemNum = Itemnum,
                                        Perprice = Itemprice
                                    };
                                    orderService.FindOrder(OrderNumber).itemAdd(NewItem);
                                    break;

                                }
                            case 2:
                                {
                                    Console.Write("请输入商品名：");
                                    string Itemname = Console.ReadLine();
                                    orderService.FindOrder(OrderNumber).itemDel(Itemname);
                                    break;
                                }
                        }
                        break;
                    }
                    
                case "2":

                    {
                        Console.Clear();
                        if (orderService.TotalOrder.Count == 0) { Console.WriteLine("没有现存订单。"); }
                        else
                        {
                            Console.Write("请输入你要删除的订单的订单号：");
                            int Ordernum = Int32.Parse(Console.ReadLine());
                            orderService.DelectOrder(Ordernum);
                            Ordernumber -= 1;
                        }
                        break;
                    }

                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("以下是可进行的操作：");
                        Console.WriteLine("1:将全部订单序列化");
                        Console.WriteLine("2：反序列化");
                        A1:
                        {
                            switch (Console.ReadLine())
                            {

                                case "1":
                                    {
                                        Console.Clear();
                                        orderService.Export();
                                        Console.WriteLine(File.ReadAllText("s.xml"));
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.Clear();
                                        orderService.Import();
                                        break;
                                    }
                                default:
                                    {

                                        Console.WriteLine("你输入了错误指令，请重新输入：");
                                        goto A1;
                                    }
                                    break;
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("输入了无效指令，请重新输入。");
                        goto l1;
                    }
            }
            Console.WriteLine("按任意键回到操作界面。");
            Console.ReadLine();
            goto l1;
        }
    }
}
