using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPace : MonoBehaviour
{
    float timer = 0.0f;
    public Vector2 moveDir;
    public float moveSpeed = 5.0f;
    public float paceLength = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //moveDir = new Vector2(1, 0);
        moveDir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3)
        {
            //do something
            moveDir *= -1;
            timer = 0;
        }
        GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
    }
}
