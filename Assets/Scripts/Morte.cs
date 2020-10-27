using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    PlayerMovement player;
    AudioSource colisao;
    public GameObject[] obstaculo;
    [SerializeField] private GameObject[] heart;
    [SerializeField] private GameObject morreu;
    [SerializeField] private GameObject pausado;

    void Start()
    {
        player = GetComponent<PlayerMovement>();
        colisao = GetComponent<AudioSource>();
    }

    void Update()
    {
        Destroy();

        if (PlayerMovement.vida < 1)
        {
            Destroy(heart[0].gameObject);
        }
        else if (PlayerMovement.vida < 2)
        {
            Destroy(heart[1].gameObject);
        }
        else if (PlayerMovement.vida < 3)
        {
            Destroy(heart[2].gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("obstaculo"))
        {
            colisao.Play(0);
            PlayerMovement.vida--;
            Destroy(other.gameObject);
        }
    }
    void Destroy()
    {
        if (PlayerMovement.vida <= 0)
        {
            Destroy(gameObject);
            PlayerMovement.gameOver = true;
            morreu.SetActive(true);
            pausado.SetActive(false);
        }
        else
        {
            PlayerMovement.gameOver = false;
            morreu.SetActive(false);
            pausado.SetActive(true);
        }
    }
}