﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNoJogo : MonoBehaviour
{
    public bool pause;
    [SerializeField] private AudioSource musicaFase1;
    [SerializeField] private GameObject pausado;

    public void Start()
    {
        musicaFase1 = GetComponent<AudioSource>();
        musicaFase1.Play(1);
    }

    public void Pause()
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

    public void Restart()
    {
        if(PlayerMovement.gameOver == true)
            Application.LoadLevel(1);
    }

    public void Sair()
    {
        if(PlayerMovement.gameOver == true)
            Application.LoadLevel(0);
    }
}
