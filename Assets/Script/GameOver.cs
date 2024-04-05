using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public Score highScore;
    [SerializeField] TextMeshProUGUI finalScore;

    void Start()
    {
        gameObject.SetActive(false);
    }


    public void activeScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;

        finalScore.text = "Score: " + (highScore.score * 10).ToString("0");
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
