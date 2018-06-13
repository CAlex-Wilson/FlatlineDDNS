using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace FlatlineClassLibrary
{
    public class ReadConfig
    {
        /// <summary>
        /// Method for reading domain settings from the configfile.xml into an object list that the program can use.
        /// </summary>
        /// <returns>A list of domain setting objects.</returns>
        public static List<DomainSettingModel> ReadDomainSetting()
        {
            //Load the config file.
            XDocument xDoc = XDocument.Load("configfile.xml");

            //Declare a list of domain setting objects that will be populated by the LINQ operation.
            List<DomainSettingModel> returnList = new List<DomainSettingModel>();
            
            //Use LINQ to store the configfile.xml info into a temporary IEnumerable collection of domain settings.
            IEnumerable<DomainSettingModel> result = from c in xDoc.Descendants("UserAssignedName")
                                                  select new DomainSettingModel()
                                                  {
                                                      UserAssignedName = (string)c.Attribute("id").Value,
                                                      Username = (string)c.Element("Username").Attribute("value").Value,
                                                      Password = (string)c.Element("Password").Attribute("value").Value,
                                                      Domain = (string)c.Element("Domain").Attribute("value").Value,
                                                      DomainProvider = (string)c.Element("DomainProvider").Attribute("value").Value,
                                                      Enabled = (string)c.Element("Enabled").Attribute("value").Value,
                                                  };

            //Transfer the IEnumerable objects to the list of domain setting objects declared above.
            foreach (var r in result)
            {
                returnList.Add(r);
            }

            //Return the list generated.
            return returnList;
        }
    }
}
