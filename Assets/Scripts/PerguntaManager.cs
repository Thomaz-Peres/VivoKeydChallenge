using UnityEngine;

public class PerguntaManager : MonoBehaviour
{
    [SerializeField] private float dano = 1;
    public GameObject[] pergunta;

    // pergunta fogo ou raio
    public void Fogo()
    {
        foreach (var perguntas in pergunta)
        {
            perguntas.SetActive(false);
        }
        // PlayerMovement.vida--;
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
    public void Raio()
    {
        foreach (var perguntas in pergunta)
        {
            perguntas.SetActive(false);
        }
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
    public void Agua()
    {
        PlayerMovement.vida--;
        foreach (var perguntas in pergunta)
        {
            perguntas.SetActive(false);
        }
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
    public void Pedra()
    {
        PlayerMovement.vida--;
        foreach (var perguntas in pergunta)
        {
            perguntas.SetActive(false);
        }
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
    public void Peito()
    {
        foreach (var perguntas in pergunta)
        {
            perguntas.SetActive(false);
        }
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
    public void Cabeca()
    {
        PlayerMovement.vida--;
        foreach (var perguntas in pergunta)
        {
            perguntas.SetActive(false);
        }
        //  se for certa, dano no chefe == 1
        //  se não, ele vai perder 1 de vida
    }
}
