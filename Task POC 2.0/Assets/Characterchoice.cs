using UnityEngine;
using System.Collections;

public class Characterchoice : MonoBehaviour
{
    public GameObject characterPrefab;
    public Sprite[] characterSprites;

    public void ChooseTaggedPlayer()
    {
        int arrayIdx = Random.Range(0, characterSprites.Length);
        Sprite characterSprite = characterSprites[arrayIdx];

        GameObject newCharacter = Instantiate(characterPrefab);
        newCharacter.GetComponent<SpriteRenderer>().sprite = characterSprite;


    }
    

}
