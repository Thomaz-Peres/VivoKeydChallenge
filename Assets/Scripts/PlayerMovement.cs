using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private Rigidbody rig;

    public float jumpForce;

    public float gravityModifier;

    [SerializeField]
    private float jumpLado;

    public bool onGround;

    private bool gameOver = false;

    public float limiteVel;

    private Animator anim;
    public Transform chaoVerificador;
    // Start is called before the first frame update
    void Start()
    {
        anim =  GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        StartCoroutine(AjustaVel());
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics.Linecast(transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Chao"));
        anim.SetBool("chao", onGround);

        Movimentacao();

        Right();

        Left();

        Jump();
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
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        onGround = true;
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
        //ajutasdo minha velocidade
        while (!gameOver)
        {
            yield return new WaitForSeconds(2);
            if (speed < limiteVel)
            {
                speed += 1.0f;
            }
        }
    }
}
