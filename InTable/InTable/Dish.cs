using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTable
{
    class Dish
    {
        public List<PreferenceRanking> dishPreferences;

        public string Name
        {
            set;
            get;
        }

        public string Description
        {
            set;
            get;
        }

        #region Apps
        public static List<Dish> Apps = new List<Dish>()
        {
            new Dish()
            {
                Name = "Poutine",
                Description = "Delicious fries with fresh cheese and homemade gravy",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 10
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 4
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 10
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 10
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = false
                    }
                }
            },
            new Dish()
            {
                Name = "Nachos",
                Description = "Hot nachos with green peppers, salsa, jalapeños, sour cream, onions, and our five cheese blend",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 4
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 10
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 10
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = false
                    }
                }
            },
            new Dish()
            {
                Name = "Wings",
                Description = "Chicken wings in a sauce of your choice",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 10
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Potato Skins",
                Description = "Cripsy seassoned potato skins with our homemade bbq dipping sauce",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 3
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 6
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Blooming Onion",
                Description = "Fresh onion with delicious seasoning cooked to golden perfection",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 2
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            }
        };
        #endregion

        #region Mains
        public static List<Dish> Mains = new List<Dish>()
        {
            new Dish()
            {
                Name = "Mushroom Chicken",
                Description = "Two pesto marinated chicken breasts topped with a creamy wild mushroom, grilled onion, and sundried tomato sauce.  Served with rice and seasoned veggeis.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 6
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Goat Cheese Penne",
                Description = "Broccoli, peppers, red onion and mushrooms tossed with penne in a goat cheese, tomato, and roasted red pepper sace, served with garlic bread.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 3
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 4
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 4
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Chicken Tacos",
                Description = "Two soft shell tacos, jam packed with tender grilled chicken, Cheddar cheese, crisp lettuce, red onions, diced tomatoes, scripsy tortilla strips, fresh cilantro, lime juice, and drizzed with taco sauce,",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 9
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 4
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 3
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Apple Pecan Harvest Salad",
                Description = "Goat cheese, red pepper strips, spicy glazed pecans, fresh apple slices and dried cranberries on a bed of mixed field greens.  Served with balsamic vinaigrette.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 3
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 2
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 3
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 3
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Steakhouse Pork Ribs",
                Description = "Our famous pork ribs are rubbed, smoked, basted, and grilled to finger licking perfection.  Served with your choice of signature BBQ sauce.  Served with corn of coleslaw.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 6
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = false
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            }
        };
        #endregion

        #region Desserts
        public static List<Dish> Desserts = new List<Dish>()
        {
            new Dish()
            {
                Name = "Apple Cobbler",
                Description = "Freshly baked apples with cinnamon, brown sugar and crunchy oatmeal crumble.  Topped with a blueberry apple sauce and vanilla ice cream.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Pineapple Upside Down Cake",
                Description = "A decadent, buttery white cake with a caramelized pineapple slice served with whipped cream, Maple Whiskey Caramel sauce, and of course, a cherry on top.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Decadent Tortilla Cheesecake",
                Description = "Creamy cheesecake wrapped in a crispy flour tortilla and topped with whipped cream and icing sugar.  With chocolate of caramel sauce.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Chocolate Cake",
                Description = "Four layers of chocolate cake and fudgy frosting, drizzled with a buttery banana sauce and topped with dark chocolate shavings and whipped cream.  It's a dream come true.  A sweet, sweet, chocolately banana-y, dream come true.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Mini Donuts",
                Description = "Go to your happy place with eight warm mini donuts made fresh to order and tossed in powdered sugar right before your eyes",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 7
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 8
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            }
        };
        #endregion

        #region Cold
        public static List<Dish> Cold = new List<Dish>()
        {
            new Dish()
            {
                Name = "Coca-cola",
                Description = "A glass of Coca-cola on ice.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Sprite",
                Description = "A glass of Sprite on ice.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Orange Juice",
                Description = "A glass of Orange Juice.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Apple Juice",
                Description = "A glass of Apple Juice.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Chocolate Milk",
                Description = "A glass of Chocolate Milk.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            }
        };
        #endregion

        #region Hot
        public static List<Dish> Hot = new List<Dish>()
        {
            new Dish()
            {
                Name = "Coffee",
                Description = "A steaming cup of hot coffee.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Green Tea",
                Description = "A steaming cup of hot green tea.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Black tea",
                Description = "A hot cup of black tea, great in the morning or anytime.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Apple Cider",
                Description = "A hot glass of apple cider.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Hot chocolate",
                Description = "A large mug of hot chocolate with cinnamon and mini-marshmallows.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            }
        };
        #endregion

        #region Alchoholic
        public static List<Dish> Alchoholic = new List<Dish>()
        {
            new Dish()
            {
                Name = "Budweiser",
                Description = "A cold draught beer to go with a warm meal.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Late Afternoon Lemonade",
                Description = "A light and refreshing blend of 1 oz Smirnoff Rasberry Vodka, strawberry mix, and 7Up.  Garnished with a lemon wedge.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Long Island Iced Tea",
                Description = "1.5 oz McGuiness Long Island Iced Tea with lemon mix and Pepsi.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Spicy Lima-Rita",
                Description = "1.5 oz of Jose Cuervo tequila shaken with Habanero Lima syrup and classic Margarite mix, topped with two jalapenos.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            },
            new Dish()
            {
                Name = "Blended Mojito",
                Description = "A unique blended twist on the classic mojito.  2 oz Captain Morgan White Rum, lime, and Mojito mix, garnished with a lime.",
                dishPreferences = new List<PreferenceRanking>()
                {
                    new PreferenceRanking() //SweetSalty
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //MildSpicy
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //VeggieMeat
                    {
                        Ranking = 1
                    },
                    new PreferenceRanking() //LightRich
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //SmallLarge
                    {
                        Ranking = 5
                    },
                    new PreferenceRanking() //isVegetarian
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isVegan
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isGlutenFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isDairyFree
                    {
                        Preference = true
                    },
                    new PreferenceRanking() //isSoyFree
                    {
                        Preference = true
                    }
                }
            }
        };
        #endregion
    }
}
