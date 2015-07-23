using UnityEngine;
using System.Collections;

/// <summary>
/// Rotator, responsible for rotating the
/// pickup object transform.
/// </summary>
public class Rotator : MonoBehaviour
{
	/// <summary>
	/// Update this instance.
	/// </summary>
	private void Update ()
	{
		transform.Rotate (new Vector3 (Random.Range (0, 100), Random.Range (0, 100), Random.Range (0, 100)) * Time.deltaTime);
	}
}
