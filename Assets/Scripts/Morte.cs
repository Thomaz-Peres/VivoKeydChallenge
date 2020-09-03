using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    PlayerMovement player;

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
            Destroy(gameObject);
            player.gameOver = true;
        }
    }
    
    void Destroy()
    {
        if (transform.position.x >= 7f)
        {
            Destroy(gameObject);
            player.gameOver = true;
        }
        if (transform.position.x <= -7f)
        {
            Destroy(gameObject);
            player.gameOver = true;
        }
    }
}