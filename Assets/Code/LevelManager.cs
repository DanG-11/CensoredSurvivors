using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hpText;
    int PlayerHealth = 100;
    int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Wynik: " + points.ToString();
        hpText.text = "HP: " + PlayerHealth.ToString();
    }
    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
    }
    public void ReducePlayerHealth(int amount)
    {
        if (PlayerHealth >= 0)
            PlayerHealth -= amount;
        else if (PlayerHealth <= 0)
        {
            Time.timeScale = 0;
            GameOverCanvas.SetActive(true);
        }


    }
    public void ReduceEnemyHealth(int amount)
    {
        if (PlayerHealth >= 0)
            PlayerHealth -= amount;
        else if (PlayerHealth <= 0)
        {
            Time.timeScale = 0;
            GameOverCanvas.SetActive(true);
        }


    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        PlayerHealth = 100;
        points = 0;
        GameOverCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
