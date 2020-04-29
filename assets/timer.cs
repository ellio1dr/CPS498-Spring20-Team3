using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    private bool complete = false;
    private float StarTime;
    public Text TimerText;

    void Start()
    {
        StarTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (complete)
            return;

        float f = Time.time - StarTime;

        string minutes = ((int)f / 60).ToString();
        string seconds = (f % 60).ToString("f0");

        TimerText.text = minutes + ":" + seconds;
    }

    public void Finnish()
    {

        complete = true;
        Color c = new Color(0, 1, 0, 1);
        TimerText.color = c;


    }

}