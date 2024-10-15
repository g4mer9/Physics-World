using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;
    public Transform death_portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeHealth(int changeHealth)
    {
        health += changeHealth;
        Debug.Log("My health has changed by " + changeHealth + " to " + health);
		// do VFX here

		if (health <= 0)
        {
            Debug.Log("I have died! Teleporting to death zone");
            GetComponent<CharacterController>().enabled = false;
            transform.SetPositionAndRotation(death_portal.position, Quaternion.identity);
			GetComponent<CharacterController>().enabled = true;
			// death VFX here
		}
        
    }
}
