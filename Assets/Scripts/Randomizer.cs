using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Randomizer : MonoBehaviour
{
    public Sprite[] sprites; //sprite array
    public Sprite rareLobster;

    public Image imageToChange;

    public int rareLobsterChance;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            RandomizeImage();
    }

    void RandomizeImage()
    {
        int randomIndex = Random.Range(0, sprites.Length);
        // if lobster is rolled
        if (randomIndex == 4)
        {
            RareLobster(randomIndex);
        }
        else
        {
            imageToChange.sprite = sprites[randomIndex];
        }
            
    }

    void RareLobster(int randomIndex)
    {
        // rolls for chance to get different image
        int rollForLobster = Random.Range(0, 100);
        Debug.Log(rollForLobster);

        // if chance is met, rare image !!
        if(rollForLobster < rareLobsterChance)
        {
            imageToChange.sprite = rareLobster;
        }
        // otherwise idk
        else
        {
            imageToChange.sprite = sprites[randomIndex];
        }
    }
}
