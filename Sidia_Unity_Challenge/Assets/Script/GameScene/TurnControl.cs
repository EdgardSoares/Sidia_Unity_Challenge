using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnControl : MonoBehaviour
{
    
    public Player02Character player02;
    //public GameObject p2;

    public PlayerController p1; //Para pegar o contador de Turnos do Player 01
    public Player02Controller p2;
    public CharacterGame p1p1;

    public bool isPlayer01turn;
    public bool isPlayer02Turn;



    // Update is called once per frame
    void Update()
    {
          
        
       /*if(isPlayer01turn == true)
        {
            isPlayer02Turn = false;
            player02.player2.GetComponent<Player02Controller>().enabled = false;
        }

        if (isPlayer02Turn == true)
        {
            isPlayer01turn = false;
            p1p1.player.GetComponent<PlayerController>().enabled = false;
        }*/

        if (p1.turnsCount == 3)
         {
            //Fim do turno do Player 01
            p1.turnsCount = 0;
             isPlayer01turn = false;
            //Desativar Texto do contador

             p1p1.player.GetComponent<PlayerController>().enabled = false; //Desativando o Script do Player 01

             isPlayer02Turn = true;            
             player02.player2.GetComponent<Player02Controller>().enabled = true; //Ativar o Script do Player 02

         }

         if (p2.p2TurnsCount == 3)
         {
            //Fim do Turno do Player 02
             p2.p2TurnsCount = 0;
             isPlayer02Turn = false;
             player02.player2.GetComponent<Player02Controller>().enabled = false;

             isPlayer01turn = true;
             p1p1.player.GetComponent<PlayerController>().enabled = true;           
         }


    }
}
