namespace Lab.Lab
{
    public class Diamond : Product
    {
        public int cara;

        public Diamond()
        {
        }

        public Diamond(int cara)
        {
            this.cara = cara;
        }

        public Diamond(int id, string name, double price, int qty, int image, int desc, int cara) : base(id, name, price, qty, image, desc)
        {
            this.cara = cara;
        }

        public void Test()
        {
            
        }
        
    }
}