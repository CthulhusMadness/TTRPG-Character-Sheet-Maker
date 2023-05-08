using UnityEngine;
using TMPro;
using TTRPG.Data;

namespace TTRPG.Managers
{
    public class CharacterSheetManager : MonoBehaviour
    {
        public Character CharacterInfo;

        #region Fields & Properties
        [SerializeField] private TMP_InputField playerNameField;
        [SerializeField] private TMP_InputField charNameField;
        [SerializeField] private TMP_InputField charLevelField;
        #endregion Fields & Properties

        public virtual void SetCharacterInfo(Character character)
        {
            CharacterInfo = character;
            playerNameField.SetTextWithoutNotify(CharacterInfo.player_name);
            charNameField.SetTextWithoutNotify(CharacterInfo.character_name);
            charLevelField.SetTextWithoutNotify(CharacterInfo.character_level.ToString());
        }
    }
}