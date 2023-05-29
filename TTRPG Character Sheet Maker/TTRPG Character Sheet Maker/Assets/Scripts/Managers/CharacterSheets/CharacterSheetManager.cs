using UnityEngine;
using TMPro;
using TTRPG.Data;

namespace TTRPG.Managers
{
    public class CharacterSheetManager : MonoBehaviour
    {
        #region Fields & Properties
        public Character CharacterInfo;

        [SerializeField] protected TMP_InputField playerNameField;
        [SerializeField] protected TMP_InputField charNameField;
        [SerializeField] protected TMP_InputField charLevelField;
        #endregion Fields & Properties

        #region Methods
        public virtual void SetCharacterInfo(Character character)
        {
            CharacterInfo = character;
            playerNameField.SetTextWithoutNotify(CharacterInfo.player_name);
            charNameField.SetTextWithoutNotify(CharacterInfo.character_name);
            charLevelField.SetTextWithoutNotify(CharacterInfo.character_level.ToString());
        }
        #endregion Methods
    }
}