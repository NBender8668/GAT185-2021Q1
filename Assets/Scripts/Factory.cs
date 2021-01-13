using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{

    [SerializeField] GameObject prefab;

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject gameObject = Instantiate(prefab,this.transform,true);
            Destroy(gameObject, 1);
        }
    }
}
