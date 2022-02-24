using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour
{
    public GameObject bookInfo;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        bookInfo.SetActive(true);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        bookInfo.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        bookInfo.SetActive(true);
    }
}