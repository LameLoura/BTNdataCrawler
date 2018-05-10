using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getData.objcects
{
    [Serializable]
    public class CharacterFavourite
    {
        public string characterLink { get; set; }
        public string LovedItem { get; set; }
        public string LikedItem { get; set; }
        public string NauturalItem { get; set; }
        public string DislikedItem { get; set; }
        public  string HatedItem { get; set; }
        public string ElseItem { get; set; }
        // just in case of (de)serializaion
        public CharacterFavourite()
        {

            //List<string> LovedItem = new List<string>();
            //List<string> LikedItem = new List<string>();
            //List<string> NauturalItem = new List<string>();
            //List<string> DislikedItem = new List<string>();
            //List<string> HatedItem = new List<string>();
        }


    }
}
