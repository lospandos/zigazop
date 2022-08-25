using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveCtrl : MonoBehaviour
{
    [SerializeField] public BallDataTrans ballDataTrans;
    [SerializeField] public float ballMoveSpeed;


    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {

        transform.position += ballDataTrans.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
