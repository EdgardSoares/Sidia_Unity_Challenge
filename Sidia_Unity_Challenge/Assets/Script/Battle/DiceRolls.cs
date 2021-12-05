using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRolls : MonoBehaviour
{
    private Sprite[] LadosDoDado;

    private MeshRenderer rend;

    public int finalSide = 0;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();

        
    }
    public void OnMouseDown()
    {
        RollDice();       

    }

    public void RollDice()
    {
        
        int randimDiceSide = 0;        

        for (int i = 0; i <= 20; i++)
        {
            randimDiceSide = Random.Range(0, 6);
                                    
        }

        finalSide = randimDiceSide + 1;
        
    }

}
