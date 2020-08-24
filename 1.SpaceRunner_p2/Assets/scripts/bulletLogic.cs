using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    float bulletSpeed = 0.45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveBulletToTop();
        destroyBulletPathEnd();
    }

    void moveBulletToTop()
    {
        transform.Translate(0, bulletSpeed, 0);
    }

    void destroyBulletPathEnd()
    {
        if(this.transform.position.y > 20.0f)
        {
            Destroy(gameObject);
        }
    }

}
