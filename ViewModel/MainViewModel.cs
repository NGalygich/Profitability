using System.Windows;

class MainViewModel : DependencyObject
{
    // ниже идет опимание свойств зависимости, которые буду соединять часть View (окно) и Model (выгрузка данных в БД)
    public double InputData1 // динамическая часть 
    {
        get { return (int)GetValue(InputDataProperty1); }
        set { SetValue(InputDataProperty1, value); }
    }
    public double InputData2 // динамическая часть 
    {
        get { return (int)GetValue(InputDataProperty1); }
        set { SetValue(InputDataProperty1, value); }
    }
    public double InputData3 // динамическая часть 
    {
        get { return (int)GetValue(InputDataProperty1); }
        set { SetValue(InputDataProperty1, value); }
    }

    // статическая часть
    public static readonly DependencyProperty InputDataProperty1 = 
        DependencyProperty.Register("InputData1", typeof(int), typeof(MainViewModel), new PropertyMetadata(0)); // 0 - значение по умолчанию (через запятую добавить метод при котором будет вызываться этот метод)
    public static readonly DependencyProperty InputDataProperty2 = 
        DependencyProperty.Register("InputData2", typeof(int), typeof(MainViewModel), new PropertyMetadata(0)); // 0 - значение по умолчанию (через запятую добавить метод при котором будет вызываться этот метод)
    public static readonly DependencyProperty InputDataProperty3 = 
        DependencyProperty.Register("InputData3", typeof(int), typeof(MainViewModel), new PropertyMetadata(0)); // 0 - значение по умолчанию (через запятую добавить метод при котором будет вызываться этот метод)
    
    public MainViewModel() // конструктор класса (здесь надо будет указать методы выгрузки введенных значений в БД) сами методы будут находиться в дериктиве Model
    {

    }
}