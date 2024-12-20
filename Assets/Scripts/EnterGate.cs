using System.Collections;
using UnityEngine;

public class EnterGate : MonoBehaviour
{
    public GameObject[] Players = new GameObject[12];

    bool isEnter = false;

    private void Start()
    {
        // Initialize speeds with values from GameManager
        for (int i = 0; i < Players.Length; i++)
        {
            GameManager.instance.speed[i] = Random.Range(1f, 1.5f); // Example: random speeds between 0.05 and 0.15
        }
    }

    private void Update()
    {
        if (isEnter)
        {
            for (int i = 0; i < Players.Length; i++)
            {

                    Players[i].transform.position = Vector3.MoveTowards(
                        Players[i].transform.position, 
                        new Vector3(198, Players[i].transform.position.y, Players[i].transform.position.z), 
                        GameManager.instance.speed[i] * Time.deltaTime
                    );
            }
        }
    }

    
    public void StartEnter()
    {
        isEnter = true;
        
    }
}