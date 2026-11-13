/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai10
{
    public sealed class SmartHomeFacade
    {
        private readonly IDevice light;
        private readonly IDevice fan;
        private readonly ILockable door;


        public SmartHomeFacade(IDevice light, IDevice fan, ILockable door)
        {
            this.light = light;
            this.fan = fan;
            this.door = door;
        }

        public void GoToWork()
        {
            light.TurnOff();
            fan.TurnOff();
            door.Lock();
        }
        public void GoToSleep()
        {
            light.TurnOn();
            fan.TurnOff();
            door.Lock();

            int Level = HomeConfiguration.Instance.NightLightLevel;
            Console.WriteLine($"Độ sáng: {Level}");
        }
    }
}
