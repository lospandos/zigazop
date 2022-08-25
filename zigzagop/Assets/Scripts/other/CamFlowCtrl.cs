using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFlowCtrl : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    private Vector3 offset;
    private Vector3 newPosition;
    [SerializeField] [Range(0,3)] private float lerpValue;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        settCameraSmoothFllow();
    }

    private void settCameraSmoothFllow()
    {
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
       
}
