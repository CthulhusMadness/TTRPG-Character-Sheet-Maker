using UnityEngine;
using TTRPG.UI;
using TTRPG.Data;
using TTRPG.Other;
using TTRPG.Utility;

namespace TTRPG.Managers
{
    public class MainManager : Singleton<MainManager>
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
            context.CurrentCharacterSheet.SetCharacterInfo((CharacterDnD)newCharacter);
        }

        private CharacterDnD CreateCharacter()
        {
            var character = new CharacterDnD(
                "player",
                "character",
                1,
                "human",
                "warrior",
                new AbilityScoresDnD(18, 14, 16, 9, 11, 13),
                new Feat[]
                    {
                        new Feat("Feat 1", "Book 1", "This is my first feat." ),
                        new Feat("Feat 2", "Book 1", "Wow! this feat is cool." ),
                        new Feat("Feat 3", "Book 2", "This is kinda interesting." ),
                        new Feat("Feat 4", "Book 2", "blablabla 1." ),
                        new Feat("Feat 5", "Book 1", "blablabla 2." ),
                        new Feat("Feat 6", "Book 3", "blablabla 3." ),
                        new Feat("Feat 7", "Book 3", "blablabla 4." ),
                        new Feat("Feat 8", "Book 1", "blablabla 5." ),
                        new Feat("Feat 9", "Book 1", "blablabla 6." ),
                        new Feat("Feat 10", "Book 2", "blablabla 7." ),
                        new Feat("Feat 11", "Book 3", "blablabla 8." ),
                        new Feat("Feat 12", "Book 1", "blablabla 9." ),
                    },
                new VitalsDnD(30, 30)
                );
            CharacterUtility.SaveJsonFile(character, PathList.DnDSheetFolder);
            return character;
        }

        public T GetUIManager<T>() where T : UIManager
            => (T)context.UIManager;
        #endregion Methods
    }
}