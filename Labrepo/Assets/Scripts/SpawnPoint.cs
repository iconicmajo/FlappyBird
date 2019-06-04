using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obstacle1;



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle1, transform.position, Quaternion.identity);
   ;
    }

  
}
