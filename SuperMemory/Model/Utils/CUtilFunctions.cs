using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Utils
{
    class CUtilFunctions
    {
        private static CUtilFunctions inst = new CUtilFunctions();
        private CUtilFunctions() { }
        internal static CUtilFunctions Inst
        {
            get { return CUtilFunctions.inst; }
        }


        public List<CPile> genRandOrderPilesList(List<CPile> inputPiles)
        {
            Random random;
            int randIdx;
            List<CPile> outputPiles = new List<CPile>();
            List<CPile> tempPiles = new List<CPile>(inputPiles.ToArray());

            int nPilesCount = tempPiles.Count;
            for (int i = 0; i < nPilesCount; i++)
            {
                random = new Random();
                randIdx = random.Next(tempPiles.Count - 1);
                outputPiles.Add(tempPiles[randIdx]);
                tempPiles.RemoveAt(randIdx);
            }

            return outputPiles;
        }
    }
}
