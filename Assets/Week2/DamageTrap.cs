using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrap : MonoBehaviour
{
	[SerializeField] private int healthChange = -5;
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			{
				other.GetComponent<PlayerHealth>().ChangeHealth(healthChange);
			}
		
	}
}
