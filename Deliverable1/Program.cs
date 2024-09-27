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
int sodaStock = 100;
int sodaRestock = 40;
Console.WriteLine("How many sodas have been sold today? " + sodaStock + " are in stock.");
int sodaSold = int.Parse(Console.ReadLine());

if (sodaSold <= sodaStock)
{
    sodaStock -= sodaSold;
    Console.WriteLine("There are " + sodaStock + " bottles of soda left.");
}
else {
    Console.WriteLine("The value of Sodas sold is higher than the initial stock. Stock not adjusted.");
}



//Chips
int chipStock = 40;
int chipRestock = 20;
Console.WriteLine("How many chips have been sold today? " + chipStock + " are in stock.");
int chipSold = int.Parse(Console.ReadLine());

if (chipSold <= chipStock)
{
    chipStock -= chipSold;
    Console.WriteLine("There are " + chipStock + " bags of chips left.");
} else {
    Console.WriteLine("The value of chips sold is higher than the initial stock. Stock not adjusted");
}

//Candy
int candyStock = 60;
int candyRestock = 40;
Console.WriteLine("How many bags of candy have been sold today? " + candyStock + " are in stock.");
int candySold = int.Parse(Console.ReadLine());

if (candySold <= candyStock)
{
    candyStock -= candySold;
    Console.WriteLine("There are " + candyStock + " bags of candy left.");
}
else
{
    Console.WriteLine("The value of bags of candy sold is higher than the initial stock. Stock not adjusted.");
}

//Restock notification loops
Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");


if (sodaStock <= sodaRestock)
{
    Console.WriteLine("There are " + sodaStock + " bottles of soda in stock. The soda needs to be restocked.");
} else
{
    Console.WriteLine("There are " + sodaStock + " bottles of soda in stock. The soda does not need to be restocked.");
}
if (chipStock <= chipRestock)
{
    Console.WriteLine("There are " + chipStock + " bags of chips in stock. The chips need to be restocked.");
}
else
{
    Console.WriteLine("There are " + chipStock + " bags of chips in stock. The chips do not need to be restocked.");
}
if (candyStock <= candyRestock)
{
    Console.WriteLine("There are " + candyStock + " bags of candy in stock. The candy needs to be restocked.");
} else
{
    Console.WriteLine("There are " + candyStock + " bags of candy in stock. The candy does not need to be restocked.");
}
