using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    Vector3 distanceCam;
    // Start is called before the first frame update
    void Start()
    {
        distanceCam = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distanceCam;   
    }
}
