using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    public GameObject tutorial_Image;
    public GameObject menu_Image;
    public bool tutorial_bool = true;
    public static bool menu_bool = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorial_bool)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                tutorial_Image.SetActive(false);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.F1))
        {
            menu_bool = !menu_bool;

            if (menu_bool)
            {
                //커서잠금해제

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                menu_Image.SetActive(true);
            }
            else
            {
                //커서잠금
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                menu_Image.SetActive(false);
            }               
           
            
            
        }
        
    }






}
