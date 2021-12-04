using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public GameObject hightlight;

    void OnMouseEnter()
    {
        hightlight.SetActive(true);
    }

    void OnMouseExit()
    {
        hightlight.SetActive(false);
    }
}
