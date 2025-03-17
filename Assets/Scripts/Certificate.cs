using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Certificate : MonoBehaviour
{
    public GameObject certificate;
    public Button closeButton;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        closeButton.onClick.AddListener(CloseCertificate);
    }

    void CloseCertificate()
    {
        certificate.SetActive(false);
        button.SetActive(false);

    }


}
