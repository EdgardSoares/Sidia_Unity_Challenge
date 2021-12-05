﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState { START, PLAYER01TURN, PLAYER02TURN, CHECKROLLS, WON, LOST}
public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    Unit player01Unit;
    Unit player02Unit;

    CharacterGame player01Prefab;
    Player02Character player02Prefab;

    DiceRolls dice;
    public int finalSide = 0;
    //Player 01 Final Dices
    public int player01Dice01;
    public int player01Dice02;
    public int player01Dice03;

    public Text p1Dice01;
    public Text p1Dice02;
    public Text p1Dice03;

    //Player 02 final Dices
    public int player02Dice01;
    public int player02Dice02;
    public int player02Dice03;

    public Text p2Dice01;
    public Text p2Dice02;
    public Text p2Dice03;

    public int player01Win;
    public int player02Win;

    public Text totalPlayer01;
    public Text totalPlayer02;

    //Dados


    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        
        //player01Unit = player01Prefab.GetComponent<Unit>();
        //player01Unit = player02Prefab.GetComponent<Unit>();
        
        state = BattleState.PLAYER01TURN;        
        StartCoroutine(Player01DiceRolls());
    }


    //On Click para fazer rodar os dados
    public void OnMouseDown()
    {
        //RollDice();
        

    }
    //Metodo para rodar os dados
    public void RollDice()
    {

        int randimDiceSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randimDiceSide = Random.Range(0, 6);

        }

        finalSide = randimDiceSide + 1;
    }

    public IEnumerator Player01DiceRolls()
    {
        //Ira rodar 03 dados e salvar em tres variaveis os resultados
        RollDice();
        player01Dice01 = finalSide;
        p1Dice01.text = player01Dice01.ToString();
        finalSide = 0;        
        yield return new WaitForSeconds(1f);

        RollDice();
        player01Dice02 = finalSide;
        p1Dice02.text = player01Dice02.ToString();
        finalSide = 0;

        yield return new WaitForSeconds(1f);

        RollDice();
        player01Dice03 = finalSide;
        p1Dice03.text = player01Dice03.ToString();
        finalSide = 0;
        

        yield return new WaitForSeconds(1f);

        //Apos, trocar para o turno do jogador 02
        state = BattleState.PLAYER02TURN;
        StartCoroutine(Player02DiceRolls());        
    }

    IEnumerator Player02DiceRolls()
    {
        //Player 02 ira rodar 03 dados e salvar em tres variaveis os resultados

        RollDice();
        player02Dice01 = finalSide;
        p2Dice01.text = player02Dice01.ToString();
        finalSide = 0;
        yield return new WaitForSeconds(1f);

        RollDice();
        player02Dice02 = finalSide;
        p2Dice02.text = player02Dice02.ToString();
        finalSide = 0;

        yield return new WaitForSeconds(1f);

        RollDice();
        player02Dice03 = finalSide;
        p2Dice03.text = player02Dice03.ToString();
        finalSide = 0;

        yield return new WaitForSeconds(1f);

        //Chamar funcao para verificar os dados
        state = BattleState.CHECKROLLS;
        CheckRoll();
    }

    void CheckRoll()
    {
        //Pegar os valores de cada um e comparar e ver qual o maior, quem tiver mais pontos ganhos. Vence.
        //Verificando os primeiros dados
        if (player01Dice01 > player02Dice01)
        {
            player01Win = player01Win + 1;
        } else
        {
            player02Win = player02Win + 1;
        }

        //verificando o segundo dados
        if (player01Dice02 > player02Dice02 )
        {
            player01Win = player01Win + 1;
        }
        else
        {
            player02Win = player02Win + 1;
        }

        //verificando o terceiro dado
        if (player01Dice03 > player02Dice03)
        {
            player01Win = player01Win + 1;
        }
        else
        {
            player02Win = player02Win + 1;
        }

        totalPlayer01.text = player01Win.ToString();
        totalPlayer02.text = player02Win.ToString();

        //Se os pontos do player 01 for maior que o do player 02... Player 01 Vence, se nao, Player 02 vence
        if (player01Win > player02Win)
        {
            state = BattleState.WON;
            Won();
        }else
        {
            state = BattleState.LOST;
            Lost();
        }
       
        
        

    }

    void Won()
    {
        //O Player 01 venceu
        Debug.Log("Player 01 venceu!");
    }

    void Lost()
    {
        //Voce perdeu
        Debug.Log("Player 02 venceu!");
    }



}
