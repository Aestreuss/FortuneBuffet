using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffet : MonoBehaviour
{
    public bool playerIsClose;

    Movement playerMovement;

    public GameObject gui;


    void MouseUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void MouseLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(true);
            playerIsClose = true;
            Debug.Log("close to buffet");
            playerMovement = other.GetComponent<Movement>();
            MouseUnlock();
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
            MouseLock();
        }

    }
}
