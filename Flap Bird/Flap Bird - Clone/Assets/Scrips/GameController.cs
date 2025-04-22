using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController controll;

    public GameObject points;
    public GameObject menu;

    public int score;
    public Text scoreText;

    private void Start()
    {
        controll = this;
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        menu.SetActive(false);
        points.SetActive(true);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
