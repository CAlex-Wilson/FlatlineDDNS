using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace FlatlineClassLibrary
{
    public class WriteConfig
    {
        /// <summary>
        ///  Method for saving a new DOMAIN setting to the configfile.xml.
        /// </summary>
        /// <param name="_userAssignedName">Name of domain given by user.</param>
        /// <param name="_userName">Username for given domain.</param>
        /// <param name="_password">Password for given domain.</param>
        /// <param name="_domain">The URL for given domain.</param>
        /// <param name="_domainProvider">URL of the API for the domain provider.</param>
        /// <param name="_enabled">Whether or not the domain is enabled and active within the program.</param>
        /// <returns>Whether a setting was successfully written to the configfile.xml.</returns>
        public static bool NewDomainSetting(string _userAssignedName, string _userName, string _password, string _domain, string _domainProvider, string _enabled)
        {
            // Load existing XML config and add a new setting. 
            XDocument xDoc = XDocument.Load("configfile.xml");
            XElement xEle = XElement.Load("configfile.xml");

            // Check if the the unique userAssignedName already exists within the configfile.xml.
            bool exists = xDoc.Element("Settings").Element("SavedDomains").Elements("UserAssignedName").Attributes("id").Any(att => att.Value == _userAssignedName);

            if (exists == false)
            {
                //Add the new setting into the configfile.xml, as long as the ID is unique.
                xEle.Elements("SavedDomains").FirstOrDefault().Add(new XElement("UserAssignedName",
                new XAttribute("id", _userAssignedName),
                new XElement("Username", new XAttribute("value", _userName)),
                new XElement("Password", new XAttribute("value", _password)),
                new XElement("Domain", new XAttribute("value", _domain)),
                new XElement("DomainProvider", new XAttribute("value", _domainProvider)),
                new XElement("Enabled", new XAttribute("value", _enabled))));
                //Save the file after edit.
                xEle.Save("configfile.xml");

                //Return true if the operation was successful.
                return true;
            }
            else
            {
                //Return false if the operation failed.
                return false;
            }
        }

        /// <summary>
        /// Method for editing an already exsisting domain entry within the configfile.xml.
        /// </summary>
        /// <param name="_userAssignedName">Name of domain given by user.</param>
        /// <param name="_userName">Username for given domain.</param>
        /// <param name="_password">Password for given domain.</param>
        /// <param name="_domain">The URL for given domain.</param>
        /// <param name="_domainProvider">URL of the API for the domain provider.</param>
        /// <param name="_enabled">Whether or not the domain is enabled and active within the program.</param>
        public static void UpdateDomainSetting(string _userAssignedName, string _userName, string _password, string _domain, string _domainProvider, string _enabled)
        {
            // Load existing XML config and add a new setting. 
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("configfile.xml");

            //Update the info for all the domain settings.
            foreach (XmlNode node in xDoc.SelectNodes("//SavedDomains/UserAssignedName[@id='" + _userAssignedName + "']/Username"))
            {
                node.Attributes["value"].Value = _userName;
            }
            foreach (XmlNode node in xDoc.SelectNodes("//SavedDomains/UserAssignedName[@id='" + _userAssignedName + "']/Password"))
            {
                node.Attributes["value"].Value = _password;
            }
            foreach (XmlNode node in xDoc.SelectNodes("//SavedDomains/UserAssignedName[@id='" + _userAssignedName + "']/Domain"))
            {
                node.Attributes["value"].Value = _domain;
            }
            foreach (XmlNode node in xDoc.SelectNodes("//SavedDomains/UserAssignedName[@id='" + _userAssignedName + "']/DomainProvider"))
            {
                node.Attributes["value"].Value = _domainProvider;
            }
            foreach (XmlNode node in xDoc.SelectNodes("//SavedDomains/UserAssignedName[@id='" + _userAssignedName + "']/Enabled"))
            {
                node.Attributes["value"].Value = _enabled;
            }

            //Save changes made to the xml file.
            xDoc.Save("configfile.xml");
        }

        /// <summary>
        /// Method for removing an entry from the configfile.xml.
        /// </summary>
        /// <param name="_userAssignedName">The name given by the user for the given setting. What is displayed within the program.</param>
        public static void RemoveDomainSetting(string _userAssignedName)
        {
            XDocument xDoc = XDocument.Load("configfile.xml");

            var elementToRemove = from element in xDoc.Descendants() where (string)element.Attribute("id") == _userAssignedName select element;

            elementToRemove.Remove();

            xDoc.Save("configfile.xml");
        }

        /// <summary>
        /// Method for creating a new configfile.xml.
        /// </summary>
        /// <param name="_userAssignedName">Name of domain given by user.</param>
        /// <param name="_userName">Username for given domain.</param>
        /// <param name="_password">Password for given domain.</param>
        /// <param name="_domain">The URL for given domain.</param>
        /// <param name="_domainProvider">URL of the API for the domain provider.</param>
        /// <param name="_enabled">Whether or not the domain is enabled and active within the program.</param>
        public static void CreateXMLConfigFile()
        {
            XmlTextWriter xwriter = new XmlTextWriter("configfile.xml", Encoding.UTF8);
            xwriter.WriteStartDocument();

            //Make the config file more readable.
            xwriter.Formatting = Formatting.Indented;

            //Create the enclosing element.
            xwriter.WriteStartElement("Settings");

            //Create the enclosing element.
            xwriter.WriteStartElement("SavedDomains");

            xwriter.WriteEndElement(); //Close SavedDomains element.
            xwriter.WriteEndElement(); //Close settings element.

            xwriter.WriteEndDocument(); //End document.
            xwriter.Close(); //close stream.
        }
    }


}
