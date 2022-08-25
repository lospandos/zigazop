using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTrans : MonoBehaviour
{
    [SerializeField] private BallRecCtrl ballRecCtrl;

    public Vector3 GetBallDirection()
    {
        return ballRecCtrl.ballDirection;
    }
   
}
