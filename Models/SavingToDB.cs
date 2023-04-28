using System;
using System.Windows;

class SavingToDB
{
    public void Save()
    {
        // try
        // {
        //     using (PovlTeContext db = new PovlTeContext())
        //     {
        //         //db.Database.EnsureCreated();

        //         MessageBox.Show("создаем два объекта User");
        //         // создаем два объекта User
        //         User tom = new User { Name = "Tom", Age = 33 };
        //         User alice = new User { Name = "Alice", Age = 26 };
        //         MessageBox.Show("добавляем их в бд");
        //         // добавляем их в бд
        //         try
        //         {
        //             db.Users.Add(tom); 
        //             db.Users.Add(alice); 
        //             db.SaveChanges(); 
        //             //Console.WriteLine("Объекты успешно сохранены");
        //             MessageBox.Show("Объекты успешно сохранены");
        //         }
        //         catch (Exception ex)
        //         {
        //             MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        //         }


                
            
        //         // получаем объекты из бд и выводим на консоль
        //         // var users = db.Users.ToList();
        //         // Console.WriteLine("Список объектов:");
        //         // foreach (User u in users)
        //         // {
        //         //     Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
        //         // }
        //     }
        // }
        // catch (Exception ex)
        // {
        //     MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        // }
    }
}