using System;
using System.Linq;
using UnityEngine;

namespace BhjikmnBGYUik
{
    public static class nmjuytrfb
    {
        public static string zxfrterth(int po76tgv)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            if (po76tgv > 999999999)
                return ">1B";
            if (po76tgv > 999999)
                return $"{po76tgv / 1000000},{po76tgv / 100000 % 10}M";
            if (po76tgv > 999)
                return $"{po76tgv / 1000},{po76tgv / 100 % 10:D1}K";

            return $"{po76tgv}";
        }

        public static string nyterfse(int bgrec)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            return $"{bgrec / 60:D2}:{bgrec % 60:D2}";
        }
    }
}