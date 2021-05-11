using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAuto : MonoBehaviour
{
    public GameObject door;
    

    private void OnTriggerEnter(Collider other)
    {      
        door.GetComponent<Animation>().Play("DoorOpen_");        
    }

}
