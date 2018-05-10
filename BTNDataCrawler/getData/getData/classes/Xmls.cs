using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using getData.objcects;
using System.Xml;

namespace getData.classes
{
    public class Xmls
    {
        //public static string WriteXML(List<Character> input)
        public static string WriteXML(object input)
        {


            XmlSerializer xmlSerializer = new XmlSerializer(input.GetType());
            StringWriter textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, input);
            return textWriter.ToString();
        }

        public static List<Character> DeserializeObject(string filename)
        {
            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new
            XmlSerializer(typeof(List<Character>));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            // Declare an object variable of the type to be deserialized.
            List<Character> answer;

            // Use the Deserialize method to restore the object's state.
            answer = (List<Character>)serializer.Deserialize(reader);
            fs.Close();
            return answer;

   
        }


        public static List<CharacterFavourite> DeserializeCharaFav(string filename)
        {
            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new
            XmlSerializer(typeof(List<CharacterFavourite>));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            // Declare an object variable of the type to be deserialized.
            List<CharacterFavourite> answer;

            // Use the Deserialize method to restore the object's state.
            answer = (List<CharacterFavourite>)serializer.Deserialize(reader);
            fs.Close();
            return answer;


        }

        public static List<Recipe> DeserializeRecipe(string filename)
        {
            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new
            XmlSerializer(typeof(List<Recipe>));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            // Declare an object variable of the type to be deserialized.
            List<Recipe> answer;

            // Use the Deserialize method to restore the object's state.
            answer = (List<Recipe>)serializer.Deserialize(reader);
            fs.Close();
            return answer;


        }


    }
}
