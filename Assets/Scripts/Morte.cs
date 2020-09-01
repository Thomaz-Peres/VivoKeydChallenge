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
        if(transform.position.x >= 6f)
        {
            Destroy(gameObject);
        }
        if(transform.position.x <= -6f)
        {
            Destroy(gameObject);
        }
    }
}