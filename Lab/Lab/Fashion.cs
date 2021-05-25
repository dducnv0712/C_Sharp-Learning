namespace Lab.Lab
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public Fashion()
        {
        }

        public Fashion(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public Fashion(int id, string name, double price, int qty, int image, int desc, string color, string size) : base(id, name, price, qty, image, desc)
        {
            this.color = color;
            this.size = size;
        }

        public void checkProduct()
        {
            
        }

        public void checkQty()
        {
            
        }
    }
}