using System;
using System.Collections.Generic;

namespace Cau2
{
    public class Table : ITable
    {
        public int TableId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long SumTotal { get; set; }

        List<OrderDetail> list = new List<OrderDetail>();
        public void Pay()
        {
            OrderDetail orderDetail = new OrderDetail();
            SumTotal = orderDetail.Total;
        }

        public void ShowInfo()
        {

            System.Console.WriteLine("TableID: " + TableId + " StartTime: " + StartTime + " Endtime:" + EndTime);
            System.Console.WriteLine("SumTotal: " + SumTotal);
        }
    }
}