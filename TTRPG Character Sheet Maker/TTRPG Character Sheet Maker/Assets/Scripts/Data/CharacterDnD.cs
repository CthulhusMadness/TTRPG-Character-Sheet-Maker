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

        public CharacterDnD() { }
        public CharacterDnD(string playerName, string characterName, int characterLevel, string race, string character_class, AbilityScoresDnD ability_scores, Feat[] feats)
            : base(playerName, characterName, characterLevel)
        {
            this.race = race;
            this.character_class = character_class;
            this.ability_scores = ability_scores;
            this.feats = feats;
        }
    }
}