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

namespace Profitability.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Loaded += MainWindow_Loaded;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }

        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (PovlTeContext db = new PovlTeContext())
                {
                    //db.Database.EnsureCreated();

                    MessageBox.Show("создаем два объекта User");
                    // создаем два объекта User
                    MobileCommunication record = new MobileCommunication();// { Name = "Tom", Age = 33 };
                    //record.Value = MobileCommunication.Text;
                    //User alice = new User { Name = "Alice", Age = 26 };
                    MessageBox.Show("добавляем их в бд");
                    // добавляем их в бд
                    try
                    {
                        db.MobileCommunications.Add(record); 
                        //db.Users.Add(alice); 
                        db.SaveChanges(); 
                        //Console.WriteLine("Объекты успешно сохранены");
                        MessageBox.Show("Объекты успешно сохранены");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                    }
                    // catch ( FormatException fe )
                    // {
                    //     // FormatException isn't caught because it's stored "inside" the FileNotFoundException
                    // }
                    // catch ( FileNotFoundException fnfe ) 
                    // {
                    //     string innerMessage = "", outerMesage;
                    //     if (fnfe.InnerException != null)
                    //         innerMessage = fnfe.InnerException.Message; // Inner exception (FormatException) message
                    //     outerMesage = fnfe.Message;
                    //     Console.WriteLine($"Inner Exception:\n\t{innerMessage}");
                    //     Console.WriteLine($"Outer Exception:\n\t{outerMesage}");
                    // }        

                    
                
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

        // public static void Log(string message) 
        // {
        //     File.AppendAllText("log.txt", message);
        // }

        // public void cteateButton_Click(object sender, RoutedEventArgs e)
        // {
        // //     try
        // //     {
        // //         using (ApplicationContext db = new ApplicationContext())
        // //         {
        // //             //db.Database.EnsureCreated();

        // //             MessageBox.Show("создаем два объекта User");
        // //             // создаем два объекта User
        // //             User tom = new User { Name = "Tom", Age = 33 };
        // //             User alice = new User { Name = "Alice", Age = 26 };
        // //             MessageBox.Show("добавляем их в бд");
        // //             // добавляем их в бд
        // //             try
        // //             {
        // //                 db.Users.Add(tom); 
        // //                 db.Users.Add(alice); 
        // //                 db.SaveChanges(); 
        // //                 //Console.WriteLine("Объекты успешно сохранены");
        // //                 MessageBox.Show("Объекты успешно сохранены");
        // //             }
        // //             catch (Exception ex)
        // //             {
        // //                 MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        // //             }


                    
                
        // //             // получаем объекты из бд и выводим на консоль
        // //             // var users = db.Users.ToList();
        // //             // Console.WriteLine("Список объектов:");
        // //             // foreach (User u in users)
        // //             // {
        // //             //     Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
        // //             // }
        // //         }
        // //     }
        // //     catch (Exception ex)
        // //    {
        // //      MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        // //    }
        // }
    }
}
