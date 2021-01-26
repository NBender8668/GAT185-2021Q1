using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSpawnEverything : MonoBehaviour
{

    public GameObject spawnGameObject;
    public float lifetime = 5.0f;
    public bool useLifeTime = false;

    private void OnCollisionEnter(Collision collision)
    {
        
            Instantiate(spawnGameObject, transform);
            if(useLifeTime)
            {
                Destroy(spawnGameObject, lifetime);
               
            }
        
    }


}
