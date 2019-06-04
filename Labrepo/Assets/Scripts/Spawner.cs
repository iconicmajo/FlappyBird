using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePat;

    private float timeSpawn;
    public float StartSpawn;
    public float decrease;
    public float minTime = 0.65f;

    // Update is called once per frame
    private void Update()
    {
        if (timeSpawn <=0)
        {
            int rand = Random.Range(0, obstaclePat.Length);
            Instantiate(obstaclePat[rand], transform.position, Quaternion.identity);
            timeSpawn = StartSpawn;
            if(StartSpawn > minTime)
            {
                StartSpawn -= decrease;
            }
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }

    }
}
