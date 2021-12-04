using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private bool isMoving;
    private Vector3 originPosition, targetPosition;
    private float timeToMove = 1f;

    private float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right.normalized));
        }

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left.normalized));
        }

        if(Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.forward.normalized));
        }

        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.back.normalized));
        }


    }

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
}
