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

    #region D&D Characters
    [Serializable]
    public class CharacterDnD : Character
    {
        public Race race;
        public CharacterClass character_class;
        public AbilityScoresDnD ability_scores;
        public Feat[] feats;
    }


    #endregion D&D Characters
}