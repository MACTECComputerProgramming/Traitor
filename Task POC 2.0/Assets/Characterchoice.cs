using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Characterchoice : MonoBehaviour
{
    public GameObject characterPrefab;
    public Sprite[] characterSprites;

    public void TaggedPlayer()
    {
        int arrayIdk = Random.Range(0, characterSprites.Length);
    }


}
