using UnityEngine;
using System.IO;
using System.Collections.Specialized;
using Unity.VisualScripting;

public static class SaveScore 
{
    private static string _directory = "/SaveData/";
    private static string _fileName = "match3ScoreData.txt";

    public static void Save(HighScoreSave highScoreSave)
    {
        string dir = Application.persistentDataPath +_directory;

        if(!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        string json = JsonUtility.ToJson(highScoreSave);
        File.WriteAllText(dir+_fileName,json);
    }

    public static HighScoreSave Load()
    {
        string fullPath = Application.persistentDataPath + _directory + _fileName;
        HighScoreSave highScoreSave = new HighScoreSave();

        if (File.Exists(fullPath))
		{
			string json = File.ReadAllText(fullPath);
			highScoreSave = JsonUtility.FromJson<HighScoreSave>(json);
		}
		else
		{

			highScoreSave.highScore[0] = 0;
			

			for(int i = 1; i < 4; i++)
			{
				highScoreSave.highScore[i] = 0;
				
			}

			Save(highScoreSave);
		}

		return highScoreSave;
        
    }

}
