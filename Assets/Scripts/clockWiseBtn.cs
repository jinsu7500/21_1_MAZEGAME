using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockWiseBtn : MonoBehaviour
{
    public GameObject RotateMap;
    public bool isClockwise = true;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("접근");
            if (Input.GetKey(KeyCode.G) && isClockwise)
            {
                //Debug.Log("회전함수호출");
                clockWiseRotate rtm = RotateMap.GetComponent<clockWiseRotate>();
                rtm.Rotate();
            }

            else if(Input.GetKey(KeyCode.G) && !isClockwise)
            {
                //Debug.Log("반회전함수호출");
                clockWiseRotate rtm = RotateMap.GetComponent<clockWiseRotate>();
                rtm.RotateReverse();
            }
        }
    }
}
