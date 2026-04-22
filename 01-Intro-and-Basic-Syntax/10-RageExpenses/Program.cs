int losses = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());


int headsets = losses / 2;
int mice = losses / 3;
int keyboards = losses / 6;
int displays = losses / 12;

double total = headsets * headsetPrice + mice * mousePrice + keyboards * keyboardPrice + displays * displayPrice;

Console.WriteLine($"Rage expenses: {total:F2} lv.");