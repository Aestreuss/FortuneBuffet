using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.UI;

public class Randomizer : MonoBehaviour
{
    [Header("UI")]
    public Sprite[] sprites; //sprite array
    public Sprite rareLobster;

    public Image imageToChange;

    public GameObject certificate;

    Buffet playerIsClose;

    public Button rollForFood;

    [Header("Delay and Chance")]
    public int delayTime;

    public int rareLobsterChance;

    public void Update()
    {
        if (playerIsClose)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            rollForFood.onClick.AddListener(RandomizeImage);
        }
        

    }

    void RandomizeImage()
    {
        int randomIndex = Random.Range(0, sprites.Length);
        // if lobster is rolled
        if (randomIndex == 4)
        {
            StartCoroutine(RareLobster(randomIndex));
        }
        else
        {
            imageToChange.sprite = sprites[randomIndex];
        }
            
    }

    IEnumerator RareLobster(int randomIndex)
    {
        // rolls for chance to get different image
        int rollForLobster = Random.Range(0, 100);
        Debug.Log(rollForLobster);

        // if chance is met, rare image !!
        if(rollForLobster < rareLobsterChance)
        {
            imageToChange.sprite = rareLobster;
            yield return new WaitForSeconds(delayTime); //delays the certificate popping up after the lobster
            certificate.SetActive(true);
        }
        // otherwise idk
        else
        {
            imageToChange.sprite = sprites[randomIndex];
        }
        yield return null;
    }

    
}
