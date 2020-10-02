using UnityEngine;

public class Camera : MonoBehaviour 
{
    [SerializeField] private Transform personagem;

    [SerializeField] private Vector3 distancia, posicao, posicaoAlvo;

    [SerializeField] private float lerpVal;

    private void Start() 
    {
        distancia = personagem.position - transform.position;
    }

    private void LateUpdate()
    {
        if(!PlayerMovement.gameOver)
        {
            PersegueFunc();
        }
    }

    void PersegueFunc()
    {
        //pegando a posiçao da camera
        posicao = transform.position;

        //posicao do personagem 
        posicaoAlvo = personagem.position - distancia;

        //atribuindo um novo valor a pos
        posicao = Vector3.Lerp(posicao, posicaoAlvo, lerpVal);

        transform.position = posicao;
    }

}