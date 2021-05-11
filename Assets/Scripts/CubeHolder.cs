using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootHolder : MonoBehaviour
{
    public Material[] material;
    public GameObject Foot_Holder;
    //public GameObject Foot_Holder_Trigger;
    //public GameObject Cube;
    
    //public bool triggerStay = false;

    [SerializeField] private Animator Plasama_Door_1 = null;
    [SerializeField] private bool Door_Trigger = false;
    [SerializeField] private float rotateSpeed = 2f;



    [SerializeField] private string Trigger_On = "Plasama_Door_Open";
    [SerializeField] private string Trigger_Off = "Plasama_Door_Close";


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Foot_Holder.GetComponent<MeshRenderer>().material = material[1];
            Door_Trigger = true;          
            
            if (Door_Trigger)
            {
                Debug.Log("발판 온");
                Plasama_Door_1.Play(Trigger_On, 0, 0.0f);
            }

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            //트리거 On일시 좌표 고정하고, 그자리에서 회전
            other.GetComponent<Transform>().Rotate(0f, rotateSpeed, 0f, Space.Self);               
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Foot_Holder.GetComponent<MeshRenderer>().material = material[0];
            Debug.Log("발판 아웃");
            Door_Trigger = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

            if (Door_Trigger != true)
            {
                Plasama_Door_1.Play(Trigger_Off, 0, 0.0f);
            }
        }
    }

    
}
