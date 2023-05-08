using System;

namespace TTRPG.Data
{
    [Serializable]
    abstract public class AbilityScores
    {
    }

    [Serializable]
    public class AbilityScoresDnD : AbilityScores
    {
        public AbilityScoreDnD strength;
        public AbilityScoreDnD dexterity;
        public AbilityScoreDnD constitution;
        public AbilityScoreDnD intelligence;
        public AbilityScoreDnD wisdom;
        public AbilityScoreDnD charisma;
    }
}