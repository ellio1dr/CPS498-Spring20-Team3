using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Button : MonoBehaviour
{
   public void PlayLevel()
    {
        SceneManager.LoadScene(2); //Loads level 2
        
    }
}
