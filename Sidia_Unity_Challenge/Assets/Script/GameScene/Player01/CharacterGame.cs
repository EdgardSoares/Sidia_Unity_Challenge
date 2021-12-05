using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterGame : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawn;    
    public GameObject prefab;    
    public GameObject player;
    public Text p1TurnsCountTXT;
    public Text p2TurnsCountTXT;


    Vector3 distanceCam;

    public PlayerController playerInfo;
    public Player02Controller player02Info;

    

    // Start is called before the first frame update
    public void Start()
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
        //p1TurnsCountTXT.text = playerInfo.turnsCount.ToString();
        //p2TurnsCountTXT.text = player02Info.p2TurnsCount.ToString();

    }


    

    





}
