using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private Rigidbody rig;
    
    public float jumpForce;

    public float vida = 3f;

    public float gravityModifier;

    private float jumpLado = 3;

    public bool onGround;

    public bool gameOver;

    public float limiteVel;

    public Animator anim;

    public CapsuleCollider capsuleCollider;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();

        capsuleCollider = GetComponent<CapsuleCollider>();

        Physics.gravity *= gravityModifier;
        
        StartCoroutine(AjustaVel());
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();

        Right();

        Left();

        Jump();

        Baixo();

        anim.SetBool("chao", onGround);

        if(onGround == false)
        {
            jumpLado = 0;
        }
        else {
            jumpLado = 3;
        }
    }

    void Movimentacao()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
            anim.SetBool("chao", onGround);
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        onGround = true;
    }

    void Baixo()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("chao", !onGround);
        }
    }

    void Right()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.Translate(Vector3.right * jumpLado);
        }
    }

    void Left()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.Translate(Vector3.right * jumpLado * -1);
        }
    }

    IEnumerator AjustaVel()
    {
        //ajutando minha velocidade
        while (!gameOver)
        {
            yield return new WaitForSeconds(3);
            if (speed < limiteVel)
            {
                speed += 1.0f;
            }
        }
    }
}
