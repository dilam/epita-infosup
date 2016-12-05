using System;
using System.Collections.Generic;

namespace Cracking
{
    public class UQhxntDq29
    {
        public static bool nSsPAHix2q(string metfPztc2V, Queue<int> idDq4LDtHu)
        {
            int Bi97ibFdQM = 0;
            for (; Bi97ibFdQM < Dg83n38U97.KgK5tAvxp1(metfPztc2V) && idDq4LDtHu.Count > 0; ++Bi97ibFdQM)
            {
                char L4rQOxu90X = (char)idDq4LDtHu.Dequeue();
                if (metfPztc2V[Bi97ibFdQM] != L4rQOxu90X)
                    return false;
            }
            return Bi97ibFdQM == Dg83n38U97.KgK5tAvxp1(metfPztc2V) && idDq4LDtHu.Count == 0;
        }

        public static bool daJ81FdZen(int L4rQOxu90X)=> L4rQOxu90X >= 97 && L4rQOxu90X <= 122;

        public static int JlDPGllTa3() { return 451; }
    }
}

