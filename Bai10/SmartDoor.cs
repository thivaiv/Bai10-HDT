/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai10
{
    
    public class SmartDoor : IDevice, ILockable
    {
        public string Name { get; }

        public SmartDoor(string name)
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

        public void Lock()
        {
            Console.WriteLine($"{Name}: LOCKED");
        }

        public void Unlock()
        {
            Console.WriteLine($"{Name}: UNLOCKED");
        }
    }
}
