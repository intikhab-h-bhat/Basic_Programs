// See https://aka.ms/new-console-template for more information
//create a program to check weather the number is pallendrome or not

#region //number is pallendrome
//Console.WriteLine("Enter the number to check pallendrome");

//int number = int.Parse(Console.ReadLine());

//int sum = 0;
//int reminder;
//int temp = number;

//while (number > 0)
//{
//    reminder = number % 10;
//    sum = (sum * 10) + reminder;
//    number = number / 10;

//}
//if (temp == sum)
//{
//    Console.WriteLine("Number is pallendrome");
//}
//else
//{
//    Console.WriteLine("Number is not pallendrome");
//}
#endregion

#region //String is pallendrome
//Check the string is pallendrome or not

//Console.WriteLine("Enter the string to check for  pallendrome");

//string name=Console.ReadLine();
//string reverse=string.Empty;

//for(int i = name.Length-1; i >= 0; i--)
//{
//    reverse +=name[i].ToString();

//}
//if (name == reverse)
//{
//    Console.WriteLine("name is pallendrome");
//}
//else
//{
//    Console.WriteLine("Not pallendrome");
//}
#endregion

#region //prime number

//Console.WriteLine("check weather the number is prime or not");
//int isNumberPrime=int.Parse(Console.ReadLine());

//for (int i = 2; i < isNumberPrime; i++)
//{
//    if (isNumberPrime % i == 0)   
//        break;


//}

#endregion

#region //LinkedList
using Basic_Programs.BubbleSort;
using Basic_Programs.Exaples_Sir;
using Basic_Programs.Factorial;
using Basic_Programs.GcdLcm;

//using Basic_Programs.Dictonery;
//using System.Xml.Schema;
using Basic_Programs.LinkedList;
using Basic_Programs.QuiskSort;
using Basic_Programs.Searchprogram;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Numerics;

LinkedList list = new LinkedList();

// Add elements to the list
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(40);

Console.WriteLine("Linked List after adding elements:");
list.PrintList();

// Remove an element
list.Remove(20);
Console.WriteLine("\nLinked List after removing 20:");
list.PrintList();

// Remove an element not in the list
list.Remove(50);

#endregion

//using Basic_Programs.LinkedList;

//NodeDemo nodeA=new NodeDemo();
//nodeA.Data = 324;
//NodeDemo nodeB=new NodeDemo();
//nodeB.Data = 453;
//NodeDemo nodeC=new NodeDemo();
//nodeC.Data = 675;
//NodeDemo nodeD=new NodeDemo();
//nodeD.Data = 700;

//nodeA.Next=nodeB;
//nodeB.Next=nodeC;
//nodeC.Next=nodeD;

#region //Bubbler Sort

//int[] numbers = { 65, 10, 85, 12 };

//BubbleSortDemo bs = new BubbleSortDemo();

//Console.WriteLine("list before sorting");
//bs.PrintArray(numbers);

//bs.BubbleSort(numbers);
//Console.WriteLine("list After sorting");
//bs.PrintArray(numbers);



#endregion

#region //max of three numbers
//// program to find the max of three numbers
//Console.WriteLine("Enter the First Number");
//int firstNumber=(int.Parse(Console.ReadLine()));

//Console.WriteLine("Enter the Second Number");
//int secondNumber= (int.Parse(Console.ReadLine()));

//Console.WriteLine("Enter the Third Number");
//int thirdNumber=(int.Parse(Console.ReadLine()));

//if(firstNumber>secondNumber && firstNumber > thirdNumber)
//{
//    Console.WriteLine($"{firstNumber} is greater then {secondNumber} and {thirdNumber}");
//}
//else if(secondNumber>firstNumber &&  secondNumber > thirdNumber)
//{
//    Console.WriteLine($"{secondNumber} is greater then {firstNumber} and {thirdNumber}");

//}
//else
//{
//    Console.WriteLine($"{thirdNumber} is greater then {firstNumber} and {secondNumber}");

//}
#endregion

#region //Odd even
//Console.WriteLine("Enter the number");
//int number = int.Parse(Console.ReadLine());
//if(number <= 0)
//{
//    Console.WriteLine("Enter the number greater than 0");
//    return;
//}

//if(number%2 == 0)
//{
//    Console.WriteLine($"{number} is Even");
//}
//else
//{
//    Console.WriteLine($"{number} is odd");
//}

#endregion

