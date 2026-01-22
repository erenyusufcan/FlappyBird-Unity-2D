using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance;


    public AudioSource[] SoundEffects;
    public AudioSource birdSound;
    public AudioSource dieSound;
    public AudioSource coinSound;
    public AudioSource musicSound;

    public bool sfxOn = true;
    public bool musicOn = true;

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); 
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); 
    }

    public void SoundEffectOnnFunc()
    {
        sfxOn = true;
        foreach (var effect in SoundEffects)
        {
            effect.mute =false;
        }
    }
    public void SoundEffectOffFunc()
    {
        sfxOn = false;
        foreach (var effect in SoundEffects)
        {
            effect.mute = true;
        }
    }

    public void MusicOnn()
    {
        musicOn = true;
        musicSound.loop = true;
        musicSound.mute = false;
        if (!musicSound.isPlaying)
            musicSound.Play();
    }

    public void MusicOff()
    {
        musicOn = false;
        musicSound.mute=true;
        musicSound.Stop();
    }
    public void StopMusicTemp()
    {
        musicSound.Stop();
    }

    public void BirdSoundFunc()
    {
        if (!sfxOn) return;
        birdSound.Play();
    }

    public void DieSoundFunc()
    {
        if (!sfxOn) return;
        dieSound.Play();
    }

    public void CoinSoundFunc()
    {
        if (!sfxOn) return;
        coinSound.Play();
    }

    


}
