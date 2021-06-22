using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieAndClear : MonoBehaviour
{
    //public GameOverScreen GameOverScreen;
    public GameObject DieMessage;
    public GameObject ClearMessage;

    public GameObject Player;
    public Transform teleportPos;

    private bool isPlayerAlive = true;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !_GM.isGameClear)
        {
            //GameOverScreen.Setup();
            DieMessage.SetActive(true);
            isPlayerAlive = false;

            //움직임 고정
            Player.GetComponent<PlayerController>().enabled = false;
            Debug.Log("플레이어 사망");

        }

        else if (_GM.isGameClear && other.CompareTag("Player"))
        {
            ClearMessage.SetActive(true);
            isPlayerAlive = false;

            //움직임 고정
            Player.GetComponent<PlayerController>().enabled = false;
            Debug.Log("게임클리어");
        }
    }

    public void Update()
    {
        if (!isPlayerAlive)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Player.GetComponent<PlayerController>().enabled = true;
                isPlayerAlive = true;
                DieMessage.SetActive(false);
                //SceneManager.LoadScene("Round2_1");
                CharacterController cc = Player.GetComponent<CharacterController>();

                cc.enabled = false;
                Player.transform.position = teleportPos.transform.position;
                cc.enabled = true;
                Debug.Log("텔포");


            }
        }
        else
        {
            if (_GM.isGameClear && Input.GetKey(KeyCode.Return))
            {
                Debug.Log("타이틀화면으로");
                Player.GetComponent<PlayerController>().enabled = true;
                isPlayerAlive = true;                
                ClearMessage.SetActive(false);
                CharacterController cc = Player.GetComponent<CharacterController>();

                cc.enabled = false;

                //커서잠금해제
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("Title");
                //cc.enabled = true;


            }
        }
    }
}

