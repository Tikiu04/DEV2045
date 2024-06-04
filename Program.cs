using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Lab0201
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Hãy nhập Id từ bàn phím : ");
            var id = Console.ReadLine();
            Console.WriteLine(" Hãy nhập tên từ bàn  phím : ");
            var name = Console.ReadLine();
            Console.WriteLine("Hãy nhập địa chỉ từ bàn phím : ");
            var add = Console.ReadLine();
            Console.WriteLine("Hãy nhập ngày sinh từ bàn phím : ");
            var ngaysinh = Console.ReadLine();
            Console.WriteLine("Hãy nhập lương từ bàn phím :");
            float luong = float.Parse(Console.ReadLine());
            Console.WriteLine("Hãy nhập thưởng từ bàn phím :");
            float thuong = float.Parse(Console.ReadLine());
            float tongluong = luong + thuong;
            Console.WriteLine("Thông tin nhân viên :");
            Console.WriteLine("Mã Id : " + id);
            Console.WriteLine("Họ và tên : " + name);
            Console.WriteLine("Địa chỉ : " + add);
            Console.WriteLine("Ngày sinh : " +  ngaysinh);
            Console.WriteLine("Lương : " + luong);
            Console.WriteLine("Thưởng : " + thuong );
            Console.WriteLine("Tổng  lương : "+ tongluong);
        }
    }
}
