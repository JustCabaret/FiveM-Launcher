using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_Launcher
{
    public class Servidor
    {
        public string EndPoint { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public int clients { get; set; }
        public string gametype { get; set; }
        public string hostname { get; set; }
        public string mapname { get; set; }
        public int sv_maxclients { get; set; }
        public bool enhancedHostSupport { get; set; }
        public string[] resources { get; set; }
        public string server { get; set; }
        public Vars vars { get; set; }
        public int selfReportedClients { get; set; }
        public Player[] players { get; set; }
        public int ownerID { get; set; }
        public bool _private { get; set; }
        public bool fallback { get; set; }
        public string[] connectEndPoints { get; set; }
        public int upvotePower { get; set; }
        public int burstPower { get; set; }
        public string support_status { get; set; }
        public int svMaxclients { get; set; }
        public string ownerName { get; set; }
        public string ownerProfile { get; set; }
        public string ownerAvatar { get; set; }
        public DateTime lastSeen { get; set; }
        public int iconVersion { get; set; }
    }

    public class Vars
    {
        public string Developer { get; set; }
        public string Discord { get; set; }
        public string ServerOwner { get; set; }
        public string banner_connecting { get; set; }
        public string banner_detail { get; set; }
        public string gamename { get; set; }
        public string locale { get; set; }
        public string onesync_enabled { get; set; }
        public string sv_enforceGameBuild { get; set; }
        public string sv_enhancedHostSupport { get; set; }
        public string sv_lan { get; set; }
        public string sv_licenseKeyToken { get; set; }
        public string sv_maxClients { get; set; }
        public string sv_projectDesc { get; set; }
        public string sv_projectName { get; set; }
        public string sv_scriptHookAllowed { get; set; }
        public string premium { get; set; }
        public string tags { get; set; }
    }

    public class Player
    {
        public string endpoint { get; set; }
        public int id { get; set; }
        public string[] identifiers { get; set; }
        public string name { get; set; }
        public int ping { get; set; }
    }
}