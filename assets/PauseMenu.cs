using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //if esxape key is pressed then it will bring up the pause menu
        if (Input.GetKey(KeyCode.M))
        {
            //if resume is clicked then it will exit the pause screen
            //and resume the game
            if (GameisPaused)
            {
                Resume();
            }
            //if not then stay paused
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        //once reseume is selected then resume
        pauseMenuUI.SetActive(false);
        //set the timescale back to 1
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    void Pause()
    {
        //once the menu button is pressed
        //and freeze the game by setting time to 0
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void loadmenu()
    {
        //load the main menu and print a message into the debug log
        Debug.Log("Loading menu");
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        //exit the application
        Application.Quit();
    }
}