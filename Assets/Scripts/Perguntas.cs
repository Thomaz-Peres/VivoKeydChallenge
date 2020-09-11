using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Perguntas : MonoBehaviour
{

    public GameObject[] pergunta;
    PlayerMovement player;

    public bool vivo;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        StartCoroutine(TempoPergunta());

        vivo = player.gameOver;
    }

    IEnumerator TempoPergunta()
    {
        int index = Random.Range(0, pergunta.Length);

        while (!vivo)
        {
            yield return new WaitForSeconds(5);
            for (int i = 0; i < pergunta.Length; i++)
            {
                pergunta[index].SetActive(true);
            }
            yield return new WaitForSeconds(4);
            pergunta[index].SetActive(false);
        }
    }
}
