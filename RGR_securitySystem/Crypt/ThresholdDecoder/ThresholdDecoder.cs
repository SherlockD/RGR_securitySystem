using System.Collections.Generic;
using System.Linq;

namespace RGR_securitySystem.Crypt.ThresholdDecoder
{
    public class ThresholdDecoder
    {
        public List<byte> Encode(byte[] message)
        {
            List<byte> testBranch = new List<byte>(message.Length);
            var messageBuffer = message.ToList();
            
            testBranch.AddRange(message);
            
            //testBranch.Add(message[0]);

            for (int i = 0; i < message.Length; i++)
            {
                messageBuffer.TurnRight();
                
                testBranch.Add
                (
                    Extensions.XOR(messageBuffer[0], messageBuffer[1], messageBuffer[4], messageBuffer[6])    
                );
            }

            return testBranch;
        }

        /*public List<byte> Decode(byte[] message)
        {
            List<byte> syndromRegister = new List<byte>();
            
        }*/
    }
}