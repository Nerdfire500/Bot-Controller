// Decompiled with JetBrains decompiler
// Type: ns0.potential_encryption_class
// Assembly: controller, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FF7CF129-2948-4A0A-A74D-7CD827321044
// Assembly location: C:\Users\blang\Documents\BillsCoursework\cw_2024_2025\c-cleaned.exe

using System;

#nullable disable
namespace ns0
{
  public class potential_encryption_class
  {
    public string method_0(string string_0, string string_1, int int_0)
    {
      int index = 0;
      string str = "";
      string_0 = string_0.ToUpper();
      string_1 = string_1.ToUpper();
      foreach (char ch in string_0)
      {
        if (ch >= 'A')
        {
          int num = (int) ch - 65 + int_0 * ((int) string_1[index] - 65);
          if (num < 0)
            num += 26;
          str += (string) (object) Convert.ToChar(65 + num % 26);
          if (++index == string_1.Length)
            index = 0;
        }
      }
      return str;
    }
  }
}
