using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;
    public GameObject button;

    private void OnTriggerStay(Collider other)

    {
        //Debug.Log("triiger enter");
        if (Input.GetKey(KeyCode.G))
        {
            //Debug.Log("press G key");
            button.GetComponent<Animation>().Play("BtnOn");
            door.GetComponent<Animation>().Play("DoorOpen");
            

        }
    }



}
