using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollison : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyExplosinon;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Destroy(collision.gameObject);

            Instantiate(enemyExplosinon, collision.gameObject.transform.position, collision.transform.rotation);

            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
