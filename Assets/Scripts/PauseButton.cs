using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            return;
        }
         if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            return;
        }
    }
}
