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

            //������ ����
            Player.GetComponent<PlayerController>().enabled = false;
            Debug.Log("�÷��̾� ���");

        }

        else if (_GM.isGameClear && other.CompareTag("Player"))
        {
            ClearMessage.SetActive(true);
            isPlayerAlive = false;

            //������ ����
            Player.GetComponent<PlayerController>().enabled = false;
            Debug.Log("����Ŭ����");
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
                Debug.Log("����");


            }
        }
        else
        {
            if (_GM.isGameClear && Input.GetKey(KeyCode.Return))
            {
                Debug.Log("Ÿ��Ʋȭ������");
                Player.GetComponent<PlayerController>().enabled = true;
                isPlayerAlive = true;                
                ClearMessage.SetActive(false);
                CharacterController cc = Player.GetComponent<CharacterController>();

                cc.enabled = false;

                //Ŀ���������
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("Title");
                //cc.enabled = true;


            }
        }
    }
}

