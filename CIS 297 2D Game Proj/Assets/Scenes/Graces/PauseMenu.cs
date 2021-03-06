using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;


    public void Awake()
    {
        pauseMenuUI.SetActive(GameIsPaused);

    }// i added this so the game doesnt start paused 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(GameIsPaused);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        GameIsPaused = true;
        pauseMenuUI.SetActive(GameIsPaused);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene("Main Menu");
        GameManager.bluegem = 0;
        GameManager.redgem = 0;
        GameManager.greengem = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
