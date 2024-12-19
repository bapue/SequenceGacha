using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SelectGame : MonoBehaviour
{
    [SerializeField]
    private int currentNum = 1;
    
    private Animator anim;

    
    private bool isSlelecting = false;
    public GameObject StartBtnUI;
    
    public GameObject SelectGameUI;
    public GameObject MainMenuUI;
    
    public GameObject UmaMusumeUI;
    public GameObject PinBallUI;
    
    
    //Rule
    
    //person
    public int personNum = 2;
    public GameObject[] person;
    public TMP_Text personNumText;
    public TMP_InputField[] personName;
    public string[] personNameChar = {"1번", "2번", "3번", "4번", "5번", "6번", "7번", "8번", "9번", "10번", "11번", "12번"};
    //resion
    public int resionNum = 0;
    
    //Floor
    public int floorNum = 0;
    public TMP_Text floorText;
    
    //Weather
    public int weatherNum = 0;
    public TMP_Text weatherText;
    private void Start()
    {
        currentNum = 1;
        anim = GetComponent<Animator>();
        
        //이렇게 말고 끝나고 돌아올때 게임매니져에서 Init 함수 따로 빼서 초기화 해주는게 좋을듯
        personNum = 2;
        personNumText.text = personNum.ToString();
        
        floorNum = 0;
        floorText.text = "잔디";
        
        weatherNum = 0;
        weatherText.text = "맑음";
    }

    public void RightBtn()
    {
        switch (currentNum)
        {
            case 1 :
                currentNum += 1;
                anim.SetTrigger("Right_01");
                break;
        }
    }
    
    public void LeftBtn()
    {
        switch (currentNum)
        {
            case 2 :
                currentNum -= 1;
                anim.SetTrigger("Left_01");
                break;
        }
    }
    
    public void StartBtn()
    {
        isSlelecting = true;
        GameManager.instance.GameNum = currentNum;

        
        switch (currentNum)
        {
            case 1 :
                UmaMusumeUI.SetActive(true);
                break;
                
        }
    }
    
    public void ExitBtn()
    {
        if (isSlelecting)
        {
            UmaMusumeUI.SetActive(false);
            PinBallUI.SetActive(false);
            isSlelecting = false;
        }
        else
        {
            SelectGameUI.SetActive(false);
            MainMenuUI.SetActive(true);
        }
    }
    public void UmaRulePersonNumLeftBtn()
    {
        if(personNum <= 2)
            return;
        
        person[personNum - 1].SetActive(false);
        personNum -= 1;
        personNumText.text = personNum.ToString();
    }
    
    public void UmaRulePersonNumRightBtn()
    {
        if(personNum >= 12)
            return;
        
        personNum += 1;
        personNumText.text = personNum.ToString();
        person[personNum - 1].SetActive(true);
    }
    
    public void UmaRuleFloorNumLeftBtn()
    {
        if(floorNum <= 0)
            return;
        
        floorNum -= 1;
        SetFloor();
    }
    
    public void UmaRuleFloorNumRightBtn()
    {
        if(floorNum >= 1)
            return;
        
        floorNum += 1;
        SetFloor();
    }

    private void SetFloor()
    {
        switch (floorNum)
        {
            case 0 :
                floorText.text = "잔디";
                break;
            case 1 :
                floorText.text = "더트";
                break;
        }
    }
    
    public void UmaRuleWeatherNumLeftBtn()
    {
        if(weatherNum <= 0)
            return;
        
        weatherNum -= 1;
        SetWeather();
    }
    
    public void UmaRuleWeatherNumRightBtn()
    {
        if(weatherNum >= 1)
            return;
        
        weatherNum += 1;
        SetWeather();
    }
    
    private void SetWeather()
    {
        switch (weatherNum)
        {
            case 0 :
                weatherText.text = "맑음";
                break;
            case 1 :
                weatherText.text = "흐림";
                break;
        }
    }

    public void UmaMusumeRun()
    {
        GameManager.instance.racePersonNum = personNum;
        GameManager.instance.raceNum = resionNum;
        GameManager.instance.raceFloor = floorNum;
        GameManager.instance.raceWeather = weatherNum;
        
        for(int i = 0; i < personNum; i++)
        {
                GameManager.instance.personName[i] = personName[i].text;
        }
    }
    
    
}
