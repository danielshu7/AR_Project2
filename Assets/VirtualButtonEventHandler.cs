using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour
{
    public GameObject bookInfo;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Check: " + Vb.VirtualButtonName);
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        bookInfo.SetActive(false);
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