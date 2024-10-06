using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapArraylistvalist
{
    internal class Program
    {
//        public class Item
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public double Price { get; set; }
//            public DateTime CreatedDate { get; set; }
//            public bool IsActive { get; set; }
//        }
//        static void Main(string[] args)
//        {
//            //Khởi tạo mảng
//            Item[] items = new Item[20]
//            {
//new Item { Id = 1, Name = "Item 1", Price = 10.5, CreatedDate = DateTime.Now.AddDays(-1), IsActive = true },
//new Item { Id = 2, Name = "Item 2", Price = 21.0, CreatedDate = DateTime.Now.AddDays(-2), IsActive = false },
//new Item { Id = 3, Name = "Item 3", Price = 31.5, CreatedDate = DateTime.Now.AddDays(-3), IsActive = true },
//new Item { Id = 4, Name = "Item 4", Price = 42.0, CreatedDate = DateTime.Now.AddDays(-4), IsActive = false },
//new Item { Id = 5, Name = "Item 5", Price = 52.5, CreatedDate = DateTime.Now.AddDays(-5), IsActive = true },
//new Item { Id = 6, Name = "Item 6", Price = 63.0, CreatedDate = DateTime.Now.AddDays(-6), IsActive = false },new Item { Id = 7, Name = "Item 7", Price = 73.5, CreatedDate = DateTime.Now.AddDays(-7), IsActive = true },
//new Item { Id = 8, Name = "Item 8", Price = 84.0, CreatedDate = DateTime.Now.AddDays(-8), IsActive = false },
//new Item { Id = 9, Name = "Item 9", Price = 94.5, CreatedDate = DateTime.Now.AddDays(-9), IsActive = true },
//new Item { Id = 10, Name = "Item 10", Price = 105.0, CreatedDate = DateTime.Now.AddDays(-10), IsActive = false },
//new Item { Id = 11, Name = "Item 11", Price = 115.5, CreatedDate = DateTime.Now.AddDays(-11), IsActive = true },
//new Item { Id = 12, Name = "Item 12", Price = 126.0, CreatedDate = DateTime.Now.AddDays(-12), IsActive = false },
//new Item { Id = 13, Name = "Item 13", Price = 136.5, CreatedDate = DateTime.Now.AddDays(-13), IsActive = true },
//new Item { Id = 14, Name = "Item 14", Price = 147.0, CreatedDate = DateTime.Now.AddDays(-14), IsActive = false },
//new Item { Id = 15, Name = "Item 15", Price = 157.5, CreatedDate = DateTime.Now.AddDays(-15), IsActive = true },
//new Item { Id = 16, Name = "Item 16", Price = 168.0, CreatedDate = DateTime.Now.AddDays(-16), IsActive = false },
//new Item { Id = 17, Name = "Item 17", Price = 178.5, CreatedDate = DateTime.Now.AddDays(-17), IsActive = true },
//new Item { Id = 18, Name = "Item 18", Price = 189.0, CreatedDate = DateTime.Now.AddDays(-18), IsActive = false },
//new Item { Id = 19, Name = "Item 19", Price = 199.5, CreatedDate = DateTime.Now.AddDays(-19), IsActive = true },
//new Item { Id = 20, Name = "Item 20", Price = 210.0, CreatedDate = DateTime.Now.AddDays(-20), IsActive = false }
//            };
//            //1.Hien thi danh sach mang tren ra man hinh
//            Console.WriteLine("Danh sach cac phan tu trong mang:");
//            foreach (var item in items)
//            {
//                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, CreatedDate: {item.CreatedDate}, IsActive: {item.IsActive}");
//            }
//            //2. Chuyen doi sang Arraylist và List<item>
//            ArrayList arrayList = new ArrayList(items);

//            List<Item> itemList = new List<Item>(items);

//            Console.WriteLine("Danh sach tu ArrayList:");
//            foreach (Item item in arrayList)
//            {
//                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.CreatedDate} - {item.IsActive}" );
//            }

//            Console.WriteLine("Danh sach tu List<Item>:");
//            foreach (var item in itemList)
//            {
//                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.CreatedDate} - {item.IsActive}");
//            }

//            Console.WriteLine($"Tong so phan tu da them: {arrayList.Count}");
//            //3. Tim kiem phan tu Id =10 voi Arraylist 
//            var item10 = arrayList.Cast<Item>().FirstOrDefault(i => i.Id == 10);
//            if (item10 != null)
//            {
//                Console.WriteLine($"Phan tu tim thay trong ArrayList: {item10.Name}, Price: {item10.Price}");
//                Console.WriteLine($"Vi tri trong ArrayList: {arrayList.IndexOf(item10)}");
//            }
//            else
//            {
//                Console.WriteLine("Khong tim thay phan tu co Id = 10 trong ArrayList.");
//            }
//            // Tìm trong List<Item>
//            var item10InList = itemList.FirstOrDefault(i => i.Id == 10);
//            if (item10InList != null)
//            {
//                Console.WriteLine($"Phan tu tim thay trong List<Item>: {item10InList.Name}, Price: {item10InList.Price}");
//                Console.WriteLine($"Vi tri trong List<Item>: {itemList.IndexOf(item10InList)}");
//            }
//            else
//            {
//                Console.WriteLine("Khong tim thay phan tu co Id = 10 trong List<Item>.");
//            }
//            //4. Xoa phan tu co Price <100
//            itemList.RemoveAll(item => item.Price < 100.0);

//            foreach (var item in itemList)
//            {
//                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}");
//            }
//            //5. Hien thi danh sach voi dieu kien IsActive la True
//            Console.WriteLine("Danh sach voi IsActive la True:");
//            foreach (Item item in itemList.Where(i => i.IsActive))
//            {
//                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, CreatedDate: {item.CreatedDate}, IsActive: {item.IsActive}");
//            }
//            //6. Hien thi danh sach san pham trong vong 10 ngay
//            DateTime tenDaysAgo = DateTime.Now.AddDays(-10);
//            Console.WriteLine("Danh sach san pham trong vong 10 ngay:");
//            foreach (Item item in itemList.Where(i => i.CreatedDate >= tenDaysAgo))
//            {
//                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, CreatedDate: {item.CreatedDate}, IsActive: {item.IsActive}");
//            }
//            //7. Sap xep tu nho den lon
//            var sortedList = itemList.OrderByDescending(i => i.Price).ThenBy(i => i.Name).ToList();

//            Console.WriteLine("Danh sach sau khi sap xep tu nho den lon:");
//            foreach (Item item in sortedList)
//            {
//                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, CreatedDate: {item.CreatedDate}, IsActive: {item.IsActive}");
//            }
//            //8. Nhap ten san pham va tim kiem
//            Console.WriteLine("Nhap ten san pham:");
//            string productName = Console.ReadLine();
//            var searchedItem = itemList.FirstOrDefault(i => i.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

//            if (searchedItem != null)
//            {
//                Console.WriteLine($"Tim thay san pham - Id: {searchedItem.Id}, Name: {searchedItem.Name}, Price: {searchedItem.Price}, CreatedDate: {searchedItem.CreatedDate}, IsActive: {searchedItem.IsActive}");
//            }
//            else
//            {
//                Console.WriteLine("Khong tim thay san pham");
//            }
//            //9. Tinh tong gia tien san pham
//            double totalPriceArrayList = arrayList.Cast<Item>().Sum(i => i.Price);
//            double totalPriceList = itemList.Sum(i => i.Price);

//            Console.WriteLine($"Tong gia tien trong ArrayList: {totalPriceArrayList}");
//            Console.WriteLine($"Tong gia tien trong List<Item>: {totalPriceList}");
//            //10. Tim cac san pham co gia tri lon nhat va sap xep theo ngay khoi tao
//            double maxPrice = itemList.Max(i => i.Price);
//            var maxPriceItems = itemList.Where(i => i.Price == maxPrice).OrderBy(i => i.CreatedDate).ToList();

//            Console.WriteLine("Cac san pham co gia tri lon nhat:");
//            foreach (Item item in maxPriceItems)
//            {
//                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, CreatedDate: {item.CreatedDate}, IsActive: {item.IsActive}");
//            }
//            Console.ReadLine();
//        }
    }
}
