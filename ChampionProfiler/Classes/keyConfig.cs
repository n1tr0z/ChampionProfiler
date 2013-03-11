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
        string evtCastSpell1;
        string evtCastSpell2;
        string evtCastSpell3;
        string evtCastSpell4;
        string evtCastAvatarSpell1;
        string evtCastAvatarSpell2;
        string evtLevelSpell1;
        string evtLevelSpell2;
        string evtLevelSpell3;
        string evtLevelSpell4;
        string evtSelfCastSpell1;
        string evtSelfCastSpell2;
        string evtSelfCastSpell3;
        string evtSelfCastSpell4;
        string evtSmartCastSpell1;
        string evtSmartCastSpell2;
        string evtSmartCastSpell3;
        string evtSmartCastSpell4;
        string evtSmartCastAvatarSpell1;
        string evtSmartCastAvatarSpell2;

        public void getKeysfor(string who)
        {
            XmlDocument xmlDoc = new XmlDocument(); //* create an xml document object.
            xmlDoc.Load("settings.xml");


        }
    }

    
}
