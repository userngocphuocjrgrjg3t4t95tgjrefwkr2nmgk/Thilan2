namespace Cau2
{
    public class OrderDetail
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public int Count { get; set; }
        public long Total { get; set; }
        public void Pay()
        {
            Total = Price * Count;
        }
        public void Show()
        {
            System.Console.WriteLine("Name: " + Name + " Price: " + Price + " Count: " + Count + "Total: " + Total);
        }
    }
}