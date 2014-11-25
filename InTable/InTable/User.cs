using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTable
{
    class User
    {
        public List<PreferenceRanking> userPreferences = new List<PreferenceRanking>();

        public ObservableCollection<Dish> ordredSoFar = new ObservableCollection<Dish>();

        public User()
        {
            foreach (PreferenceModel model in PreferenceModel.Preferences)
            {
                userPreferences.Add(new PreferenceRanking());
            }
        }

    }
}
