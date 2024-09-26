/* 
Task:
Write a program that asks how many items have been purchased and determines if each item needs to be restocked. 
Ask the user how many of each item has been purchased
Calculate the remaining stock
Print whether or not it needs to be restocked.

Build Specifications:
Soda starts with 100 in stock and will need a restock at 40
Chips starts with 40 in stock and will need a restock at 20
Candy starts with 60 in stock and will need a restock at 40
Each item should have a variable that holds its current stock value and a variable that holds the restock value.

*/

//Soda

Console.WriteLine("How many sodas have been sold today? 100 are in stock");
int sodaStock = 100;
int sodaSold = int.Parse(Console.ReadLine());
int sodaRemaining = sodaStock - sodaSold;
if (sodaSold > 100)
{
    sodaSold = 0;
    Console.WriteLine("The value of Sodas sold is higher than the initial stock. Stock not adjusted.");
} else
{
    Console.WriteLine("There are " + sodaRemaining + " bottles of soda left");
}


//Chips

Console.WriteLine("How many chips have been sold today? 40 in stock");
int chipStock = 40;
int chipSold = int.Parse(Console.ReadLine());
int chipRemaining = chipStock - chipSold;
if (chipSold > 40)
{
    chipSold = 0;
    Console.WriteLine("The value of chips sold is higher than the initial stock. Stock not adjusted");
} else {
    Console.WriteLine("There are " + chipRemaining + " bags of chips left");
}

//Candy

Console.WriteLine("How many bags of candy have been sold today? 60 in stock");
int candyStock = 60;
int candySold = int.Parse(Console.ReadLine());
int candyRemaining = candyStock - candySold;
if (candySold > 60)
{
    candySold = 0;
    Console.WriteLine("The value of bags of candy sold is higher than the initial stock. Stock not adjusted.");
}
else
{
    Console.WriteLine("There are " + candyRemaining + " bags of candy left");
}

//Restock notification loops
Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");


if (sodaRemaining <= 40)
{
    Console.WriteLine("There are " + sodaRemaining + " bottles of soda in stock. The soda needs to be restocked.");
} else
{
    Console.WriteLine("There are " + sodaRemaining + " bottles of soda in stock. The soda does not need to be restocked.");
}
if (chipRemaining <= 20)
{
    Console.WriteLine("There are " + chipRemaining + " bags of chips in stock. The chips need to be restocked.");
}
else
{
    Console.WriteLine("There are " + chipRemaining + " bags of chips in stock. The chips do not need to be restocked.");
}
if (candyRemaining <= 40)
{
    Console.WriteLine("There are " + candyRemaining + " bags of candy in stock. The candy needs to be restocked.");
} else
{
    Console.WriteLine("There are " + candyRemaining + " bags of candy in stock. The candy does not need to be restocked.");
}
