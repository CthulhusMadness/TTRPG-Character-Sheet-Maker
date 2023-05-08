using UnityEngine;
using TTRPG.Data;
using TTRPG.Utility;

namespace TTRPG.Managers
{
    public class MainManager : MonoBehaviour
    {
        #region Fields & Properties
        #endregion Fields & Properties

        #region UnityCallbacks
        void Start()
        {
            Initialization();
        }
        #endregion UnityCallbacks

        #region Methods
        private void Initialization()
        {
            var character = new Character();
            character.player_name = "player";
            character.character_name = "character";
            character.character_level = 1;
            CharacterUtility.SaveJsonFile(character, PathList.CharacterSheetFolder);
        }
        #endregion Methods
    }
}