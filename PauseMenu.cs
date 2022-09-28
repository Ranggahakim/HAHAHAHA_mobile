using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
     GameObject defeat;
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("kalah").GetComponent<defeat>().kalah == false)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
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
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void pauseButton()
    {
        if(GameObject.FindGameObjectWithTag("kalah").GetComponent<defeat>().kalah == false)
        {
            Pause();
        }
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("SpaceMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