#region //Factorial
//Console.WriteLine("Enter the number");
//int number=int.Parse(Console.ReadLine());
//int factorial= 1;
//int temp = number;

//if (number < 0)
//{
//    Console.WriteLine("Enter the number greater greater or equal to 0");


//}
//if(number == 0)
//{
//    Console.WriteLine($"The factorial of {number} is {factorial}");
//}
//else
//{
//    while( number > 0 )
//    {
//        factorial = factorial * number;
//        number= number - 1;
//    }
//   Console.WriteLine($"The factorial of {temp} is {factorial}");
//}


#endregion

#region //Pallendrome

//int number = 1234321;
//int sum = 0;
//int reminder;
//int temp=number;

//while (number > 0)
//{
//    reminder = number % 10;
//    sum = (sum * 10) + reminder;
//    number = number / 10;
// }
//if (temp == sum)
//{
//    Console.WriteLine("Pallendrome");
//}
//else
//{
//    Console.WriteLine("Not Pallendrome");
//}


#endregion

#region //Prime number
//Console.WriteLine("Enter the number");
//int number = int.Parse(Console.ReadLine());



//for(int i=2;i<number-1;i++)
//{
//    if (number % i == 0)
//    {
//        Console.WriteLine("the number is not prime");
//        return;
//    }
//    else
//    {
//        Console.WriteLine("The number is prime");
//        return;
//    }

//}
#endregion

#region //Fibonacci

//Console.WriteLine("Enter the number of elements");
//int numberOfElements = int.Parse(Console.ReadLine());
//int n1 = 0;
//int n2 = 1;
//int n3;

//Console.Write($"{n1},{n2},");
//for(int i = 2;i< numberOfElements; i++)
//{
//    n3=n2 + n1;
//    Console.Write($"{n3},");
//    n1 = n2;
//    n2 = n3;
//}

#endregion

#region //Dictonery
//Customer cust1 = new Customer()
//{
//    Id = 1,
//    Name = "Abcd",
//    Address = "ksjdks"
//};
//Customer cust2 = new Customer()
//{
//    Id = 2,
//    Name = "Abcd",
//    Address = "ksjdks"
//};
//Customer cust3 = new Customer()
//{
//    Id = 3,
//    Name = "Abcd",
//    Address = "ksjdks"
//};

//Dictionary<int, Customer> customerDictonery = new Dictionary<int, Customer>();

//customerDictonery.Add(cust1.Id, cust1);
//customerDictonery.Add(cust2.Id, cust2);
//customerDictonery.Add(cust3.Id, cust3);

//if (!customerDictonery.ContainsKey(cust1.Id))
//{
//    customerDictonery.Add(cust1.Id, cust1);

//}

//foreach (KeyValuePair<int, Customer> custInfo in customerDictonery)
//{
//    Console.WriteLine(custInfo.Key);
//    Customer cust=custInfo.Value;
//    Console.WriteLine("******************************");

//    Console.WriteLine("Id={0} Name={1} Address={2}", cust.Id, cust.Name, cust.Address);


//}

//Customer ctest;
//if (customerDictonery.TryGetValue(11, out ctest))
//{ 
//    Console.WriteLine("Present");

//}
//else
//{
//    Console.WriteLine("Not Present");
//}

//foreach(Customer c in customerDictonery.Values)
//{
//    Console.WriteLine($"Id's{c.Id} {c.Name} {c.Address}");
//}

#endregion

#region // QuickSort

//int[] numbers = [12, 10, 8, 14, 7];

//QuickSort quickSort = new QuickSort();
//Console.WriteLine("Before Sorting");
//quickSort.PrintArray(numbers);

//quickSort.QuickSortDemo(numbers, 0, numbers.Length - 1);
//Console.WriteLine("After Sorting");
//quickSort.PrintArray(numbers);


#endregion

#region // Armstrong number

//Console.WriteLine("Enter the number");
//int number=int.Parse(Console.ReadLine());

//int reminder, sum = 0;
//int temp = number;

//while (number > 0)
//{
//    reminder = number % 10;
//    sum=sum+(reminder*reminder*reminder);
//    number = number / 10;
//}
//if (temp == sum)
//{
//    Console.WriteLine($"The number {temp} is armstrong number");
//}
//else
//{
//   Console.WriteLine("Not an armstrong number");
//}

#endregion

#region
//GcdLcd gcdLcd = new GcdLcd();

