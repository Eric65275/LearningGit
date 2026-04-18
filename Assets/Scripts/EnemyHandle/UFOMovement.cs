using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UFOMovement : MonoBehaviour
{
    float speed = 5;
    public bool UFOStopped = false;
    public float shootInterval = 2f;
    private float shootTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 4f)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        Vector3 currentUFOPosition = transform.position;
        UFOStopped = true;
        if (UFOStopped)
        {
            shootTimer += Time.deltaTime;

            if (shootTimer >= shootInterval)
            {
                UFOBulletSpawner.instance.Shoot(transform.position);
                shootTimer = 0f;
            }


        }
    }
}
