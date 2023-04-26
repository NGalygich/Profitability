using System.Windows;

class MainViewModel : DependencyObject
{
    // ниже идет опимание свойств зависимости, которые буду соединять часть View (окно) и Model (выгрузка данных в БД)
    public double InputData // динамическая часть 
    {
        get { return (int)GetValue(InputDataProperty); }
        set { SetValue(InputDataProperty, value); }
    }

    // статическая часть
    public static readonly DependencyProperty InputDataProperty = 
        DependencyProperty.Register("InputData", typeof(int), typeof(MainViewModel), new PropertyMetadata(0)); // 0 - значение по умолчанию (через запятую добавить метод при котором будет вызываться этот метод)
    
    public MainViewModel() // конструктор класса (здесь надо будет указать методы выгрузки введенных значений в БД) сами методы будут находиться в дериктиве Model
    {

    }
}