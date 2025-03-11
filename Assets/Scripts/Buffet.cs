using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffet : MonoBehaviour
{
    public bool playerIsClose;

    Movement playerMovement;

    public GameObject gui;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(true);
            playerIsClose = true;
            Debug.Log("close to buffet");
            playerMovement = other.GetComponent<Movement>();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(false);
            playerIsClose = false;
            Debug.Log("away from buffet");
            playerMovement = null;
        }

    }
}
