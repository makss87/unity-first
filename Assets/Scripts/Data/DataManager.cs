using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string UserName;
    public int Score;

    private string FileName = "score.json";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveScore(int score)
    {
        SaveData data = new SaveData();

        data.Score = score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/" + this.FileName, json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/" + this.FileName;

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Instance.Score = data.Score;
        }
    }

    [Serializable]
    class SaveData
    {
        public int Score;
    }
}