using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [Range(1,100)]public float speed = 10.0f;
    public AudioSource damageHit;
    public void Fire(Vector3 forward)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(forward * speed, ForceMode.VelocityChange);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            damageHit.Play();
        }
    }
}
