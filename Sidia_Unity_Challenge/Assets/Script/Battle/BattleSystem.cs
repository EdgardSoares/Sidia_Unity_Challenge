using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYER01TURN, PLAYER02TURN, CHECKROLLS, WON, LOST}
public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    Unit player01Unit;
    Unit player02Unit;

    CharacterGame player01Prefab;
    Player02Character player02Prefab;

    //Dados


    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        
        player01Unit = player01Prefab.GetComponent<Unit>();
        player01Unit = player02Prefab.GetComponent<Unit>();

        state = BattleState.PLAYER01TURN;
        Player01DiceRolls();
    }

    IEnumerator Player01DiceRolls()
    {
        //Ira rodar 03 dados e salvar em tres variaveis os resultados

        yield return new WaitForSeconds(2f);

        //Apos, trocar para o turno do jogador 02
        state = BattleState.PLAYER02TURN;
        Player02DiceRolls();        
    }

    IEnumerator Player02DiceRolls()
    {
        //Player 02 ira rodar 03 dados e salvar em tres variaveis os resultados

        yield return new WaitForSeconds(2);

        //Chamar funcao para verificar os dados
        state = BattleState.CHECKROLLS;
        CheckRoll();
    }

    void CheckRoll()
    {
        //Pegar os valores de cada um e comparar e ver qual o maior, quem tiver mais pontos ganhos. Vence

        //Se o player01 tiver mais pontos ele vence
        state = BattleState.WON;
        Won();

        //Se o player02 tiver mais pontos ele vence
        state = BattleState.LOST;
        Lost();

    }

    void Won()
    {
        //O Player 01 venceu
    }

    void Lost()
    {
        //Voce perdeu
    }



}
