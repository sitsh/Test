using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolHelp.Extension
{
    public static class ExtString
    {
        public static string ToMiniImgUrl(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            return str.Replace("original", "mini");
        }
        public static string ToMicroImgUrl(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            return str.Replace("original", "micro");
        }
        public static string ToShortTitle(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            return str.Substring(0, 40)+"...";
        }
    }
}
