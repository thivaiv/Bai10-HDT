/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("==========================================================");
            Console.WriteLine("                          TEST                            ");
            Console.WriteLine("==========================================================");

            //t1
            Console.WriteLine("\nT1, Tạo light, fan, door:");
            IDevice light = DeviceFactory.Create("light", "Living room light");
            IDevice fan = DeviceFactory.Create("fan", "Living room fan");
            IDevice door = DeviceFactory.Create("door", "Main door");
            Console.WriteLine($"Tạo thành công: {light.GetType().Name}, {fan.GetType().Name}, {door.GetType().Name}");

            //t2
            Console.WriteLine("\nT2, Tạo loại camera khi chưa hỗ trợ:");
            try
            {
                DeviceFactory.Create("camera", "Security camera");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Bắt lỗi : {ex.Message}");
            }

            //t3
            Console.WriteLine("\nT3, Lấy HomeConfiguration.Instance hai lần:");
            var c1 = HomeConfiguration.Instance;
            var c2 = HomeConfiguration.Instance;
            bool isSame = ReferenceEquals(c1, c2);
            Console.WriteLine($"cùng tham chiếu: {isSame}");

            //t4
            Console.WriteLine("\nT4, Gọi GoToWork():");
            var facade = new SmartHomeFacade(light, fan, (ILockable)door);
            facade.GoToWork();

            //t5
            Console.WriteLine("\nT5, Gọi GoToSleep():");
            facade.GoToSleep();

            Console.WriteLine("\n==========================================================");
            Console.WriteLine("                          TEST                            ");
            Console.WriteLine("==========================================================");
        }
    }
}
