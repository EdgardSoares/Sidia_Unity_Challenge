using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02Controller : MonoBehaviour
{

    private bool isMoving;
    private Vector3 originPosition, targetPosition;
    private float timeToMove = 1f;
    private int turnsCount = 0;
    private float speed = 3;

    public GameObject player02Char;
    CharacterGame charPlayer02;

    

    void Player02Movement()
    {
        
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.right.normalized));
            turnsCount = turnsCount + 1;
        }

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.left.normalized));
            turnsCount = turnsCount + 1;
        }

        if (Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.forward.normalized));
            turnsCount = turnsCount + 1;
        }

        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer02(Vector3.back.normalized));
            turnsCount = turnsCount + 1;
        }


    }

    private IEnumerator MovePlayer02(Vector3 direction)
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
