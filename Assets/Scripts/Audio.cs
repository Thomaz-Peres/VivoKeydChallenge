using UnityEngine;

public class Audio : MonoBehaviour 
{
    AudioSource menuMusic;
    
    void Start() 
    {
        menuMusic = GetComponent<AudioSource>();
        menuMusic.Play(0);
    }
    
}