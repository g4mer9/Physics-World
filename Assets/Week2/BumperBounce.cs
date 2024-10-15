using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBounce : MonoBehaviour
{

	private void OnCollisionEnter(Collision collision)
	{
        Debug.Log(collision.relativeVelocity.magnitude);
		if (collision.relativeVelocity.magnitude > 1) // if force is enough to trigger reaction
		{
			Vector3 contactPoint;
			//contactPoint = collision.GetContact(0).point;
			contactPoint = transform.position;

			//collision.rigidbody.AddExplosionForce(50, contactPoint, 20);




			
			// Print how many points are colliding with this transform
			Debug.Log("Points colliding: " + collision.contacts.Length);

			// Print the normal of the first point in the collision.
			Debug.Log("Normal of the first point: " + collision.contacts[0].normal);

			// Draw a different colored ray for every normal in the collision
			foreach (var item in collision.contacts)
			{
				Debug.DrawRay(item.point, -item.normal * 100, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f), 10f);
				collision.rigidbody.AddForce(-item.normal, ForceMode.Impulse);
			}
			

		}
	}
}
