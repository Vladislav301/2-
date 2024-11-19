using System;
using System.Linq;

public class AccessModifierExample
{
   
    public int Add(int x, int y)
    {
        return x + y;
    }
    private void PrintResult(int result)
    {
        Console.WriteLine($"Результат: {result}");
    }
    public static void Main(string[] args)
    {
        AccessModifierExample example = new AccessModifierExample();
        int sum = example.Add(7, 3);
        Console.WriteLine($"Сумма 7 + 3 = {sum}"); 
        example.PrintResult(sum);
        use user1 = new use("Влад", "Иванов", "ivan.ivanov@example.com");
        Console.WriteLine($"Имя: {user1.Имя}, Email: {user1.Email}, Дата регистрации: {user1.ДатаРегистрации}");
        try
        {
            use user2 = new use("Петр", "Петров", "неверный_email");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    public class use
    {
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains('@'))
                {
                    throw new ArgumentException("Неверный формат Email адреса.");
                }
                _email = value;
            }
        }
        public DateTime ДатаРегистрации { get; private set; } 
        public bool Активен { get; set; } = true; 
        public int? Телефон { get; set; } 
        public use(string имя, string фамилия, string email)
        {
            Имя = имя;
            Фамилия = фамилия;
            Email = email; 
            ДатаРегистрации = DateTime.Now;
        }
    }
     

    
}