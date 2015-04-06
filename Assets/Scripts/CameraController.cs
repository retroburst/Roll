using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	private Vector3 offset = Vector3.zero; 
	public GameObject player = null;

	void Start () {
		offset = transform.position;
	}

	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
