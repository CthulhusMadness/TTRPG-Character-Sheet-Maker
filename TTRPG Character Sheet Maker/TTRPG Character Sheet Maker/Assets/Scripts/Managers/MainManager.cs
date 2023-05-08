using UnityEngine;
using TTRPG.Data;
using TTRPG.Other;
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
            character.character_name = "0";
            var json = JsonUtility.ToJson(character);
            CharacterUtility.SaveJsonFile(character, PathList.CharacterSheetFolder);
        }
        #endregion Methods
    }
}