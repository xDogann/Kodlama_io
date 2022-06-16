// Tenary Operatoru
var oran = 5 > 10 ? "5 Büyük" : "10 Büyük";
Console.WriteLine(oran);

//switch ile birden fazla koşul belirlediğimizde kullanırız.
switch (1 < 5)
{
    case true:
        Console.WriteLine("Küçük");
        break;
    case false:
        Console.WriteLine("Büyük");
        break;
    default:
        break;
}

// While'da Koşul sağlandığı sürece Çalışır (Break ile çıkılır)
int i = 0;
while (true)
{
    Console.WriteLine(i);
    i++;
    if (i == 5)
    {
        break;
    }
}