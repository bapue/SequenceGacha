using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public int GameNum = 0;
    public string[] personName = new string[12];    
    
    public int racePersonNum = 0;
    public int raceNum = 0;
    public int raceFloor = 0;
    public int raceWeather = 0;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
