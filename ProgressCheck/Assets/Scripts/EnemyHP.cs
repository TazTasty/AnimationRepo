using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP: MonoBehaviour
{
    public int enemyHealth = 3;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            enemyHealth--;

            if (enemyHealth < 1)
                {
                    Destroy(gameObject);
                }
        }
       
    }
}
