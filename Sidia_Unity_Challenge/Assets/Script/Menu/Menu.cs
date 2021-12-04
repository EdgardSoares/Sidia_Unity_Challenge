using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject startBTN;
    public GameObject optionsBTN;
    public GameObject exitBTN;

    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    
    public void Options()
    {
        startBTN.SetActive(false);
        optionsBTN.SetActive(false);
        exitBTN.SetActive(false);


       
    }

    public void ExitGame()
    {

    }

  
}
