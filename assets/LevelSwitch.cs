using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(0); //Loads Main Menu when touching goal
            GameObject.Find("FPSController").SendMessage("Finnish");
        }
    }
}
