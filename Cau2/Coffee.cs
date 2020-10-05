using System.Collections.Generic;
using System;
using System.Collections;

namespace Cau2
{
    public class Coffee
    {
        Table table = new Table();
        Dictionary<int, Table> tableList = new Dictionary<int, Table>();
        List<OrderDetail> orderList = new List<OrderDetail>();
        int d = 1;
        public void NewOrder()
        {
            Table table = new Table();
            OrderDetail orderDetail = new OrderDetail();
            table.TableId = d++;
            Console.WriteLine("Nhap StartTime: ");
            table.StartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap EndTime: ");
            table.EndTime = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("________________________________");
            System.Console.WriteLine("OrderDetails: ");
            Console.WriteLine("Nhap Name: ");
            orderDetail.Name = Console.ReadLine();
            System.Console.WriteLine("Nhap Price: ");
            orderDetail.Price = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap Count: ");
            orderDetail.Count = int.Parse(Console.ReadLine());
            tableList.Add(table.TableId, table);
            orderList.Add(orderDetail);
        }
        public void Show()
        {
            foreach (var item in tableList.Values)
            {
                item.ShowInfo();
            }
            foreach (var item in orderList)
            {
                item.Pay();
                item.Show();
            }
        }
        public void UpdaterOrder()
        {
            bool search = false;
            Console.Write("Nhap TableId : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Table item in tableList.Values)
            {
                if (id.Equals(item.TableId))
                {
                    search = true;
                    OrderDetail orderDetail = new OrderDetail();
                    orderList.Clear();
                    Console.WriteLine("Nhap Name: ");
                    orderDetail.Name = Console.ReadLine();
                    System.Console.WriteLine("Nhap Price: ");
                    orderDetail.Price = long.Parse(Console.ReadLine());
                    System.Console.WriteLine("Nhap Count: ");
                    orderDetail.Count = int.Parse(Console.ReadLine());
                    orderList.Add(orderDetail);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Update Sucessful!");
            else
                Console.WriteLine("Invalid Table");
        }
        public void CancelOrder()
        {
            int n;
            Console.Write("Nhap TableId can xoa: ");
            int.TryParse(Console.ReadLine(), out n);
            foreach (var de in tableList)
            {
                if (de.Key.Equals(n))
                {

                    tableList.Remove(n);
                    break;
                }
                Console.WriteLine(tableList.Count);
            }
        }

        public void Search()
        {
            Console.Write("Nhap TableId : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Table item in tableList.Values)
            {
                if (id.Equals(item.TableId))
                {
                    item.Pay();
                    item.ShowInfo();
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid Table");
                }
            }
        }
        public void Pay()
        {
            bool search = false;
            Console.Write("Nhap TableId : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Table item in tableList.Values)
            {
                if (id.Equals(item.TableId))
                {
                    search = true;
                    item.Pay();
                    item.ShowInfo();
                    tableList.Remove(id);
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid Table");
                }
            }
            if (search == true)
                Console.WriteLine("Pay Sucessful!");
            else
                Console.WriteLine("Not Found!");
        }
    }
}
