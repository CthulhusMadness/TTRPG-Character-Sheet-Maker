using System;

namespace TTRPG.Data
{
    [Serializable]
    public class Character
    {
        public string player_name;
        public string character_name;
        public int character_level;
        public Equipment equipment;
        public Description description;
    }
}