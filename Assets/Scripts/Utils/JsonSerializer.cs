using System;
using System.IO;
using UnityEngine;

namespace Utils
{
    public static class JsonSerializer
    {
        public static bool SaveToJson<T>(T data, string fileName)
        {
            try
            {
                string path = GetFilePath(fileName);
                string json = JsonUtility.ToJson(data, true);

                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                File.WriteAllText(path, json);
                return true;
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return false;
            }
        }

        public static T LoadFromJson<T>(string fileName) where T : new()
        {
            try
            {
                string path = GetFilePath(fileName);

                if (!File.Exists(path))
                {
                    return new T();
                }

                string json = File.ReadAllText(path);
                T data = JsonUtility.FromJson<T>(json);
                return data;
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return new T();
            }
        }

        public static bool FileExists(string fileName)
        {
            return File.Exists(GetFilePath(fileName));
        }

        public static bool DeleteFile(string fileName)
        {
            try
            {
                string path = GetFilePath(fileName);
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private static string GetFilePath(string fileName)
        {
            Debug.Log($"Save Path: {Application.persistentDataPath}{fileName}");
            return Path.Combine(Application.persistentDataPath, fileName);
        }
    }
}