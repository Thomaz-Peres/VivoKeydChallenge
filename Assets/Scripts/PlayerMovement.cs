using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 10f;
    public float limiteVel = 100f;
    private Rigidbody rig;
    private float jumpForce = 13f;
    public static float vida = 3;
    private float gravityModifier = 3f;
    public float jumpLado = 3f;
    public bool onGround;
    public static bool gameOver = false;
    public Animator anim;
    public SwipeManager swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    void Start()
    {
        rig = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;

        StartCoroutine(AjustaVel());
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();

        if(transform.position.x < 3)
            Right();
        
        if(transform.position.x > -3)
            Left();

        Jump();

        anim.SetBool("chao", onGround);

        if(onGround == false)
        {
            jumpLado = 0;
        }
        else {
            jumpLado = 3;
        }
    }

    public void Movimentacao()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) || (swipeControls.SwipeUp) && onGround)
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

    public void Right()
    {
        if (Input.GetKeyUp(KeyCode.D) || (swipeControls.SwipeRight))
        {
            transform.Translate(Vector3.right * jumpLado);
        }
    }

    public void Left()
    {   
        if (Input.GetKeyUp(KeyCode.A) || (swipeControls.SwipeLeft))
        {
            transform.Translate(Vector3.right * jumpLado * -1);
        }
    }

    IEnumerator AjustaVel()
    {
        //ajutando minha velocidade
        while (gameOver == false)
        {
            yield return new WaitForSeconds(3);
            if (speed < limiteVel)
            {
                speed += 1.0f;
            }
        }
    }
}