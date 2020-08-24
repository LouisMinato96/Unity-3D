using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticleSystem : MonoBehaviour
{
    float suspendTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, suspendTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
