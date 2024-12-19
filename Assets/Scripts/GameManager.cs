using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    GameManager instance;

    public int personCNT = 0;
    
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
