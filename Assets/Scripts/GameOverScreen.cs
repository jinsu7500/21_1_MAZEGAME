using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject Player;    

    //플레이어 사망
    public void Setup()
    {
        gameObject.SetActive(true);
        Player.GetComponent<PlayerController>().enabled = false;
     
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("Round2_1");
        }
    }
}
