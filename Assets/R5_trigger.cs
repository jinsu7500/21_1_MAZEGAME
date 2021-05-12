using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R5_trigger : MonoBehaviour
{
    public Material[] material;
    public GameObject footholder;

    private void OnTriggerEnter(Collider other)
    {
        footholder.GetComponent<MeshRenderer>().material = material[1];
        //사운드추가
    }

    private void OnTriggerExit(Collider other)
    {
        footholder.GetComponent<MeshRenderer>().material = material[0];
    }

}
