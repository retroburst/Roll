using UnityEngine;
using System.Collections;

/// <summary>
/// Camera controller. Responsible for
/// moving the camera with the player
/// object.
/// </summary>
public class CameraController : MonoBehaviour
{
	private Vector3 offset = Vector3.zero;
	public GameObject player = null;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	private void Start ()
	{
		// set the offset to the camera's default transform position
		offset = transform.position;
	}
	
	/// <summary>
	/// Late update. Sets position
	/// based on the player object.
	/// </summary>
	private void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}
