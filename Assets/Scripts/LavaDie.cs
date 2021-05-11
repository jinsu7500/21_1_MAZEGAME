using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDie : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameOverScreen.Setup();
            Debug.Log("�÷��̾� ���");
    
        }
    }
}
