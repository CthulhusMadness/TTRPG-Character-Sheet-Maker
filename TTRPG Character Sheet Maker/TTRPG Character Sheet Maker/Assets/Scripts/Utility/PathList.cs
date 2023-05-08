using System.IO;
using UnityEngine;

namespace TTRPG.Utility
{
    public static class PathList
    {
        private static string persistentDataPath => Application.persistentDataPath;
        public static string CharacterSheetFolder => CreateFolderIfNotExists($"{persistentDataPath}/CharacterSheets/");
        public static string DnDSheetFolder => CreateFolderIfNotExists($"{CharacterSheetFolder}DnD/");

        private static string CreateFolderIfNotExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
        }
    }
}