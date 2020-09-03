using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNoJogo : MonoBehaviour
{
    public bool pause;
    void OnClick()
    {
        if (!pause)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
    
}
