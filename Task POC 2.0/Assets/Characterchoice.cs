using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Characterchoice : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    


    void Start()
    {
        Random.Range(0, 1);

        bool x = spriteRenderer;

        if (x == false)
        {
            Color newColor = new Color(255, 0, 0, 0);

        }
        else if (x == true)
        {
            Color newColor = new Color(0, 0, 0, 0);

        }


    }

    
    void Update()
    {
        
        
    }
}
