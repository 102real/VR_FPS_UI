using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Intro,
        Playing,
        GameOver
    }
    public static GameState eGameStatus;
    public static int UIONOFF = 0;

   


    public delegate void EnemyHandler();
    public static event EnemyHandler EnemyDestroyed;

    public UnityEvent onStartActivated;

    public static int playerScore = 0;

    private void Start()
    {
        eGameStatus = GameState.Intro;
    }

    public static void EnemyHit()
    {

        if(eGameStatus == GameState.Playing)
        {
            playerScore += 100;
            EnemyDestroyed();
        }
        else
        {
            Debug.Log("플레이모드 아녀유");
        }
        
    }

    public void StartGame()
    {
        eGameStatus = GameState.Playing;
        onStartActivated.Invoke();
    }
}
