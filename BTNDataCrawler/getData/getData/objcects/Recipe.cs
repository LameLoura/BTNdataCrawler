using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getData.objcects
{
    [Serializable]
    public class Recipe
    {
        public string Origin { get; set; }
        public string RecipeName {get;set;}
        public string Stamina { get; set; }
        public string RequiredUtensils { get; set; }
        public string RequiredIngredients { get; set; }
        public string RequiredSeasoning { get; set; }
        public string OptionalUtensils { get; set; }
        public string OptionalIngredients { get; set; }
        public string OptionalSeasoning { get; set; }

        //constructor for serialization
        public Recipe()
        {
        }
    }
}
