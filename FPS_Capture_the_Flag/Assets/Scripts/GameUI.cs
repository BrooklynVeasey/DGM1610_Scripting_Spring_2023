using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [Header("HUD")]
    //public TextMeshProUGUI scoreText;
    //public Image healthBarFill;

    [Header("Pause Menu")]
    public GameObject pauseMenu;

    [Header("End Game Screen")]
    public GameObject endGameScreen;
    //public TextMeshProUGUI endGameHeader;

    public static GameUI instance;

    void Awake()
    {
        instance = this;
    }

    public void UpdateHealthBar(int curHP, int maxHP)
    {
        //healthBarFill.fillAmount = (float)curHP / (float)maxHP;
    }

    public void UpdateScoreText (int score)
    {
        //scoreText.text = "Score: " + score;
    }

    public void TogglePauseMenu(bool paused)
    {
        pauseMenu.SetActive(paused);
    }

    public void SetEndGameScreen (bool won, int score)
    {
        endGameScreen.SetActive(true);
        //endGameHeaderText.text = won == true ? "You Win" : "You Lose";
        //endGameHeaderText.color = won == true ? Color.green : Color.red;
        //endGameScoreText.text = "<b>Score</b>\n" + score;
    }

    public void OnResumeButton()
    {
        GameManager.instance.TogglePauseGame();
    }

    public void OnRestartButton()
    {
        //scoreManager.LoadScene("Game");
    }

    public void OnMenuButton()
    {
        //SceneManager.LoadScene("Menu");
    }
}
