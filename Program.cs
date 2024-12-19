// See https://aka.ms/new-console-template for more information
// Atama ve işlemli atama

int x = 3;
int y = 3;
y = y + 2;

Console.WriteLine(y);

y += 2;

Console.WriteLine(y);

y /= 1;

Console.WriteLine(y);

x *= 2;

Console.WriteLine(x);




// Mantıksal Operatörler

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted) { Console.WriteLine("OK"); }

if (isSuccess || isCompleted) { Console.WriteLine("Nice"); }
if(isSuccess && !isCompleted) { Console.WriteLine("Fine"); }

// İlişkisel operatörler

int a = 3;
int b = 4;
bool sonuc = a < b;

Console.WriteLine(sonuc);

sonuc = a > b;
Console.WriteLine(sonuc);

sonuc = a >= b;
Console.WriteLine(sonuc);

sonuc = a <= b;
Console.WriteLine(sonuc);

sonuc = a == b;
Console.WriteLine(sonuc);

sonuc = a != b;
Console.WriteLine(sonuc);


// Aritmetik operatörler

int sayi = 10;
int sayi2 = 5;
int sonuc1 = sayi / sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi * sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi + sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi++;
Console.WriteLine(sonuc1);

int sonuc2 = 20 % 3;
Console.WriteLine(sonuc2);





Console.ReadLine();