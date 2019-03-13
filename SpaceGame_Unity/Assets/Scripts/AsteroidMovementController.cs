using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovementController : MonoBehaviour {
    public float AsteroidSpeed = 2;
    public float AsteroidAngularSpeed = 2;
	public Vector3 InitialDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
		Vector3 direction3d = InitialDirection;
		if (direction3d.sqrMagnitude < Mathf.Epsilon * Mathf.Epsilon) {
			
			Vector2 direction2d = Random.insideUnitCircle;
			direction2d.Normalize ();
			direction3d = new Vector3 (direction2d.x, 0, direction2d.y);
		}

		var rb = GetComponent<Rigidbody> ();
		rb.velocity = direction3d * AsteroidSpeed;

		rb.angularVelocity = Random.onUnitSphere.normalized * AsteroidAngularSpeed;
	}
}
