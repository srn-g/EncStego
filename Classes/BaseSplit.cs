using System;
using System.Collections.Generic;
using EncStego.Interfaces;

namespace EncStego.Classes
{
    public class BaseSplit : ISplit
    {
        public string[] SplitData(DataInfo input)
        {
            long length = 0;
            Random random = new Random(DateTime.Now.Millisecond);
            var parts = new List<string>();

            while (length < input.Size)
            {
                long partSize = random.Next(4, Global.MAX_PART_SIZE_B);

                long nextPart = length + partSize;
                if (nextPart > input.Size)
                {
                    partSize = input.Size - length;

                    nextPart = length + partSize;
                }

                parts.Add(length + "-" + nextPart);

                length = nextPart;
            }

            return parts.ToArray();
        }
    }
}
