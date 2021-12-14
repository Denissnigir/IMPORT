using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2._123;

namespace ConsoleApp2
{
    class Program
    {

        public static CabelDBEntities cabel = new CabelDBEntities();
        static void Main(string[] args)
        {
            //var directory = Directory.GetFiles(@"C:\Users\snigi\Desktop\123");

            //foreach(var user in cabel.Employee)
            //{
            //    var x = File.ReadAllBytes(directory.FirstOrDefault(p => p.Contains(user.PhotoPath)));
            //    if (x != null)
            //    {
            //        user.PhotoByte = x;
            //    }
            //    else
            //    {
            //        user.PhotoByte = File.ReadAllBytes(directory.FirstOrDefault(p => p.Contains("Фото для заглушки при отсутствии фото сотрудника.jpg")));
            //    }

            //}
            //cabel.SaveChanges();




            var x = File.ReadAllText("..\\..\\Адреса абонентов.json");

            var y = JsonConvert.DeserializeObject<List<data>>(x);

            File.WriteAllLines("aa.txt", y.ToList().Select(p => $"{p.prefix}").ToArray());

            //var lines = File.ReadAllLines("..\\..\\Абоненты.txt");
            //int i = 0;

            //foreach (var line in lines)
            //{
            //    var data = line.Split(',');
            //    i++;
            //    foreach (var x in data)
            //    {
            //        var y = cabel.Service.ToList().Where(p => p.Name == x).FirstOrDefault();

            //        var g = new ContractService();
            //        g.ContractId = i;
            //        g.ServiceId = y.Id;
            //        cabel.ContractService.Add(g);
            //        cabel.SaveChanges();
            //    }

            //}

        }
    }

    public class data
    {
        public string prefix { get; set; }
    }
}
