using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject startBTN;
    public GameObject optionsBTN;
    public GameObject exitBTN;
    public GameObject backBTN;

    public GameObject canvas;
    public GameObject soundTXT;
    public GameObject resolutionTXT;
    public GameObject enable;
    public GameObject disable;
    public GameObject enableBTN;
    public GameObject disableBTN;

    public AudioSource clickSound;
    public GameObject music;

    void Start()
    {
        clickSound = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);

    }
    
    public void Options()
    {
        startBTN.SetActive(false);
        optionsBTN.SetActive(false);
        exitBTN.SetActive(false);
        backBTN.SetActive(true);

        canvas.SetActive(true);
        resolutionTXT.SetActive(true);
        soundTXT.SetActive(true);

        enable.SetActive(true);
        enableBTN.SetActive(true);
        disable.SetActive(true);
        disableBTN.SetActive(true);




    }

    public void Back()
    {
        backBTN.SetActive(false);

        startBTN.SetActive(true);
        optionsBTN.SetActive(true);
        exitBTN.SetActive(true);
        
        resolutionTXT.SetActive(false);
        soundTXT.SetActive(false);

        enable.SetActive(false);
        enableBTN.SetActive(false);
        disable.SetActive(false);
        disableBTN.SetActive(false);

    }

    public void EnableBTN()
    {
        music.SetActive(true);
    }

    public void DisableBTN()
    {      
        music.SetActive(false);
        
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void OnMouseDown()
    {
        clickSound.Play();
    }


}
