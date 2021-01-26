using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;

    public float fireRate = 0.1f;
    int ammo = 100;
    float fireTimer = 0;


    void Update()
    {
        fireTimer += Time.deltaTime;

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    // Vector3 direction = (point - transform.position).normalized;

        //    GameObject gameObject = Instantiate(bullet, transform.position, Quaternion.identity);
        //    gameObject.GetComponent<Bullet>().Fire(ray.direction);

        //    Destroy(gameObject, 5);

        //}
    }

    public bool Fire(Vector3 position, Vector3 direction)
    {
        if(fireTimer >= fireRate)
        {
            fireTimer = 0;
            GameObject gameObject = Instantiate(this.bullet, position, Quaternion.identity);
             gameObject.GetComponent<Bullet>().Fire(direction);

            return true;

        }

        return false;
        
    }
}
