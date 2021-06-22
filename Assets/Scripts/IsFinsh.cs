using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IsFinsh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //디버깅용
        if (Input.GetKey(KeyCode.F12))
        {
            SceneManager.LoadScene("Round2_1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene("Round2_1");        
        Debug.Log("끝!");
        }
    }
}
