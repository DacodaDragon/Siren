using System.IO;
using UnityEditor;
using UnityEngine;

namespace Siren.Utilities.Editor
{
    public static class AssetUtil
    {
        private const string EXTENSION = ".asset"; 

        public static T CreateAt<T>(string path, string assetName) where T : ScriptableObject
        {
            CreateDirectoryPathIfapplicable(path);
            return CreateAt<T>(path + assetName + EXTENSION);
        }

        private static T CreateAt<T>(string path) where T : ScriptableObject
        {
            Debug.Log(path);
            T asset = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(asset, path);
            AssetDatabase.Refresh();
            return asset;
        }

        public static T CreateUnique<T>(string path, string assetname) where T : ScriptableObject
        {
            string uniquePath = AssetDatabase.GenerateUniqueAssetPath(path + assetname + EXTENSION);
            return CreateAt<T>(uniquePath);
        }

        private static void CreateDirectoryPathIfapplicable(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static bool Exists(string path, string assetName)
        {
            return File.Exists(path + assetName + EXTENSION);
        }

        public static T Create<T>() where T : ScriptableObject
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
            {
                path = "Assets/";
            }
            else path += '/';
            return CreateAt<T>(path + typeof(T).Name + EXTENSION);
        }
    }
}