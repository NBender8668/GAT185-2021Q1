using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAnim : MonoBehaviour
{
    public GameObject destoryGameObject;
    
    public void DestoryEvent( float time)
    {
        Destroy(destoryGameObject, time);
        
    }
}
