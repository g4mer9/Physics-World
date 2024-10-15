using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
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
            other.gameObject.GetComponent<PlayerHealth>().ChangeHealth(-5);
        Debug.Log("Entered: " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
