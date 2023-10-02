using UnityEngine;
using TMPro;
using TTRPG.Data;
using TTRPG.UI.Panels;

namespace TTRPG.Managers
{
    public class DnDSheetManager : CharacterSheetManager
    {
        #region Fields & Properties
        [SerializeField] protected TMP_InputField classField;
        [SerializeField] protected TMP_InputField raceField;
        [SerializeField] protected AbilityScoresDnDPanel abilityScores;
        [SerializeField] protected FeatsPanel feats;
        [SerializeField] protected HPPanel hpPanel;
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
            hpPanel.Initialize(currentCharacter.vitals);
        }
        #endregion Methods
    }
}