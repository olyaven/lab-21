List<string> electiveStudents = new List<string>();

electiveStudents.Add("Аня");
electiveStudents.Add("Борис");
electiveStudents.Add("Вика");

Console.WriteLine($"Записалось студентов: {electiveStudents.Count}");

foreach (string student in electiveStudents)
{
    Console.WriteLine(student);
}

electiveStudents.Add("Григорий");
electiveStudents.Add("Мария");

Console.WriteLine($"Обновлённое количество: {electiveStudents.Count}");





List<string> debts = new List<string> { "ПР16", "ПР17", "ПР19" };

if (debts.Contains("ПР20"))
{
    Console.WriteLine("Есть");
}
else
{
    Console.WriteLine("Нет");
}

debts.Remove("ПР17");
debts.RemoveAt(0);

foreach (string debt in debts)
{
    Console.WriteLine(debt);
}






List<string> debtors = new List<string> { "Иванов", "Петров", "Сидоров" };

Console.WriteLine(debtors.Contains("Петров"));
Console.WriteLine(debtors.IndexOf("Сидоров"));
Console.WriteLine(debtors.IndexOf("Кузнецов"));

Console.Write("Введите фамилию: ");
string surname = Console.ReadLine();

if (debtors.Contains(surname))
{
    Console.WriteLine("Должник найден");
}
else
{
    Console.WriteLine("Должник не найден");
}






List<int> FilterPassing(List<int> grades)
{
    List<int> result = new List<int>();

    foreach (int grade in grades)
    {
        if (grade >= 3)
        {
            result.Add(grade);
        }
    }

    return result;
}

List<int> grades = new List<int> { 4, 5, 3, 5, 4, 2 };

grades.Sort();

foreach (int grade in grades)
{
    Console.WriteLine(grade);
}

List<int> passingGrades = FilterPassing(grades);

Console.WriteLine("Оценки 3 и выше:");

foreach (int grade in passingGrades)
{
    Console.WriteLine(grade);
}





List<string> students = new List<string>();

students.Add("Анна");
students.Add("Борис");
students.Add("Вика");
students.Add("Григорий");
students.Add("Мария");

foreach (string student in students)
{
    Console.WriteLine(student);
}





List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

Console.Write("Введите число для удаления: ");
int number = int.Parse(Console.ReadLine());

if (numbers.Contains(number))
{
    numbers.Remove(number);
    Console.WriteLine("Число удалено");
}
else
{
    Console.WriteLine("Число не найдено");
}

foreach (int item in numbers)
{
    Console.WriteLine(item);
}







List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

Console.Write("Введите число для поиска: ");
int number = int.Parse(Console.ReadLine());

int index = numbers.IndexOf(number);

if (index != -1)
{
    Console.WriteLine($"Позиция элемента: {index}");
}
else
{
    Console.WriteLine("Не найдено");
}







List<int> FilterEven(List<int> numbers)
{
    List<int> result = new List<int>();

    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            result.Add(number);
        }
    }

    return result;
}

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

List<int> evenNumbers = FilterEven(numbers);

foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}








List<string> requests = new List<string>();

while (true)
{
    Console.WriteLine("\nМеню заявок на ремонт:");
    Console.WriteLine("1 — Добавить заявку");
    Console.WriteLine("2 — Удалить заявку");
    Console.WriteLine("3 — Показать список заявок");
    Console.WriteLine("4 — Отсортировать список");
    Console.WriteLine("0 — Выход");

    Console.Write("Выберите действие: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Введите название заявки: ");
            string newRequest = Console.ReadLine();

            requests.Add(newRequest);

            Console.WriteLine("Заявка добавлена");
            break;

        case "2":
            Console.Write("Введите название заявки для удаления: ");
            string requestToDelete = Console.ReadLine();

            if (requests.Remove(requestToDelete))
            {
                Console.WriteLine("Заявка удалена");
            }
            else
            {
                Console.WriteLine("Заявка не найдена");
            }
            break;

        case "3":
            if (requests.Count == 0)
            {
                Console.WriteLine("Список заявок пуст");
            }
            else
            {
                foreach (string request in requests)
                {
                    Console.WriteLine(request);
                }
            }
            break;

        case "4":
            requests.Sort();

            Console.WriteLine("Список отсортирован");
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Неверный выбор");
            break;
    }
}





