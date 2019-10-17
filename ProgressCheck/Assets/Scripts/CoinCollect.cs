using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class CoinCollect : MonoBehaviour
{
    public int coinpurse = 0;
    public Text coinText;

    void Start()
    {
        coinText.text = "Coins: " + coinpurse;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coinpurse++;
            coinText.text = "Coins: " + coinpurse;
            Destroy(collision.gameObject);
            
        }

    }
}
