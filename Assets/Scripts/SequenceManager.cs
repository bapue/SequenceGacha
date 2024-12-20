using System;
using TMPro;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    
    public GameObject[] Players = new GameObject[12];
    public TMP_Text[] nameTexts = new TMP_Text[12];

    public GameObject IntroSequencerCameras;
    
    public GameObject EnterSequencerCameras;
    public GameObject[] PlayerObject = new GameObject[12];
    
    
    public GameObject IntroUI;
    private void Start()
    {
        for (int i = 0; i < GameManager.instance.racePersonNum; i++)
        {
            PlayerObject[i].SetActive(true);
            SoundManager.instance.PlaySE("StartRace");
            Players[i].SetActive(true);
            nameTexts[i].text = GameManager.instance.personName[i];
        }
    }

    public void ShowIntro()
    {
        IntroUI.SetActive(false);
        IntroSequencerCameras.SetActive(false);
        EnterSequencerCameras.SetActive(true);
    }
    
    
}
