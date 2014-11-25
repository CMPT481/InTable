using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTable
{
    class PreferenceRanking
    {
        public bool isRanking = false;

        private int _ranking;

        public int Ranking
        {
            get
            {
                return _ranking;
            }
            set
            {
                _ranking = value;
                isRanking = true;
            }
        }

        private bool _preference;

        public bool Preference
        {
            get
            {
                return _preference;
            }
            set
            {
                _preference = value;
                isRanking = false;
            }
        }
    }
}
