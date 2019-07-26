using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private static DataHandler _instance;
    string filename = "DECK.json";
    string path;

    public static DataHandler instance
    {
        get
        {
            //If _instance hasn't been set yet, we grab it from the scene!
            //This will only happen the first time this reference is used.

            if (_instance == null)
                _instance = GameObject.FindObjectOfType<DataHandler>();
            return _instance;
        }
    }

    public List<Card> GetCards()
    {
        path = Application.dataPath + "/" + filename;
        //Debug.Log("file : " + path);

        try
        {
            if (System.IO.File.Exists(path))
            {
                GameData gameData = new GameData();
                string contents = System.IO.File.ReadAllText(path);
                JsonWrapper wrapper = JsonUtility.FromJson<JsonWrapper>(contents);
                gameData = wrapper.gameData;

                Debug.Log(gameData.ToString());

                return gameData.card;
            }
            else
            {
                Debug.Log("Unable to read the deck data, file does not exist");
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return null;
    }

}

[System.Serializable]
public class JsonWrapper
{
    public GameData gameData;
}

[System.Serializable]
public class GameData
{
    public int size = 0;
    public string version = "";
    public List<Card> card = new List<Card>();

    override public string ToString()
    {
        string str = "ver = " + version + " " + size + " items : ";
        foreach (Card c in card)
        {
            str += c.ToString() + " | ";
        }
        return str;
    }
}