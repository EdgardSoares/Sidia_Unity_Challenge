using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGame : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawn;
    public Transform spawn2;
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject player;
    public GameObject player2;

    Vector3 distanceCam;

    

    // Start is called before the first frame update
    void Start()
    {
        int selectCharacter = PlayerPrefs.GetInt("selectCharacter");
        int selectCharacter02 = PlayerPrefs.GetInt("selectCharacter02");  //Vai pegar o index do personagem selecionado
        prefab = characterPrefabs[selectCharacter]; //Selecionar o prefab
        prefab2 = characterPrefabs[selectCharacter02];
        player = Instantiate(prefab, spawn.position, Quaternion.identity); //Spawnar no mapa
        player2 = Instantiate(prefab2, spawn2.position, Quaternion.identity);
        //Fazer o Spawn ser random no mapa

        distanceCam = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + distanceCam;
        
    }


    

    





}
