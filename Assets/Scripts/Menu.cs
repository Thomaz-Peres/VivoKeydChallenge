using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public List<GameObject> configuracoes = new List<GameObject>();
    public GameObject configScreen;
    public GameObject outfitScreen;

    public void ChamaCena()
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

        for (int i = 0; i < configuracoes.Count; i++)
        {
            configuracoes[i].SetActive(true);
        }
    }
}
