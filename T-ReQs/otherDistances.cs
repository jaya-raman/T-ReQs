using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_ReQs
{
    class otherDistances
    {
        public static double calculateJaccard(List<string> ls1, List<string> ls2)
        {
            HashSet<string> hs1 = new HashSet<string>(ls1);
            HashSet<string> hs2 = new HashSet<string>(ls2);
            return Calc(hs1, hs2);
        }
        public static double Calc(HashSet<string> hs1, HashSet<string> hs2)
        {
            return ((double)hs1.Intersect(hs2).Count() /
               (double)hs1.Union(hs2).Count());
        }
        public static double calculateSorensenDice(List<string> ls1, List<string> ls2)
        {
            HashSet<string> hs1 = new HashSet<string>(ls1);
            HashSet<string> hs2 = new HashSet<string>(ls2);
            return CalcSorensen(hs1, hs2);
        }
        public static double CalcSorensen(HashSet<string> hs1, HashSet<string> hs2)
        {
            return ((2 * (double)hs1.Intersect(hs2).Count()) /
                        (hs1.Count() + hs2.Count()));
        }
    }
}
