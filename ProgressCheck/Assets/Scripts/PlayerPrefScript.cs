using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefScript : MonoBehaviour
{
    public float number = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("number") != 0)
        {
            number = PlayerPrefs.GetFloat("number");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            number--;
            PlayerPrefs.SetFloat("number", number);
            Debug.Log(number);
        }    
    }
}
