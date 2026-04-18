using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    float speed= 0.1f;
    float backgroundWidth;



    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        backgroundWidth = sprite.texture.width/sprite.pixelsPerUnit;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x > backgroundWidth)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        
    }

}
