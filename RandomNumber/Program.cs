﻿
Random rnd = new Random();
int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 10; i++)
{ 
 myRandomNum = rnd.Next(0 , 11);// 0-10
    randomSum = randomSum + myRandomNum;
Console.WriteLine($"My random number {myRandomNum}");
}
Console.WriteLine($"random sum total: {randomSum}");
