using UnityEngine;

public class Win : MonoBehaviour 
{
    public GameObject win;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            win.SetActive(true);
        }
    }
}