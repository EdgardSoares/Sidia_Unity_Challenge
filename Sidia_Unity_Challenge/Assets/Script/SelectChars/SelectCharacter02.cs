using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectCharacter02 : MonoBehaviour
{
    public GameObject[] player2Characters;
    public int selectPlayer02 = 0;

    public GameObject selectPlayerBTN;

    




    public void NextBTN()
    {
        player2Characters[selectPlayer02].SetActive(false);
        selectPlayer02 = (selectPlayer02 + 1) % player2Characters.Length;
        player2Characters[selectPlayer02].SetActive(true);
        

    }

    public void PreviousBTN()
    {
        player2Characters[selectPlayer02].SetActive(false);
        selectPlayer02--;
        if (selectPlayer02 < 0)
        {
            selectPlayer02 += player2Characters.Length;
        }
        player2Characters[selectPlayer02].SetActive(true);
    }

    public void SelectPlayer02()
    {
        PlayerPrefs.SetInt("selectPlayer02", selectPlayer02);
        selectPlayerBTN.SetActive(false);

    }

    public void StartGame()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
}
