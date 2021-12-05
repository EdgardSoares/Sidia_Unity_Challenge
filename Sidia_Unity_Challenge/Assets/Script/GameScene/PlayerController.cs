using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TurnState { PLAYER01TURN, PLAYER02TURN, WON, LOST}

public class PlayerController : MonoBehaviour
{
    public TurnState state;
    private bool isMoving;
    private Vector3 originPosition, targetPosition;
    private float timeToMove = 1f;
    public int turnsCount;

    private float speed = 3;

    Player02Controller player02;

    public GameObject p;

    public AudioSource walkiSound;

    //Canvas
    


    // Start is called before the first frame update
    void Start()
    {
        state = TurnState.PLAYER01TURN;
        Player01Turn();

        walkiSound.GetComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (turnsCount == 0)
        {
            //Debug.Log("Fim do Turno do P1");
            
        }
        

    }

    void Player01Turn()
    {
        
        PlayerMovement();

    }


    IEnumerator Player02Turn()
    {
               
        yield return new WaitForSeconds(2f);
        
        // player02 = FindObjectOfType<Player02Controller>();
        //player02.Player02Movement();



    }



    


    //Metodo de Input do jogador pelo Teclado
    void PlayerMovement()
    {
                
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right.normalized));
            turnsCount = turnsCount + 1;
            walkiSound.Play();
            
        }

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left.normalized));
            turnsCount = turnsCount + 1;
            walkiSound.Play();
        }

        if(Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.forward.normalized));
            turnsCount = turnsCount + 1;
            walkiSound.Play();
        }

        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.back.normalized));
            turnsCount = turnsCount + 1;
            walkiSound.Play();
        }
        

    }

    //Metodo para movimetacao do jogador
    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float timeElapse = 0;

        originPosition = transform.position;
        targetPosition = originPosition + direction * speed;

        while (timeElapse < timeToMove)
        {
            transform.position = Vector3.Lerp(originPosition, targetPosition, (timeElapse / timeToMove));
            timeElapse += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;

        isMoving = false;
    }






    //Player 02 controller

    

}
