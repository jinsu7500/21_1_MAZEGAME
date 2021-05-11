using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarTelePort : MonoBehaviour
{
    public GameObject Player;
    public GameObject R3_EnterDoorTrigger;
    public GameObject LedDiplay;
    public Material[] material;

    
    public Transform teleportPos;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController cc = Player.GetComponent<CharacterController>();

            cc.enabled = false;
            Player.transform.position = teleportPos.transform.position;
            cc.enabled = true;
            Debug.Log("ÅÚÆ÷");

            LedDiplay.GetComponent<MeshRenderer>().material = material[1];
            R3_EnterDoorTrigger.SetActive(false);


        }
    }

}
