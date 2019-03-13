using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {
	public string TagToHit = "Asteroid";

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag(TagToHit))
		{
			Destroy(gameObject);
			HitReceiver hitReceiver = collision.gameObject.GetComponent<HitReceiver> ();
			if (hitReceiver) {
				hitReceiver.ReceiveHit (gameObject);

			} else {
				Destroy (collision.gameObject);
			}
		}
	}
}
