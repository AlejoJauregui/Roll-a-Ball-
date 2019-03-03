using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstanceObjects : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObjects;
    // Start is called before the first frame update
    void Start()
    {
        instanceObjToCollect(prefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void instanceObjToCollect(GameObject objToInstance)
    {
        
        for(int i=0; i< numberOfObjects;i++)
        {
           Vector3 randomPostion = new Vector3 (Random.Range(-8,8), 0.5f, Random.Range(-8,8)) ;
           Instantiate (prefab, randomPostion, Quaternion.identity);
        }
    }
}
