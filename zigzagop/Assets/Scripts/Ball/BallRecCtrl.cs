using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRecCtrl : MonoBehaviour
{
    public Vector3 ballDirection;
    private void Start()
    {
        ballDirection = Vector3.left;

    }
    private void Update()
    {
        HandleBallInputs();
    }
    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection()
    {
        if (ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }




}
