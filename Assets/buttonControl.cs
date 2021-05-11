using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControl : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

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


}
