using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
   public void loadnextlevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
