using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        if (moveHorizontal > 0)
        {
            transform.Translate(new Vector3(0.2f, 0, 1) * Time.deltaTime*speed);
        }
        else if (moveHorizontal < 0)
        {
            transform.Translate(new Vector3(-0.2f, 0, 1) * Time.deltaTime * speed);
        }

        float moveVertical = Input.GetAxis("Vertical");
        if (moveVertical > 0)
        {
            transform.Translate(new Vector3(0, 0.2f, 1) * Time.deltaTime * speed);
        }
        else if (moveVertical < 0)
        {
            transform.Translate(new Vector3(0, -0.2f, 1) * Time.deltaTime * speed);
        }
        if (Input.GetMouseButtonDown(1))
        {
            BulletSpawner.instance.Shoot();
        }
    }
}
