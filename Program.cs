﻿// //1 
// int user = Convert.ToInt32(Console.ReadLine());
// if(user<100000 && user > 9999){
//     if ((user/10000 == user % 10)&&(user/1000)%10 == (user%100)/10) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");    
// }else{
//     Console.WriteLine("Не является 5-ти значным числом");
// }
// //2
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2 - y1,2)+Math.Pow(z2 - z1,2))}");
// //3
// int user0 = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= user0; i++){
//     Console.Write($"{Math.Pow(i,3)} ");
// }
// Console.WriteLine();
// // доп 1
// double user1 = Convert.ToDouble(Console.ReadLine());
// if (user1 < 100) Console.WriteLine($"{(user1/100)*105}");
// else if(user1 >= 100 && user1 < 200) Console.WriteLine($"{(user1/100)*107}");
// else Console.WriteLine($"{(user1/100)*110}");
// доп 2
int user2 = Convert.ToInt32(Console.ReadLine());
int userCoppy = user2;
int counter = 0;
while (userCoppy > 1){
    userCoppy/=10;
    counter++;
}
Console.WriteLine($"{counter}");