using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
public class UIManager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    public Text coinText;
    bool gameOver;
    int score;
    public int coinInt;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 0f, 1f);

        coinInt = 0;
        coinText.text = coinInt.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
       /* if(score >= 5)
        {
            GameObject.Find("CarSpawn").GetComponent<CarSpawn>().timer -= 0.2f; ;
        }*/
        
    }

    
    
    void scoreUpdate()
    {
        if (gameOver == false)       {
            score += 1;
        }
    }
    public void gameOverActivated()
    {
        gameOver = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
       
        
    }
    public void IncreaseCoins()

    {
        coinInt += 1;
        coinText.text = coinInt.ToString();
    }
    public void Pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            return;
        }
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            return;
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit(); 
    }
    public void Easy()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Medium()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Hard()
    {
        SceneManager.LoadScene("Level3");
    }
}
