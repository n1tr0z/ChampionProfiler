using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChampionProfiler
{
    class keyConfig
    {
        public string evtCastSpell1;
        public string evtCastSpell2;
        public string evtCastSpell3;
        public string evtCastSpell4;
        public string evtCastAvatarSpell1;
        public string evtCastAvatarSpell2;
        public string evtLevelSpell1;
        public string evtLevelSpell2;
        public string evtLevelSpell3;
        public string evtLevelSpell4;
        public string evtSelfCastSpell1;
        public string evtSelfCastSpell2;
        public string evtSelfCastSpell3;
        public string evtSelfCastSpell4;
        public string evtSmartCastSpell1;
        public string evtSmartCastSpell2;
        public string evtSmartCastSpell3;
        public string evtSmartCastSpell4;
        public string evtSmartCastAvatarSpell1;
        public string evtSmartCastAvatarSpell2;

        public void getKeysfor(string who)
        {
            XmlDocument xmlDoc = new XmlDocument(); //* create an xml document object.
            xmlDoc.Load("../../SettingsResources/settings.xml");

            evtCastSpell1 = xmlDoc.SelectSingleNode("champion/" + who + "/evtCastSpell1").InnerText;
            evtCastSpell2 = xmlDoc.SelectSingleNode("champion/" + who + "/evtCastSpell2").InnerText;
            evtCastSpell3 = xmlDoc.SelectSingleNode("champion/" + who + "/evtCastSpell3").InnerText;
            evtCastSpell4 = xmlDoc.SelectSingleNode("champion/" + who + "/evtCastSpell4").InnerText;
            evtCastAvatarSpell1 = xmlDoc.SelectSingleNode("champion/" + who + "/evtCastAvatarSpell1").InnerText;
            evtCastAvatarSpell2 = xmlDoc.SelectSingleNode("champion/" + who + "/evtCastAvatarSpell2").InnerText;
            evtLevelSpell1 = xmlDoc.SelectSingleNode("champion/" + who + "/evtLevelSpell1").InnerText;
            evtLevelSpell2 = xmlDoc.SelectSingleNode("champion/" + who + "/evtLevelSpell2").InnerText;
            evtLevelSpell3 = xmlDoc.SelectSingleNode("champion/" + who + "/evtLevelSpell3").InnerText;
            evtLevelSpell4 = xmlDoc.SelectSingleNode("champion/" + who + "/evtLevelSpell4").InnerText;
            evtSelfCastSpell1 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSelfCastSpell1").InnerText;
            evtSelfCastSpell2 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSelfCastSpell2").InnerText;
            evtSelfCastSpell3 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSelfCastSpell3").InnerText;
            evtSelfCastSpell4 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSelfCastSpell4").InnerText;
            evtSmartCastSpell1 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSmartCastSpell1").InnerText;
            evtSmartCastSpell2 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSmartCastSpell2").InnerText;
            evtSmartCastSpell3 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSmartCastSpell3").InnerText;
            evtSmartCastSpell4 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSmartCastSpell4").InnerText;
            evtSmartCastAvatarSpell1 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSmartCastAvatarSpell1").InnerText;
            evtSmartCastAvatarSpell2 = xmlDoc.SelectSingleNode("champion/" + who + "/evtSmartCastAvatarSpell2").InnerText;
        }
    }

    
}
