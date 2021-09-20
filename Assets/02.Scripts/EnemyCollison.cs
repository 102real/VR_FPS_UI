using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollison : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("ÆÄ±¥");

            Destroy(collision.gameObject);
            Destroy(gameObject);

            GameManager.EnemyHit();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
