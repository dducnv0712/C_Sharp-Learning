/*namespace c_Sharp_Learning.session4
{
    public delegate void ShowString(string s);
    public class Program
    {
        public static void Main(string[] args)
        {
            //DemoDelagate.ShowMsg("Hell Duc");
           // DemoDelagate dd = new DemoDelagate();
           // dd.ShowInfo("Xin Chao");
           ShowString ss = new ShowString(DemoDelagate.ShowMsg);
           ss("Hello T2009M");
           ss += new DemoDelagate().ShowInfo;
           ss("Hello Aptech");
           ss += DemoDelagate.ShowMsg;
           ss("Hello Hanoi");
           ss += new DemoDelagate().ShowInfo;
        }
    }
}*/