using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startNewGame();
    }

    void startNewGame()
    {
        if (Input.GetKey(KeyCode.N))
        {
            Debug.Log("start NewGame");
            SceneManager.LoadScene("GameScene");

        }
    }
}
