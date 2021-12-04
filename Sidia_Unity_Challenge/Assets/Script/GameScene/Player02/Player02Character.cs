using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02Character : MonoBehaviour
{

    public GameObject[] character02Prefabs;
    public Transform spawn2;
    public GameObject prefab2;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        int selectPlayer02 = PlayerPrefs.GetInt("selectPlayer02");
        prefab2 = character02Prefabs[selectPlayer02];
        player2 = Instantiate(prefab2, spawn2.position, Quaternion.identity);
        //player2.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
