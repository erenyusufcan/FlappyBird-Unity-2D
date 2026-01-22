using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpamount;
    public Animator GroundAnimator;
    public Animator BirdAnimator;
    public PipeSpawn PipeSpawn;
    public float score;
    public TextMeshProUGUI score_text;
    public UIManager uIManager;
    public TextMeshProUGUI gameoverscore_text;
   

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        score = 0f;
        SoundManager.Instance.StopMusicTemp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            GameOverPipeAndGround();
            PipeSpawn.PipeCollision();
            uIManager.GameOverUI();

        }
        if (collision.CompareTag("Ceiling"))
        {
            GameOverCeilling();
            PipeSpawn.PipeCollision();
            uIManager.GameOverUI();

        }
        if (collision.CompareTag("Pipe"))
        {
            GameOverPipeAndGround();
            PipeSpawn.PipeCollision();
            uIManager.GameOverUI();

        }
        if (collision.CompareTag("Score"))
        {
            score++;
            score_text.text= score.ToString();
            gameoverscore_text.text=score_text.text;
            if (score%10 == 0)
            {
                SoundManager.Instance.coinSound.Play();
            }
        }

    }

    public void GameOverCeilling()
    {
        GroundAnimator.enabled = false;
        gameObject.SetActive(false);
        SoundManager.Instance.birdSound.mute=true;
        SoundManager.Instance.dieSound.Play();

    }

    public void GameOverPipeAndGround()
    {
        GroundAnimator.enabled=false;    
        rb.velocity = Vector2.zero;
        rb.simulated = false;
        BirdAnimator.enabled=false;
        SoundManager.Instance.birdSound.mute=true;
        SoundManager.Instance.dieSound.Play();

    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SoundManager.Instance.BirdSoundFunc();
            rb.velocity = Vector2.up * jumpamount;
        }



    }
  
}