//// Input numbers
//int num1 = 12, num2 = 18;

//// Calculate GCD
//int gcd = gcdLcd.FindGCD(num1, num2);

//// Calculate LCM
//int lcm = (num1 * num2) / gcd;

//// Output results
//Console.WriteLine($"Numbers: {num1}, {num2}");
//Console.WriteLine($"GCD: {gcd}");
//Console.WriteLine($"LCM: {lcm}");


#endregion

//********************************************************************************************
//********************************************************************************************

#region // Pallendrome practice
//Program to check wheather the number is pallendrome or not

//Console.WriteLine("Enter the number");
//int number=int.Parse(Console.ReadLine());
//int reminder, sum = 0;
//int temp = number;

//while (number > 0)
//{
//    reminder= number % 10;
//    sum = (sum * 10) + reminder;
//    number = number / 10;

//}
//if (temp == sum)
//{
//    Console.WriteLine($"{temp} is pallendrome");
//}
//else
//{
//    Console.WriteLine($"{temp} is not pallendrome");
//}


//Program to check weather the string is pallendrome or not

//Console.WriteLine("Enter the string");
//string name=Console.ReadLine();
//string reverse = string.Empty;
//for(int i = name.Length-1;i>=0;i--)
//{
//    reverse = reverse + name[i];
//}
//if(reverse == name)
//{
//    Console.WriteLine($"{name} is pallendrome");
//}
//else
//{
//    Console.WriteLine($"{name} is not  pallendrome");
//}

#endregion

#region prime number practice
//Program to find the weather the number is prime or not
//Console.WriteLine("Enter the Number: ");
//int number =int.Parse(Console.ReadLine());

//for(int i = 2; i < number - 1; i++)
//{
//    if(number % i == 0)
//    {
//        Console.WriteLine($"{number} is not prime");
//        return;
//    }   

//}
//Console.WriteLine($"{number} is Prime");



#endregion

#region //Factorial of a    number Practice
////Program to find the factorial of anumber
//Console.WriteLine("Enter the number");
//int number= int.Parse(Console.ReadLine());
//int fact=1;

//while (number > 0)
//{
//    fact = number * fact;
//    number--;
//}
//Console.WriteLine($"Factorial of a {number} is {fact}");

#endregion

#region // Fibanooci series
//Console.WriteLine("Enter the number");
//int number=int.Parse(Console.ReadLine());
//int n1 = 0;
//int n2 = 1;
//int n3;

//Console.Write($"{n1},{n2}");
//for(int i = 2;i<= number; i++)
//{
//    n3 = n1 + n2;
//    n1= n2;
//    n2= n3;
//    Console.Write($",{n3}");
//}

#endregion

#region // Armstrong Number
//Console.WriteLine("Enter the number: ");
//int number= int.Parse(Console.ReadLine());
//int reminder, sum = 0;
//int temp=number;
//while (number > 0)
//{
//    reminder=number%10;
//    sum=(sum)+(reminder*reminder*reminder);
//    number = number/10;
//}
//if (temp == sum)
//{
//    Console.WriteLine("Armstrong");
//}
//else
//{
//    Console.WriteLine("not Armstrong ");
//}

#endregion

#region Max of three numbers
//Console.WriteLine("Enter the FirstNumber");
//int firstNumber=int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the SecondNumber");
//int secondNumber=int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the ThirdNumber");
//int thirdNumber=int.Parse(Console.ReadLine());

//if((firstNumber>secondNumber) && (firstNumber > thirdNumber))
//{
//    Console.WriteLine($"{firstNumber} is grreater than {secondNumber} and {thirdNumber}");

//}if((secondNumber>firstNumber) && (secondNumber > thirdNumber))
//{
//    Console.WriteLine($"{secondNumber} is grreater than {firstNumber} and {thirdNumber}");

//}
//else 
//{ 

//    Console.WriteLine($"{thirdNumber} is grreater than {secondNumber} and {firstNumber}");

//}


#endregion


#region //Bubble Sort

//int[] numbers = [12, 10, 15, 6];

//BubbleSortDemo bubbleSort=new BubbleSortDemo();

//Console.WriteLine("Before Sorting");
//bubbleSort.PrintArray(numbers);

//bubbleSort.BubbleSort(numbers);

//Console.WriteLine("After Sorting");
//bubbleSort.PrintArray(numbers);



#endregion

#region // quick Sort

