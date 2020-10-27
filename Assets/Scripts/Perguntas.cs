using System.Collections;
using UnityEngine;

public class Perguntas : MonoBehaviour
{
    public GameObject[] pergunta;
    PlayerMovement player;
    public GameObject inicio;
    public bool vivo;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        StartCoroutine(TempoPergunta());
        Time.timeScale = 0;
        inicio.SetActive(true);
        StartCoroutine(Inicio());
        vivo = PlayerMovement.gameOver;
    }

    public void Click()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            inicio.SetActive(false);
        }
    }

    IEnumerator Inicio()
    {
        inicio.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    IEnumerator TempoPergunta()
    {
        yield return new WaitForSeconds(1);
        while (PlayerMovement.gameOver == false)
        {
            int index = Random.Range(0, pergunta.Length);
            yield return new WaitForSeconds(5);
            for (int i = 0; i < pergunta.Length; i++)
            {
                pergunta[index].SetActive(true);
            }
            yield return new WaitForSeconds(3);
            pergunta[index].SetActive(false);
        }        
    }
}
