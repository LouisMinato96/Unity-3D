using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerlogic : MonoBehaviour
{
    public GameObject Bullet;

    float playerSpeed = 0.5f;
    float boundaryLimits = 35.0f;

    float shootingSpeed = 0.05f;

    bool isShooting = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletShootTimer());
    }

    // Update is called once per frame
    void Update()
    {
        playerMovemnt();
    }

    void playerMovemnt()
    {
        if (Input.GetKey(KeyCode.D) && (transform.position.x <= boundaryLimits))
        {
            transform.Translate(playerSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && (transform.position.x >= -boundaryLimits))
        {
            transform.Translate(-playerSpeed, 0, 0);
        }
    }

    IEnumerator bulletShootTimer()
    {
        while (isShooting == true)
        {
            spawnBullet();
            yield return new WaitForSeconds(shootingSpeed);
        }
    }

    void spawnBullet()
    {
        Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y + 4, 0), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collisionListener)
    {
        if(collisionListener.gameObject.tag == "Collision")
        {
            SceneManager.LoadScene("newGameScene");
        }
    }
}
