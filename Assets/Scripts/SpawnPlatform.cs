using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public List<GameObject> platforms = new List<GameObject>(); // prefabs
    public List<Transform> currentPlatforms = new List<Transform>();    //  objetos instanciados

    public int offset;

    private Transform player;
    private Transform currentPlatformPoint;
    private int platformIndex;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < platforms.Count; i++)
        {
            // lista de objetos a ser instanciados, a posição que vao ser criados e a rotação
            Transform p = Instantiate(platforms[i], new Vector3(0, 0, i * 86), transform.rotation).transform;
            currentPlatforms.Add(p);
            offset += 86;
        }

        currentPlatformPoint = currentPlatforms[platformIndex].GetComponent<FinalPoint>().point;
        //  acima o currentPlatformPoint recebe o ponto do final da plataforma
    }

    // Update is called once per frame
    void Update()
    {
        float distance = player.position.z - currentPlatformPoint.position.z;

        if (distance >= 5)
        {
            Recycle(currentPlatforms[platformIndex].gameObject);
            platformIndex++;

            if (platformIndex > currentPlatforms.Count - 1)
            {
                platformIndex = 0;
            }

            currentPlatformPoint = currentPlatforms[platformIndex].GetComponent<FinalPoint>().point;
        }
    }

    public void Recycle(GameObject platform)
    {
        platform.transform.position = new Vector3(0, 0, offset);
        offset += 86;
    }
}