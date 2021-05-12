using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject Player;    

    //�÷��̾� ���
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
