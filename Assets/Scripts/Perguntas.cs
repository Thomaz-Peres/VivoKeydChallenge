using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Perguntas : MonoBehaviour
{

    public GameObject pergunta;

    PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        StartCoroutine(TempoPergunta());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TempoPergunta()
    {
        // yield return new WaitForSeconds(10);
            yield return new WaitForSeconds(5);
            pergunta.SetActive(true);

            yield return new WaitForSeconds(4);
            pergunta.SetActive(false);
    }
}
