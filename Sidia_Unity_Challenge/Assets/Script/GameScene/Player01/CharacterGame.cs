using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGame : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawn;    
    public GameObject prefab;    
    public GameObject player;
    

    Vector3 distanceCam;

    

    // Start is called before the first frame update
    void Start()
    {
        int selectCharacter = PlayerPrefs.GetInt("selectCharacter");        
        prefab = characterPrefabs[selectCharacter];         
        player = Instantiate(prefab, spawn.position, Quaternion.identity);
        player.SetActive(true);
        
        

        distanceCam = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + distanceCam;
        
    }


    

    





}
