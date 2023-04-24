﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Data.SqlClient;

namespace Profitability
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void cteateButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User tom = new User { Name = "Tom", Age = 33 };
                User alice = new User { Name = "Alice", Age = 26 };
            
                // добавляем их в бд
                db.Users.Add(tom);
                db.Users.Add(alice);
                db.SaveChanges();
                //Console.WriteLine("Объекты успешно сохранены");
                MessageBox.Show("Объекты успешно сохранены");
            
                // получаем объекты из бд и выводим на консоль
                // var users = db.Users.ToList();
                // Console.WriteLine("Список объектов:");
                // foreach (User u in users)
                // {
                //     Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                // }
            }
        }
    }
}
