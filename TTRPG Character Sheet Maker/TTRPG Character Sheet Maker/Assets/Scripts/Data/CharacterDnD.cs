using System;

namespace TTRPG.Data
{
    [Serializable]
    public class CharacterDnD : Character
    {
        public Race race;
        public CharacterClass character_class;
        public AbilityScoresDnD ability_scores;
        public Feat[] feats;
    }
}