using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;
    public int lives = 3;

    private void Start()
    {
        healthText.text = "HP: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        lives = PlayerPrefs.GetInt("Lives");
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "enemybullet")
        {
            health--;
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            if (health < 1)
            {
                if (lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("Lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            if(health < 1)
            {
               
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         
            }

        }
    
    }
   
    
}
