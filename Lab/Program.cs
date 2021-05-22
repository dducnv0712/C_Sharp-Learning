using Lab.Lab;

namespace Lab
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product pd = new Product(1, "Dien Thoai", 1.2000, 3, 1, 20);
            pd.GetInfo();
            pd.InStock();
            pd.ImageAdd(19);
            pd.RemoveImage(1);
        }
    }
}