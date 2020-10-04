using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    PlayerMovement player;
    public GameObject obstaculo;

    [SerializeField] private GameObject morreu;

    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    void Update() 
    {
        Destroy();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("obstaculo"))
        {
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
        }
        else
        {
            PlayerMovement.gameOver = false;
            morreu.SetActive(false);
        }
    }
}