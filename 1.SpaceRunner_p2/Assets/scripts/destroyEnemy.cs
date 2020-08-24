using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    public GameObject blastEnemy;
    scoreLogic addToScore;
    
    void Start()
    {
        
    }
     
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if(transformCollision.gameObject.tag == "Collision")
        {
            spawnParticle(transformCollision.transform.position);

            Destroy(transformCollision.gameObject);

            callScoreLogicScript();
        }
    }

    void spawnParticle(Vector2 tempPosition)
    {
        Instantiate(blastEnemy, tempPosition, Quaternion.identity);
    }

    void callScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<scoreLogic>();
        addToScore.addToScoreVOID();
    }
}
