using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Model;


namespace PolityBot
{
    public class Filters
    {
        public static bool MsgFilter(Message msg) { 

        string[] words = msg.Text.Split(' ').ToArray();

            if (msg.Text.Length < 5 && words.Count() < 2)
                return false;

            if (msg.Text == "")
                return false;


            return true;
        }


    }
}



