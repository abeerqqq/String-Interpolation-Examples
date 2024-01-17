// See https://aka.ms/new-console-template for more information
string name = "john";
int age = 20;

string info = $"Name: {name}, Ages: {age}";
Console.WriteLine(info);
//Console.ReadKey();
/*Format*/
double price = 99.99;
string foramttedPrice = $"Total Price: {price:C2}";
Console.WriteLine(foramttedPrice);

/*Multiline*/
string multiline = $@"This is testing code
for showing multiline string
This is test";
Console.WriteLine(multiline);

/*Conditional formatting*/
bool isPrem = true;
string usertest = $"user is {(isPrem ? "Premuim" : "Standard")} User";
Console.WriteLine(usertest);


/*Functioal Calls*/
DateTime dateTime = DateTime.Now;
string date = $"Date Now is: {dateTime.ToShortDateString()}"; // Date Now is: 1/17/2024 
string date1 = $"Date Now is: {dateTime.ToLongDateString()}"; //Wednesday, January 17, 2024
string date2 = $"Date Now is: {dateTime.ToLongTimeString()}"; //Date Now is: 10:20:01 AM
string date3 = $"Date Now is: {dateTime.ToShortTimeString()}"; //Date Now is: 10:21 AM
Console.WriteLine(date3);

/*Verbatim interpolation*/
string path = @"C:\MyFiles";
string fullPath = $@"The full path is: {path}";
Console.WriteLine(fullPath);

/*Culture Specific values*/
double numericValue = 1234.5678;
string formattedValue = $"{numericValue:N2}";
Console.WriteLine(formattedValue); //1,234.57