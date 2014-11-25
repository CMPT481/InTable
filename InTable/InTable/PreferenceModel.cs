using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTable
{
    public enum PreferenceTypes { SCALE, BOOLEAN }

    class PreferenceModel
    {
        public static List<PreferenceModel> Preferences = new List<PreferenceModel>() {
            new PreferenceModel()
            {
                Type = PreferenceTypes.SCALE,
                ShortDescription = "SweetSalty",
                LongDescription = "Do you prefer sweet foods, or salty foods?",
                LeftOption = "Sweet",
                RightOption = "Salty"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.SCALE,
                ShortDescription = "MildSpicy",
                LongDescription = "Do you prefer mild foods, or spicy foods?",
                LeftOption = "Mild",
                RightOption = "Spicy"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.SCALE,
                ShortDescription = "VeggieMeat",
                LongDescription = "Do you prefer vegetable based foods, or meat based foods?",
                LeftOption = "Vegetable",
                RightOption = "Meat"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.SCALE,
                ShortDescription = "LightRich",
                LongDescription = "Do you prefer light foods, or rich foods?",
                LeftOption = "Light",
                RightOption = "Rich"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.SCALE,
                ShortDescription = "SmallLarge",
                LongDescription = "Do you prefer smaller dishes, or larger ones?",
                LeftOption = "Smaller",
                RightOption = "Larger"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.BOOLEAN,
                ShortDescription = "Vegetarian",
                LongDescription = "Are you vegetarian?",
                LeftOption = "No",
                RightOption = "Yes"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.BOOLEAN,
                ShortDescription = "Vegan",
                LongDescription = "Are you vegan?",
                LeftOption = "No",
                RightOption = "Yes"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.BOOLEAN,
                ShortDescription = "Gluten",
                LongDescription = "Do you have gluten allergies?",
                LeftOption = "No",
                RightOption = "Yes"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.BOOLEAN,
                ShortDescription = "Dairy",
                LongDescription = "Do you have dairy allergies?",
                LeftOption = "No",
                RightOption = "Yes"
            },
            new PreferenceModel()
            {
                Type = PreferenceTypes.BOOLEAN,
                ShortDescription = "Soy",
                LongDescription = "Do you have soy allergies?",
                LeftOption = "No",
                RightOption = "Yes"
            }
        };

        public PreferenceTypes Type
        {
            get;
            set;
        }

        public string ShortDescription
        {
            get;
            set;
        }

        public string LongDescription
        {
            get;
            set;
        }

        public string LeftOption
        {
            get;
            set;
        }

        public string RightOption
        {
            get;
            set;
        }

        public bool isScale
        {
            get
            {
                return Type == PreferenceTypes.SCALE;
            }
        }

        public bool isBoolean
        {
            get
            {
                return Type == PreferenceTypes.BOOLEAN;
            }
        }
    }
}
