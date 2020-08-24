using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMoveDownLogic : MonoBehaviour
{
    float transformSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveToBottom();
        lostGame();
    }

    void moveToBottom()
    {
        transform.Translate(0, -transformSpeed, 0);
    }

    void lostGame()
    {
        if (this.transform.position.y < -20.0f)
        {
            SceneManager.LoadScene("newGameScene");
        }
    }
}
