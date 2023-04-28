using System;
using System.Windows;

namespace Profitability.View
{
    public class SavingToDB
    {
        public static void Save(object sender)
        {
            try
                {
                    using (PovlTeContext db = new PovlTeContext())
                    {
                        //db.Database.EnsureCreated();

                        MessageBox.Show("создаем объект");
                        // создаем два объекта User
                        MobileCommunication record = new MobileCommunication();
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
                            MessageBox.Show("Объект успешно сохранен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                        }
                        
                    }
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}