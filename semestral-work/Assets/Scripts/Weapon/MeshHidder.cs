using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRInteractorLineVisual))]
public class MeshHidder : MonoBehaviour
{
    private XRInteractorLineVisual rayInteractor;

    void Awake()
    {
        rayInteractor = GetComponent<XRInteractorLineVisual>();
    }

    public void Show()
    {
        rayInteractor.lineLength = 1;

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void Hide()
    {
        rayInteractor.lineLength = 0;

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}