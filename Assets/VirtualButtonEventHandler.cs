using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour
{
    public GameObject bookInfo;
    public GameObject review;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        bookInfo.SetActive(true);
        review.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        bookInfo.SetActive(false);
        review.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        bookInfo.SetActive(true);
        review.SetActive(false);
    }
}