using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public Material[] material;
    public GameObject Elevator_Holder;
    public GameObject Player = null;

    [SerializeField] private Animator Elevator_animation = null;
    [SerializeField] private bool Elevator_Trigger = false;

    [SerializeField] private string Trigger_On = "Elvator_up";
    [SerializeField] private string Trigger_Off = "Elvator_Down";


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Elevator_Holder.GetComponent<MeshRenderer>().material = material[1];
            Elevator_Trigger = true;

            if (Elevator_Trigger)
            {
                //Player.transform.parent = Elevator_Holder.transform;
                Debug.Log("¿¤º£ ¿Â");
                Elevator_animation.Play(Trigger_On, 0, 0.0f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Elevator_Holder.GetComponent<MeshRenderer>().material = material[0];
            Debug.Log("¿¤º£ ¾Æ¿ô");
            Elevator_Trigger = false;
            //AnimatorStateInfo animInfo = Elevator_animation.GetCurrentAnimatorStateInfo(0);
            if (Elevator_Trigger != true)
            {
                //Player.transform.parent = null;
                Elevator_animation.Play(Trigger_Off, 0, 0.0f);
            }
        }
    }
}
