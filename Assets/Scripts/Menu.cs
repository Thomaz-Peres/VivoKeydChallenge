using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ChamaCena()
    {
        // Application.LoadLevel("SampleScene");
        SceneManager.LoadScene("SampleScene");
    }
}
