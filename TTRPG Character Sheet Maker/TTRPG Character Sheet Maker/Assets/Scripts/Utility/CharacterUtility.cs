using System.IO;
using UnityEngine;
using TTRPG.Data;

namespace TTRPG.Utility
{
    public static class CharacterUtility
    {
        public static string[] GetJsonFilesFromFolder(string folderPath)
            => Directory.GetFiles(folderPath, "*.json");
        public static void SaveJsonFile<T>(T character, string folderPath) where T : Character
        {
            var json = JsonUtility.ToJson(character, true);
            var filePath = $"{folderPath}{character.character_name}.json";
            File.WriteAllText(filePath, json);
        }
    }
}