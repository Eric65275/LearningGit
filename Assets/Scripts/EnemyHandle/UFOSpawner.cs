using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawner : MonoBehaviour
{
    public GameObject UFOPrefab;
    public static UFOSpawner instance;
    public float maxUFOAmount = 5;
    public float currentUFOAmount=0;

    

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

        float spawnPosition = Random.Range(-4f, 4f);
        if ( currentUFOAmount<maxUFOAmount)
        {
            float randomY = Random.Range(-4f, 4f);
            Vector3 spawnPoint = new Vector3(transform.position.x, randomY, transform.position.z);

            Instantiate(UFOPrefab, spawnPoint, transform.rotation);
            currentUFOAmount++;
        }
        
    }

}