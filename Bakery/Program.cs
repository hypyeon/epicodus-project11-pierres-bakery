using System;
using Bakery.Models;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Thread.Sleep(500);
      Console.WriteLine("Today we have bread ($5/loaf) and pastry ($2/ea) available.");
      Console.WriteLine(".");
      Thread.Sleep(500);
      Console.WriteLine(".");
      Thread.Sleep(500);
      Console.WriteLine(".");
      Thread.Sleep(500);
      Console.WriteLine("How many loaves of bread do you want to purchase? Enter a number.");
      string bread = Console.ReadLine();  
      Console.WriteLine("How many pastries do you want to purchase? Enter a number.");
      string pastry = Console.ReadLine();
      Console.WriteLine("Please provide a name for this order.");
      string name = Console.ReadLine();
      name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();

      try 
      {
        int breadAmount = int.Parse(bread);
        int pastryAmount = int.Parse(pastry);
        string userName = name;
        Bread breadOrder = new Bread(breadAmount);
        Pastry pastryOrder = new Pastry(pastryAmount);
        ConfirmOrder(breadOrder, pastryOrder, userName);
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = Color.Red;
        Console.WriteLine("ERROR: {0}", ex.Message);
        Console.WriteLine("Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.ResetColor();
        Console.WriteLine("Enter 'again' to start over.");
        string again = Console.ReadLine();
        again = again.ToUpper();
        if (again == "AGAIN")
        {
          Main();
        }
      }
    }

    static void ConfirmOrder(Bread breadOrder, Pastry pastryOrder, string userName)
    {
      ShowSpinner();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine($"Here's the order summary for {userName}.");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine($"Bread: {breadOrder.GetOrderAmount()} loaf/loaves");
      Console.WriteLine($"Pastry: {pastryOrder.GetOrderAmount()} ea");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Just a heads up, we have a deal going on today.");
      Console.WriteLine("Buy 2 Get 1 Free for Bread & Buy 3 Get 1 Free for Pastry!");
      Console.WriteLine("Do you want to proceed with your original order? \nEnter 'yes' to proceed or 'no' to place a new order.");
      string answer = Console.ReadLine();
      answer = answer.ToUpper();
      if (answer == "YES")
      {
        GetReceipt(breadOrder, pastryOrder);
      }
      else 
      {
        Console.WriteLine("Let's refresh your order.");
        Console.WriteLine("How many loaves of bread?");
        string bread = Console.ReadLine();  
        Console.WriteLine("How many pastries?");
        string pastry = Console.ReadLine();  
        int breadAmount = int.Parse(bread);
        int pastryAmount = int.Parse(pastry);
        breadOrder.orderAmount = breadAmount;
        pastryOrder.orderAmount = pastryAmount;
        ConfirmOrder(breadOrder, pastryOrder, userName);
      }
    }

    static void GetReceipt(Bread breadOrder, Pastry pastryOrder)
    {
      ShowSpinner();
      Console.WriteLine("-----------------------------------------------");
      Console.WriteLine("Thank you for your order! This is your receipt.");
      Console.WriteLine("-----------------------------------------------");
      Console.WriteLine($"Bread . . . . . . . . . . . . . . . . . . . {breadOrder.GetOrderAmount()}");
      Console.WriteLine($". . . . . . . . . . . . . . . . . . . . . . ${breadOrder.GetPrice()}");
      Console.WriteLine("-----------------------------------------------");
      Console.WriteLine($"Pastry . . . . . . . . . . . . . . . . . . . {pastryOrder.GetOrderAmount()}");
      Console.WriteLine($". . . . . . . . . . . . . . . . . . . . . . ${pastryOrder.GetPrice()}");
      Console.WriteLine("-----------------------------------------------");
      Console.WriteLine($"Total . . . . . . . . . . . . . . . . . . . ${breadOrder.GetPrice() + pastryOrder.GetPrice()}");
      Console.WriteLine("-----------------------------------------------");
      Console.WriteLine("Please enter 'ok' to confirm your order. To start a new order, enter 'new'. \nTo exit, enter any key.");
      string response = Console.ReadLine(); 
      response = response.ToUpper();
      if (response == "OK")
      {
        Console.WriteLine(".");
        Thread.Sleep(250);
        Console.WriteLine(".");
        Thread.Sleep(250);
        Console.WriteLine(".");
        Thread.Sleep(250);
        Console.WriteLine("Your order will be processed. We'll notify you once it's ready. \nThanks for shopping with us!");
      }
      else if (response == "NEW")
      {
        Main();
      }
      else
      {
        Console.WriteLine("See you again!");
      }
    }
    static void ShowSpinner()
    {
      var counter = 0;
      for (int i = 0; i < 50; i++)
      {
        switch (counter % 4)
        {
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        counter++;
        Thread.Sleep(50);
      }
    }
  }
}