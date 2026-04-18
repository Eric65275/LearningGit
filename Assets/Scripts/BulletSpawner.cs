using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public static BulletSpawner instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot()
    {
        Instantiate(bulletPrefab,transform.position,transform.rotation * Quaternion.Euler(0, 0, -90));
    }
}
