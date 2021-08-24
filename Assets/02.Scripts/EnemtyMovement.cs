using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtyMovement : MonoBehaviour
{
    [Header("Control the Speed of Enemy")]
    public float maxSpeed;
    public float minSpeed;



    public Vector3 movementDriection;

    private float _enemyspeed = 1;
    void Start()
    {
        _enemyspeed = Random.Range(minSpeed, maxSpeed);

   


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDriection * Time.deltaTime * _enemyspeed);
    }
}
