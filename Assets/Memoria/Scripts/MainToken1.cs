using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToken1 : MonoBehaviour
{
    GameObject gameMemory;
    SpriteRenderer SpriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;

    public void OnMouseDown()
    {
        if (matched == false)
        {
            if (SpriteRenderer.sprite == back)
            {
                if (gameMemory.GetComponent<GameMemory>().TwoCardsUp() == false)
                {
                    SpriteRenderer.sprite = faces[faceIndex];
                    gameMemory.GetComponent<GameMemory>().AddVisibleFace(faceIndex);
                    matched = gameMemory.GetComponent<GameMemory>().CheckMatch();
                }
            }
            else
            {
                SpriteRenderer.sprite = back;
                gameMemory.GetComponent<GameMemory>().RemoveVisibleFace(faceIndex);
            }
        }
    }

    private void Awake()
    {
        gameMemory = GameObject.Find("GameMemory");
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
}
