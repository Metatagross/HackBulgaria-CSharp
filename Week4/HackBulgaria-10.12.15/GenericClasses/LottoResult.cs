using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class LottoResult<T, U>
    {
        private bool isWinning;
        private byte matchedNumbersCount;

        public bool IsWinning { get { return isWinning; } }
        public byte MatchedNumbersCount { get { return matchedNumbersCount; } }

        public LottoResult ( )
        {
            isWinning = false;
            matchedNumbersCount = 0;
        }

        public LottoResult ( Combination<T , U> combinationToCheck , Combination<T , U> winningCombination )
        {
            matchedNumbersCount = 0;
            if(combinationToCheck.Equals(winningCombination))
            {
                isWinning = true;
                matchedNumbersCount = 6;
            }
        }
    }
}
