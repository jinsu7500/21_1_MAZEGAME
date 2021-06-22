using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour
{
    public static int isRoundClear = 0;
    public static bool isGameClear = false;
    public GameObject Rador;


    // Start is called before the first frame update
    void Start()
    {
        isRoundClear = 0;
        isGameClear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRoundClear == 3)
        {
            Rador.SetActive(true);
            isGameClear = true;
        }
    }
}
