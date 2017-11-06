using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisApp.Collections
{
    class ScoreCollections
    {
        public static readonly List<IScore> ScoreList = new List<IScore>()
        {
            new Love(),
            new Fifteen(),
            new Thirty(),
            new Forty(),
            new HigherThanForty()
        };
    }
}
