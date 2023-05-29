using UnityEngine;
using TMPro;
using TTRPG.Data;
using TTRPG.UI;

namespace TTRPG.Managers
{
    public class DnDSheetManager : CharacterSheetManager
    {
        #region Fields & Properties
        [SerializeField] protected TMP_InputField classField;
        [SerializeField] protected TMP_InputField raceField;
        [SerializeField] protected AbilityScoresDnDManager abilityScores;
        [SerializeField] protected FeatsManager feats;
        #endregion Fields & Properties

        #region Methods
        public override void SetCharacterInfo(Character character)
        {
            var currentCharacter = (CharacterDnD)character;
            base.SetCharacterInfo(currentCharacter);
            classField.SetTextWithoutNotify(currentCharacter.character_class);
            raceField.SetTextWithoutNotify(currentCharacter.race);
            abilityScores.SetAbilityScores(currentCharacter.ability_scores);
            feats.SetFeats(currentCharacter.feats);
        }
        #endregion Methods
    }
}