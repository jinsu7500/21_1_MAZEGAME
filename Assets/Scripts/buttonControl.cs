using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControl : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public GameObject menu_Image;

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx);
    }
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Round1");
    }
    public void ExitBtn()
    {
        Application.Quit();
    }

    public void ReturnBtn()
    {
        menu_Image.SetActive(false);
        tutorial.menu_bool = false;        

        //커서잠금해제    
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GotoTitleBtn()
    {
        SceneManager.LoadScene("Title");
    }


}
