using System;
using TMPro;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    
    public GameObject[] Players = new GameObject[12];
    public TMP_Text[] nameTexts = new TMP_Text[12];


    private void Start()
    {
        for (int i = 0; i < GameManager.instance.racePersonNum; i++)
        {
            SoundManager.instance.PlaySE("StartRace");
            Players[i].SetActive(true);
            nameTexts[i].text = GameManager.instance.personName[i];
        }
    }
}
