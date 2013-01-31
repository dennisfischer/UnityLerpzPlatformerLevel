using UnityEngine;

public class GameData : MonoBehaviour
{
    private static GameData instance;

    private GameData()
    {
        instance = this;
        Paused = false;
        dialog = null;
    }


    public static GameData Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject newGO = new GameObject("new name");
                newGO.AddComponent("GameData");
                instance = newGO.GetComponent<GameData>();
                instance.Deaths = 0;
            }
            return instance;
        }
    }

    private int score = 0;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public int Deaths
    {
        get;
        set;
    }

    public bool Paused
    {
        get;
        set;
    }

    public Dialog dialog
    {
        get;
        set;
    }
}
