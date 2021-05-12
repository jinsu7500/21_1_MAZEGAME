using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDie : MonoBehaviour
{
    //public GameOverScreen GameOverScreen;
    public GameObject DieMessage;
    public GameObject Player;
    public Transform teleportPos;

    private bool isPlayerAlive = true;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //GameOverScreen.Setup();
            DieMessage.SetActive(true);
            isPlayerAlive = false;

            //움직임 고정
            Player.GetComponent<PlayerController>().enabled = false;
            Debug.Log("플레이어 사망");
    
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
    }
}
