using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace RGR_securitySystem
{
    public static class Extensions
    {
        public static void TurnRight(this List<byte> owner)
        {
            owner.Insert(0, owner[owner.Count - 1]);
            owner.RemoveAt(owner.Count - 1);
        }
        
        public static void TurnLeft(this List<byte> owner)
        {
            owner.Add(owner.First());
            owner.Remove(owner.First());
        }

        public static byte XOR(byte one, byte two, byte three, byte four)
        {
            byte result;
            result = XOR(one, two);
            result = XOR(result, three);
            result = XOR(result, four);

            return result;
        }

        public static byte XOR(byte left, byte right)
        {
            return (byte) ((left == 0 && right == 0 || left == 1 && right == 1) ? 0 : 1);
        }
    }
}