using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitDoor : MonoBehaviour
{
    public Button exitGame;
    public Button goMenu;
    public GameObject gui;

    public bool playerIsClose;

    Movement playerMovement;

    void Start()
    {
        exitGame.onClick.AddListener(CloseGame);
        goMenu.onClick.AddListener(Menu);

    }
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

    void CloseGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }

    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(true);
            playerIsClose = true;
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
            playerMovement = null;
            MouseLock();
        }
    }
}