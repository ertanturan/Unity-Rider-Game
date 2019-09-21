using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform Target;

	public Vector3 Offset;

	private void LateUpdate()
	{
		Vector3 newPos = Target.position + Offset;
		newPos.z = transform.position.z;

		transform.position = newPos;
	}

}
