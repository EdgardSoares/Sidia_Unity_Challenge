using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{

    public GameObject[] characters;
    public int selectCharacter = 0;
    public GameObject vikingText;
    public GameObject knightText;


    void Start()
    {
        //Iniciando o texto e o personagem do Viking como false
        vikingText.SetActive(false);
        characters[1].SetActive(false);

    }

    //Metodo do evento do click do botao Next, trocando para o proximo personagem
    public void Next()
    {
        characters[selectCharacter].SetActive(false);
        vikingText.SetActive(false);
        selectCharacter = (selectCharacter + 1) % characters.Length;
        characters[selectCharacter].SetActive(true);
        vikingText.SetActive(true);
        knightText.SetActive(false);
        Debug.Log("Selecionou o Knight");
    }

    //Metodo do evento do click do botao Previous, voltando para o personagem anterior
    public void Previous()
    {
        vikingText.SetActive(false);
        knightText.SetActive(true);
        characters[selectCharacter].SetActive(false);
        selectCharacter--;
        if (selectCharacter < 0)
        {
            selectCharacter += characters.Length;
        }
        characters[selectCharacter].SetActive(true);
    }

    //Metodo do botao Start, salvando o personagem selecionado e carregando a cena do jogo
    public void StartGame()
    {
        PlayerPrefs.SetInt("selectCharacter", selectCharacter);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
