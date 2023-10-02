using System;

namespace TTRPG.Data
{
    [Serializable]
    public class AbilityScoresDnD : AbilityScores
    {
        public AbilityScoreDnD strength;
        public AbilityScoreDnD dexterity;
        public AbilityScoreDnD constitution;
        public AbilityScoreDnD intelligence;
        public AbilityScoreDnD wisdom;
        public AbilityScoreDnD charisma;

        public AbilityScoresDnD(int str, int dex, int con, int intell, int wis, int cha)
        {
            strength = new AbilityScoreDnD(str);
            dexterity = new AbilityScoreDnD(dex);
            constitution = new AbilityScoreDnD(con);
            intelligence = new AbilityScoreDnD(intell);
            wisdom = new AbilityScoreDnD(wis);
            charisma = new AbilityScoreDnD(cha);
        }
    }
}