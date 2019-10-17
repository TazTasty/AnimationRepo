using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > shootDelay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //get mouse position from x,y pixels on the screen
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("Mouse position 1: " + mousePosition);
            //convert x,y pixels to game world position
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("Mouse position 2: " + mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, 
                mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            Debug.Log("shootDir = " + shootDirection);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
} 
