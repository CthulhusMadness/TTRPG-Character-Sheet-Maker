using System;

namespace TTRPG.Data
{
    [Serializable]
    public class CharacterDnD : Character
    {
        public string race;
        public string character_class;
        public AbilityScoresDnD ability_scores;
        public Feat[] feats;
    }
}