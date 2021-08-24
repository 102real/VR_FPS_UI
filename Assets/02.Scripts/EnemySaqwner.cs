using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySaqwner : MonoBehaviour
{
    [Header("Size of the spawn area")]
    public Vector3 size;

    [Header("Rate of instantiation")]
    public float spawnRate = 1f;

    [Header("Model used to instantiation")]
    public GameObject enemyModel;

    [Header("Enemy Parent")]
    public Transform enemyParent;

    private float nextSpawn = 0f;
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0,1,0,0.5f);
        Gizmos.DrawCube(transform.position, size);
    }

    private void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            spawnAnEnemy();
        }
    }

    private void spawnAnEnemy()
    {
        Vector3 spawnPoint = transform.position + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                                                              Random.Range(-size.y / 2, size.y / 2),
                                                              Random.Range(-size.z / 2, size.z / 2));

        //Quaternion enemyRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

        GameObject enemy = Instantiate(enemyModel, spawnPoint, transform.rotation);

        enemy.transform.SetParent(enemyParent);
    }
}
