using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGame : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        int selectCharacter = PlayerPrefs.GetInt("selectCharacter"); //Vai pegar o index do personagem selecionado
        GameObject prefab = characterPrefabs[selectCharacter]; //Selecionar o prefab
        GameObject novo = Instantiate(prefab, spawn.position, Quaternion.identity); //Spawnar no mapa

        //Fazer o Spawn ser random no mapa
    }

    
}
