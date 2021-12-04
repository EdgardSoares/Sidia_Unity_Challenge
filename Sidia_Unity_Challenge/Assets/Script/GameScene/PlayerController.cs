using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnState { PLAYER01TURN, PLAYER02TURN, WON, LOST}

public class PlayerController : MonoBehaviour
{
    public TurnState state;
    private bool isMoving;
    private Vector3 originPosition, targetPosition;
    private float timeToMove = 1f;
    private int turnsCount = 0;

    private float speed = 3;

    Player02Controller player02;


    // Start is called before the first frame update
    void Start()
    {
        state = TurnState.PLAYER01TURN;
        Player01Turn();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        if (turnsCount == 3)
        {
            turnsCount = 0;
            state = TurnState.PLAYER02TURN;
            StartCoroutine(Player02Turn());
        }

    }

    void Player01Turn()
    {
        Debug.Log("Turno do Player 01");
        
    }


    IEnumerator Player02Turn()
    {
        Debug.Log("Turno do Player 02");
        yield return new WaitForSeconds(1f);
        
        
    }


    //Metodo de Input do jogador pelo Teclado
    void PlayerMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Ola");
        }


        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right.normalized));
            turnsCount = turnsCount + 1;
            
        }

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left.normalized));
            turnsCount = turnsCount + 1;
        }

        if(Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.forward.normalized));
            turnsCount = turnsCount + 1;
        }

        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.back.normalized));
            turnsCount = turnsCount + 1;
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
