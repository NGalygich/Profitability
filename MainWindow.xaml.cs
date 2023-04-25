using System;
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
using System.IO;
//using System.Data.SqlClient;

namespace Profitability
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void Log(string message) 
        {
            File.AppendAllText("log.txt", message);
        }

        public void cteateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    //db.Database.EnsureCreated();

                    MessageBox.Show("создаем два объекта User");
                    // создаем два объекта User
                    User tom = new User { Name = "Tom", Age = 33 };
                    User alice = new User { Name = "Alice", Age = 26 };
                    MessageBox.Show("добавляем их в бд");
                    // // добавляем их в бд
                    try
                    {
                        db.Users.Add(tom); // ошибка при добавлении новогоэлемента в таблицу (таблица не создается)
                        db.Users.Add(alice); // ошибка при добавлении новогоэлемента в таблицу (таблица не создается)
                        db.SaveChanges(); // команда сохранения проходит
                        //Console.WriteLine("Объекты успешно сохранены");
                        MessageBox.Show("Объекты успешно сохранены");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                    }


                    
                
                    // получаем объекты из бд и выводим на консоль
                    // var users = db.Users.ToList();
                    // Console.WriteLine("Список объектов:");
                    // foreach (User u in users)
                    // {
                    //     Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                    // }
                }
            }
            catch (Exception ex)
           {
             MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
           }
        }
    }
}
