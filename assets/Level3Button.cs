using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Button : MonoBehaviour
{
   public void PlayLevel()
    {
        SceneManager.LoadScene(3); //Loads level 3
        
    }
}
