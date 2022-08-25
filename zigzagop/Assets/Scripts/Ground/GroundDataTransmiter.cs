using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmiter : MonoBehaviour
{
    [SerializeField] private GroundFallCtrl groundFallController;

    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValue());
    }


}