//Console.WriteLine("Quick Sort Program");

//int[] quickSortArray = [12,34,13,10];
//QuickSort qs = new QuickSort();

//Console.WriteLine("Before Sorting");
//qs.PrintArrayList(quickSortArray);

//qs.QuickSortDemo(quickSortArray,0,quickSortArray.Length-1);

//Console.WriteLine("After Sorting");
//qs.PrintArrayList(quickSortArray);

#endregion


#region  //Fizz Buzz
//Console.WriteLine(" Fizz Buzz Program");

//for (int i = 0; i < 10; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine($"{i} is Fizz buzz");
//    }
//    else if (i % 3 == 0)
//    {


//        Console.WriteLine($"{i}  is Fizz");
//    }
//    else if (i % 5 == 0)
//    {


//        Console.WriteLine($"{i}  is Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}


#endregion



#region
//FactorialProg factOfNumber= new FactorialProg();

//factOfNumber.FactorialDemo(3);

//LinearSearch ls=new LinearSearch();
//ls.SearchElement(5);

int[] numbers = [12, 13, 14, 15];
int l = numbers.Length;
BinarySearch bs= new BinarySearch();
int numberfound= bs.BinarSearhDemo(numbers, l, 14);

Console.WriteLine(numberfound);

#endregion



#region // Example 2 from Sir

//string T = "hello<<<<<";
//string output = string.Empty;
//int length = T.Length;

//for (int i = 0; i < length - 1; i++)
//{
//    if (T[i] != '<')
//    {
//        output = output + T[i];
//    }
//    else
//    {
//        if (output.Length != 0)
//        {
//            for (int j = 0; j < output.Length; j++)
//            {
//                if (j == output.Length - 1)
//                {
//                    output = output.Remove(j);
//                    j = 0;
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(output);

#endregion




#region  //Example 1
//string T = "ma<<king>>prog<re<ss";
////string T = "hello<<<<<";
//string output = string.Empty;
//int length = T.Length;

//for (int i = 0; i < length - 1; i++)
//{

//    if (T[i] != '<')
//    {
//        output = output + T[i];
//    }
//    else if (T[i] == '<')
//    {
//        if (output.Length != 0)
//        {
//            for (int j = 0; j < output.Length; j++)
//            {
//                if (j == output.Length - 1)
//                {
//                    output = output.Remove(j);
//                    j = 0;
//                }
//            }
//        }

//    }
//    else
//    {
//        for (int k = 0; k < length - 1; k++)
//        {
//            if (T[i] != '>')
//            {
//                output = output + T[i];
//            }
//            else
//            {
//                if (output.Length != 0)
//                {
//                    for (int j = 0; j < output.Length; j++)
//                    {
//                        if (j == output.Length - 1)
//                        {
//                            output = output.Remove(j);
//                            j = 0;
//                        }
//                    }
//                }
//            }
//        }
//    }

//}
//Console.WriteLine(output);

#endregion




//stringOperation strOper = new stringOperation();

////string T = "hello<<<<<";
//string result = strOper.RemoveArrows(T);
//Console.WriteLine(result);




string T = "ma<<king>>prog<re<ss";
//string T = "hello<<<<<";
var chars = new List<char>(T);
int flag = 1;
while (flag == 1)
{
    flag = 0;
    for (int i = 0; i < chars.Count; i++)
    {
        if (chars[i] == '<' && i > 0)
        {
            chars.RemoveAt(i);
            chars.RemoveAt(i - 1);
            flag = 1;
            break;

        }
        else if (chars[i] == '>' && i < chars.Count - 1)
        {
            if (chars[i + 1] == '>' && i + 1 < chars.Count)
            {
                chars.RemoveAt(i + 2);
                chars.RemoveAt(i + 1);
                flag = 1;
                break;

            }
            chars.RemoveAt((i + 1));
            chars.RemoveAt(i);
            flag = 1;
            break;
        }
    }

}
Console.WriteLine((chars.ToArray()));








//Program to find the weather the number is prime or not
//Console.WriteLine("Enter the Number: ");
//int number = int.Parse(Console.ReadLine());





//int[] number = [12,3,4];

//foreach(int p in number)
//{

//    for (int i = 2; i < p - 1; i++)
//    {
//        if (p % i == 0)
//        {
//            Console.WriteLine($"{p} is not prime");
//            break;
//        }

//    }
//    Console.WriteLine($"{p} is Prime");
//}
