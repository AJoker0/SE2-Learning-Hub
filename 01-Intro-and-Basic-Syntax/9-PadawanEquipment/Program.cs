double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double saberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

int sabers = (int)Math.Ceiling(students * 1.1);

int freeBelts = students / 6;
int paidBelts = students - freeBelts;

double total = sabers * saberPrice + students*robePrice + paidBelts*beltPrice;

if (money >= total)
{
    Console.WriteLine($"The money is enough - it would cost {total:F2}lv");
} else
{
    Console.WriteLine($"John will need {total - money:F2}lv more");
}