using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public List<GameObject> platforms = new List<GameObject>();

    public int offset;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            // lista de objetos a ser instanciados, a posição que vao ser criados e a rotação
            Instantiate(platforms[i], new Vector3(0, 0, i * 86), transform.rotation);
            offset += 86;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Recycle(GameObject platform)
    {
        platform.transform.position = new Vector3(0, 0, offset);
        offset += 86;
    }
}
