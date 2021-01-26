using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Game : MonoBehaviour
{
    public int score { get; set; } = 0;
    public int highScore { get; set; } = 0;
    public TMPro.TextMeshProUGUI textUI;
    public TMPro.TextMeshProUGUI timerUI;
    public TMPro.TextMeshProUGUI highScoreUI;
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public AudioSource music;

     static Game instance = null;

     float timer =60;
   

    public enum eState
    {
        Title,
        StartGame,
        Game,
        GameOver
    }

    public eState State { get; set; } = eState.Title;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        switch (State)
        {
            case eState.Title:
                startScreen.SetActive(true);
                gameOverScreen.SetActive(false);
                Cursor.visible = true;
                break;
            case eState.StartGame:
                timer = 60;
                score = 0;
                textUI.text = string.Format("{0:D4}", score);
                music.Play();
                Cursor.visible = false;
                startScreen.SetActive(false);
                gameOverScreen.SetActive(false);
                State = eState.Game;
                break;
            case eState.Game:
                timer -= Time.deltaTime;
                if(timer <= 0)
                {
                    //highScoreUI.text = string.Format("High Score: {0:D4}", score);
                    
                    State = eState.GameOver;
                }
                if(score > highScore)
                {
                    highScore = score;
                    highScoreUI.text = string.Format("High Score: {0:D4}", score);
                }
                break;
            case eState.GameOver:
                gameOverScreen.SetActive(true);
                Cursor.visible = true;
                music.Stop();
                break;
            default:
                break;
        }

       timerUI.text = string.Format("{0:D2}", (int)timer);
    }
    

    public static Game Instance
    {
        get
        {
            return instance;
        }
    }

    public void AddPoints(int points )
    {
        score += points;
        textUI.text = string.Format("{0:D4}", score);
    }

    public void StartGame()
    {
        
        State = eState.StartGame;
            
    }

    public void GameScreen()
    {
        State = eState.Game;
    }

    public void EndGame()
    {
        State = eState.GameOver;
    }

}
