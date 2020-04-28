using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Escape))
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
                pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void loadmenu()
    {
        Time.timeScale = 0f;
        Debug.Log("Loading menu");
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {

        Application.Quit();
    }
}