using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNoJogo : MonoBehaviour
{
    public bool pause;

    [SerializeField] private GameObject pausado;
    void OnClick()
    {
        if (!pause)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pausado.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pausado.SetActive(false);
            }
        }
    }
    
}
