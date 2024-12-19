using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] random_unicode_array = new string[18]
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
        
        for (int i = 0; i < random_unicode_array.Length; i++)
        {
            string current_unicode = random_unicode_array[i];
            current_unicode.ToLower();
            Console.WriteLine(current_unicode);
        };

        }
    }
}
