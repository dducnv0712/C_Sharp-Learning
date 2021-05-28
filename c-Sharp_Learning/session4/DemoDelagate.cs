using System;

namespace c_Sharp_Learning.session4
{
    
    public class DemoDelagate
    {
        
        public DemoDelagate()
        {
            
        }

        public static void ShowMsg(string msg)
        {
            Console.WriteLine("Show msg " + msg);
        }

        public void ShowInfo(string info)
        {
            Console.WriteLine("Show Info " + info);
        }
        
    }
}