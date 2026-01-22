using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIManager : MonoBehaviour
{
    public Bird bird;
    public Canvas scoreCanvas;
    public GameObject YourScore;
    public GameObject GameOver;
    public GameObject RestartBtn;
    public GameObject MaýnMenuBtn;
    public GameObject HighScore;
    public TextMeshProUGUI highScoreText;
    public GameObject ResetHighScoreBtn;
    public GameObject Score_Text;
    public GameObject GameOverScore_Text;
    public void Start()
    {
        int hs = PlayerPrefs.GetInt("High Score", 0);
        highScoreText.text = "High Score : " + hs;
        YourScore.SetActive(false);
        GameOver.SetActive(false);  
        MaýnMenuBtn.SetActive(false);
        RestartBtn.SetActive(false); 
        HighScore.SetActive(false);
        ResetHighScoreBtn.SetActive(false);
        GameOverScore_Text.SetActive(false);
       


    }
    public void GameOverUI()
    {
        int hs = PlayerPrefs.GetInt("High Score", 0);

        if(hs < bird.score)
        {
            PlayerPrefs.SetInt("High Score", (int)bird.score);
            PlayerPrefs.Save();
            hs=(int)bird.score;
        }

        highScoreText.text = ("High Score : " + hs);

        YourScore.SetActive(true);
        GameOver.SetActive(true);
        MaýnMenuBtn.SetActive(true);
        RestartBtn.SetActive(true );
        HighScore.SetActive(true);
        ResetHighScoreBtn.SetActive (true);
        scoreCanvas.sortingOrder = 1;
        Score_Text.SetActive(false );
        GameOverScore_Text.SetActive(true);
    }
    public void MaýnMenu()
    {
        SoundManager.Instance.birdSound.mute = false;
        SceneManager.LoadScene("InterfaceScene");
    }

    public void RestartGame()
    {
      
        SoundManager.Instance.birdSound.mute = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("High Score");
        PlayerPrefs.Save();
        highScoreText.text = "High Score : 0";
    }
 
}
