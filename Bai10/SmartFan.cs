/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai10
{
    
    public class SmartFan : IDevice
    {
        public string Name { get; }

        public SmartFan(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Name}: ON");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name}: OFF");
        }
    }
}
