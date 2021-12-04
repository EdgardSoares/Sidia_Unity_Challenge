using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGame : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawn;
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject novo;

    Vector3 distanceCam;

    // Start is called before the first frame update
    void Start()
    {
        int selectCharacter = PlayerPrefs.GetInt("selectCharacter");
        int selectCharacter02 = PlayerPrefs.GetInt("selectCharacter02");  //Vai pegar o index do personagem selecionado
        prefab = characterPrefabs[selectCharacter]; //Selecionar o prefab
        prefab2 = characterPrefabs[selectCharacter02];
        novo = Instantiate(prefab, spawn.position, Quaternion.identity); //Spawnar no mapa
        novo = Instantiate(prefab2, spawn.position, Quaternion.identity);
        //Fazer o Spawn ser random no mapa

        distanceCam = transform.position - novo.transform.position;
    }

    void Update()
    {
        transform.position = novo.transform.position + distanceCam;
    }


}
