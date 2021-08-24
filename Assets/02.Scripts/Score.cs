using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.EnemyDestroyed += DisplayScore;
    }

    private void OnDisable()
    {
        GameManager.EnemyDestroyed -= DisplayScore;
    }

    private void DisplayScore()
    {
        Debug.Log("Score: " + GameManager.playerScore);
    }
}
