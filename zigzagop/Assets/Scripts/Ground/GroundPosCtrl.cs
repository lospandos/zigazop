using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPosCtrl : MonoBehaviour
{
    private GroundSpawnCtrl groundSpawnCtrl;
    private Rigidbody rb;
    [SerializeField] private float endValue;
    private int groundDirection;
    private void Start()
    {
        groundSpawnCtrl = FindObjectOfType<GroundSpawnCtrl>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        CheckGroundVerticalPosition();
    }


    private void SetGroundNewPosition()
    {
        groundDirection = Random.Range(0, 2);
        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawnCtrl.lastGroundObject.transform.position.x - 1f, groundSpawnCtrl.lastGroundObject.transform.position.y, groundSpawnCtrl.lastGroundObject.transform.position.z);

        }
        else
        {
            transform.position = new Vector3(groundSpawnCtrl.lastGroundObject.transform.position.x, groundSpawnCtrl.lastGroundObject.transform.position.y, groundSpawnCtrl.lastGroundObject.transform.position.z + 1f);

        }

        groundSpawnCtrl.lastGroundObject = gameObject;
    }



    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <= endValue)
        {
            SetRigidbodyValue();
            SetGroundNewPosition();

        }
    }




    private void SetRigidbodyValue()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }


}
