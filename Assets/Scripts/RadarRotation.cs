using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarRotation : MonoBehaviour
{
    public GameObject Radar;
    public float RotateSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Radar.transform.Rotate(0f, RotateSpeed, 0f, Space.Self);
    }
}
