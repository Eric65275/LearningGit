using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UFOBulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public static UFOBulletSpawner instance;
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
        //if (UFOMovement.UFOStopped == true)
        //{
        //    Shoot();
        //}


    }
    public void Shoot(Vector3 UFOposition)
    {
        Instantiate(bulletPrefab, UFOposition, transform.rotation * Quaternion.Euler(0, 0, 90));

    }
}
