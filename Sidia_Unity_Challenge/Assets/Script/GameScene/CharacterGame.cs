using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGame : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawn;
    public GameObject prefab;
    public GameObject novo;

    public GameObject cam;
    Vector3 distanceCam;

    // Start is called before the first frame update
    void Start()
    {
        int selectCharacter = PlayerPrefs.GetInt("selectCharacter"); //Vai pegar o index do personagem selecionado
        prefab = characterPrefabs[selectCharacter]; //Selecionar o prefab
        novo = Instantiate(prefab, spawn.position, Quaternion.identity); //Spawnar no mapa

        //Fazer o Spawn ser random no mapa

        distanceCam = transform.position - novo.transform.position;
    }

    void Update()
    {
        transform.position = novo.transform.position + distanceCam;
    }


}
