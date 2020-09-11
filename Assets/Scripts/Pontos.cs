using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public float score;

    void Update()
    {
        score += Time.deltaTime * 10f;    
    }
}
