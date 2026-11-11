/****************/
//mã sinh viên: 202418989
//họ tên: Chu Đình Thi
/****************/
using System;

namespace Bai10
{
    public static class DeviceFactory
    {
        public static IDevice Create(string type, string name)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Device type ko đc trống");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Device name ko đc trống");
            }

            return type.Trim().ToLowerInvariant() switch
            {
                "light" => new SmartLight(name),
                "fan" => new SmartFan(name),
                "door" => new SmartDoor(name),
                _ => throw new ArgumentException($"Invalid device type: {type}")
            };
        }
    }
}
