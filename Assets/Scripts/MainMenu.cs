using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Sound Effect")]
    public Image SoundEffectImage;
    public Sprite OnnSoundEffect;
    public Sprite OffSoundEffect;
    public bool sound = true;

    [Header("Music")]
    public Image MusicImage;
    public Sprite OnnMusic;
    public Sprite OffMusic;
    public bool music = true;

    public void Start()
    {
        if (SoundManager.Instance != null && SoundManager.Instance.musicOn)
            SoundManager.Instance.MusicOnn();

        UpdateSfxIcon();
        UpdateMusicIcon();
    }

    public void ClickSoundEffectButton()
    {
        if (SoundManager.Instance.sfxOn)
        {
            SoundManager.Instance.SoundEffectOffFunc();
            SoundEffectImage.sprite = OffSoundEffect;
        }
        else
        {
            SoundManager.Instance.SoundEffectOnnFunc();
            SoundEffectImage.sprite = OnnSoundEffect;
        }
    }

    public void ClickMusicButton()
    {
        if (SoundManager.Instance.musicOn)
        {
            SoundManager.Instance.MusicOff();
            MusicImage.sprite = OffMusic;
        }
        else
        {
            SoundManager.Instance.MusicOnn();
            MusicImage.sprite = OnnMusic;
        }
    }

    private void OnEnable()
    {
        UpdateSfxIcon();
        UpdateMusicIcon();
    }

    private void UpdateSfxIcon()
    {
        SoundEffectImage.sprite =
            SoundManager.Instance.sfxOn ? OnnSoundEffect : OffSoundEffect;
    }

    private void UpdateMusicIcon()
    {
        MusicImage.sprite =
            SoundManager.Instance.musicOn ? OnnMusic : OffMusic;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
