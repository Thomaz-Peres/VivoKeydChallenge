using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PerguntaManager : MonoBehaviour
{
    [SerializeField] private int dano = 3;
    public GameObject pergunta;
    // pergunta fogo ou raio
    public void Fogo()
    {
        Debug.Log("Clicou no fogo");
        // PlayerMovement.vida -= dano;
        // pergunta.SetActive(false);

        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }

    void Raio()
    {
        Debug.Log("Clicou no raio");
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
}
