using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject spawnObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject newObject = Instantiate(spawnObject);
            newObject.transform.SetParent(transform);
            other.gameObject.transform.SetParent(transform);
        }
    }
}
