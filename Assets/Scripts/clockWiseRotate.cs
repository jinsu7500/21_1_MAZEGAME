using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockWiseRotate : MonoBehaviour
{
    
    private Quaternion currentRotation;
    private Quaternion targetRotation;    

    void Start()
    {
        currentRotation = transform.rotation;
        //currentRotation = rotateMap.GetComponent<Transform>().rotation;

        targetRotation = transform.rotation;
        //targetRotation = rotateMap.GetComponent<Transform>().rotation;
    }

    public void Rotate()
    {
        if (currentRotation == targetRotation)
        {
            targetRotation *= Quaternion.Euler(0, 0, 90.0f);
        }
    }

    public void RotateReverse()
    {
        if (currentRotation == targetRotation)
        {
            targetRotation *= Quaternion.Euler(0, 0, -90.0f);
        }
    }

    void Update()
    {
        ////작동코드 디버깅
        //if (Input.GetKey(KeyCode.F))
        //{
        //    Rotate();
        //}

        currentRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 30.0f * Time.deltaTime);

        transform.rotation = currentRotation;
        
    }

}
