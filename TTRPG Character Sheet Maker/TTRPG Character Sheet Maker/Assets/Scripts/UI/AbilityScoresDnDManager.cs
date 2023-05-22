using TTRPG.Data;
using TTRPG.UI.Fields;
using UnityEngine;

namespace TTRPG.UI
{
    public class AbilityScoresDnDManager : AbilityScoresManager
    {
        #region Fields
        [SerializeField] protected AbilityScoreDnDField strength;
        [SerializeField] protected AbilityScoreDnDField dexterity;
        [SerializeField] protected AbilityScoreDnDField constitution;
        [SerializeField] protected AbilityScoreDnDField intelligence;
        [SerializeField] protected AbilityScoreDnDField wisdom;
        [SerializeField] protected AbilityScoreDnDField charisma;

        #endregion Fields

        #region Methods
        public override void SetAbilityScores(AbilityScores scores)
        {
            AbilityScoresDnD dndScores = (AbilityScoresDnD)scores;
            strength.SetAbilityScore(dndScores.strength.score);
            dexterity.SetAbilityScore(dndScores.dexterity.score);
            constitution.SetAbilityScore(dndScores.constitution.score);
            intelligence.SetAbilityScore(dndScores.intelligence.score);
            wisdom.SetAbilityScore(dndScores.wisdom.score);
            charisma.SetAbilityScore(dndScores.charisma.score);
        }
        #endregion Methods
    }
}
