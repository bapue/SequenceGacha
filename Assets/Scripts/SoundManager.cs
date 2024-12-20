using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}

public class Bgm
{
    public string bgmName;
    public AudioClip clip;

}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public Sound[] sfxSound;
    public AudioSource sfxPlayer;

    public Bgm[] bgmSound;
    public AudioSource bgmPlayer;
    
    public float volume = 0.5f;
    public int Count_channel = 30; // 채널 갯수

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
        //Init();
    }

    // void Init()
    // {
    //     sfxPlayer = new AudioSource[Count_channel];
    //     for (int i = 0; i < Count_channel; i++) 
    //     {
    //         sfxPlayer[i] = transform.AddComponent<AudioSource>();
    //         sfxPlayer[i].playOnAwake = false;
    //         sfxPlayer[i].volume = volume;
    //     }
    // }

    public void PlaySE(string _soundName)
    {
        for (int i = 0; i < sfxSound.Length; i++)
        {
            if (_soundName == sfxSound[i].soundName)
            {
                sfxPlayer.clip = sfxSound[i].clip;
                sfxPlayer.Play();
                return;
            }
        }
    }
}
