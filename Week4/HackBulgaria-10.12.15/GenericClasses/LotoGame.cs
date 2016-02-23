using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class LottoGame<T, U>
    {
        private List<Combination<T , U>> allCombinations;
        private readonly Combination<T , U> winning;
        public LottoGame ( Combination<T , U> winMe )
        {
            winning = winMe;
            allCombinations = new List<Combination<T , U>>();
        }

        public bool AddUserCombination ( Combination<T , U> userCombination )
        {
            foreach(var combination in allCombinations)
            {
                if(combination.Equals(userCombination)) return false;
            }

            allCombinations.Add(userCombination);
            return true;

        }

        private Combination<T , U> GetWinningCombination ( )
        {
            return winning;
        }

        public LottoResult<T , U> Validate ( )
        {
            LottoResult<T , U> bestLottoResult = new LottoResult<T , U>();
            foreach(var combination in allCombinations)
            {
                var curLottoResult = new LottoResult<T , U>(combination , winning);
                if(bestLottoResult.MatchedNumbersCount < curLottoResult.MatchedNumbersCount) bestLottoResult = curLottoResult;
            }
            return bestLottoResult;
        }
    }
    public class Combination<T, U> : ICombination<T , U>
    {
        private readonly T a1;
        private readonly T a2;
        private readonly T a3;
        private readonly U b1;
        private readonly U b2;
        private readonly U b3;
        public Combination ( T a1 , T a2 , T a3 , U b1 , U b2 , U b3 )
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }

        public T A1
        {
            get
            {
                return a1;
            }
        }

        public T A2
        {
            get
            {
                return a2;
            }
        }

        public T A3
        {
            get
            {
                return a3;
            }
        }

        public U B1
        {
            get
            {
                return b1;
            }
        }

        public U B2
        {
            get
            {
                return b2;
            }
        }

        public U B3
        {
            get
            {
                return b3;
            }
        }

        public override bool Equals ( object obj )
        {
            if(obj is Combination<T , U>)
            {
                Combination<T , U> newObj = (Combination<T , U>)obj;
                return newObj.a1.GetType().Equals(a1.GetType()) &&
                       newObj.a2.GetType().Equals(a2.GetType()) &&
                       newObj.a3.GetType().Equals(a3.GetType()) &&
                       newObj.b1.GetType().Equals(b1.GetType()) &&
                       newObj.b2.GetType().Equals(b2.GetType()) &&
                       newObj.b3.GetType().Equals(b3.GetType());
            }
            return false;
        }
        public override int GetHashCode ( )
        {
            return 3 * (a1.GetHashCode() + b1.GetHashCode());
        }
    }

}
