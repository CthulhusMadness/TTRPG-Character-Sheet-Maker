using UnityEngine;
using TTRPG.Data;
using TTRPG.Other;
using TTRPG.Utility;

namespace TTRPG.Managers
{
    public class MainManager : MonoBehaviour
    {
        #region Fields & Properties
        [SerializeField] private Context context;
        #endregion Fields & Properties

        #region UnityCallbacks
        void Start()
        {
            Initialize();
        }
        #endregion UnityCallbacks

        #region Methods
        private void Initialize()
        {
            var newCharacter = CreateCharacter();
            context.CurrentCharacterSheet.SetCharacterInfo(newCharacter);
        }

        private Character CreateCharacter()
        {
            var character = new Character();
            character.player_name = "player";
            character.character_name = "character";
            character.character_level = 1;
            CharacterUtility.SaveJsonFile(character, PathList.CharacterSheetFolder);
            return character;
        }
        #endregion Methods
    }
}