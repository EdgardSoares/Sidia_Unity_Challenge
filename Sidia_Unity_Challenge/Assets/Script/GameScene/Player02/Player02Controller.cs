using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Turnstate { PLAYER02TURN, PLAYER01TURN}

public class Player02Controller : MonoBehaviour
{
    public TurnState state;
    private bool isMoving;
    private Vector3 originPosition, targetPosition;
    private float timeToMove = 1f;
    public int p2TurnsCount;
    private float speed = 3;

    public TurnControl turn;





    public void Update()
    {

        Player02Movement();
        
        if (p2TurnsCount == 0)
        {
            
        }


      /*if (turn.isPlayer02Turn == true)
        {
            
            Player02Movement();
        }*/
        
    }


    public void Player02()
    {
        state = TurnState.PLAYER02TURN;
        Player02Movement();
    }



    public void Player02Movement()
    {
        
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.right.normalized));
            p2TurnsCount = p2TurnsCount + 1;
        }

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.left.normalized));
            p2TurnsCount = p2TurnsCount + 1;
        }

        if (Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.forward.normalized));
            p2TurnsCount = p2TurnsCount + 1;
        }

        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.back.normalized));
            p2TurnsCount = p2TurnsCount + 1;
        }


    }

    public IEnumerator MovePlayer02(Vector3 direction)
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
}
