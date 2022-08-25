using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionCtrl : MonoBehaviour
{
    [SerializeField] private GroundDataTransmiter groundDataTransmitter;
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
}
