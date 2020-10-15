using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public List<GameObject> configuracoes = new List<GameObject>();
    public GameObject configScreen;
    public GameObject outfitScreen;
    public GameObject faseScreen;

    public void EscolherFase()
    {
        faseScreen.SetActive(true);

        for (int i = 0; i < configuracoes.Count; i++)
        {
            configuracoes[i].SetActive(false);
        }
    }

    public void Fase1()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerMovement.vida = 3;
    }

    public void ChamaConfig()
    {
        configScreen.SetActive(true);

        for(int i = 0; i < configuracoes.Count; i++)
        {
            configuracoes[i].SetActive(false);
        }
    }

    public void ChamaOutFit()
    {
        outfitScreen.SetActive(true);

        for (int i = 0; i < configuracoes.Count; i++)
        {
            configuracoes[i].SetActive(false);
        }
    }

    public void VoltaMenu()
    {
        configScreen.SetActive(false);
        outfitScreen.SetActive(false);
        faseScreen.SetActive(false);

        for (int i = 0; i < configuracoes.Count; i++)
        {
            configuracoes[i].SetActive(true);
        }
    }
}
