using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Player controller, responsible
/// for controlling the player ball
/// calculating physics and applying
/// forces.
/// </summary>
public class PlayerController : MonoBehaviour
{
	private const string TAG_PICKUP = "Pickup";
	private const string AXIS_HORIZONTAL = "Horizontal";
	private const string AXIS_VERTICAL = "Vertical";
	private Rigidbody rb = null;
	public float Speed = 0.0f;
	private int count = 0;
	public Text countText = null;
	public Text winText = null;

	/// <summary>
	/// Start this instance.
	/// </summary>
	private void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		if (countText != null)
			countText.text = BuildCountText ();
		if (winText != null)
			winText.enabled = false;
	}
	
	/// <summary>
	/// Fixed update for physics calculations.
	/// </summary>
	private void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis (AXIS_HORIZONTAL);
		float moveVertical = Input.GetAxis (AXIS_VERTICAL);
		Vector3 move = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (move * Speed * Time.deltaTime);
	}

	/// <summary>
	/// Raises the trigger enter event.
	/// </summary>
	/// <param name="other">Other.</param>
	private void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == TAG_PICKUP) {
			other.gameObject.SetActive (false);
			count++;
			if (countText != null) {
				countText.text = BuildCountText ();
			}
			if (count >= 6) {
				if (winText != null) {
					winText.enabled = true;
				}
			}
		}
	}
	
	/// <summary>
	/// Builds the count text.
	/// </summary>
	/// <returns>The count text.</returns>
	private string BuildCountText ()
	{
		return(string.Format ("Count: {0}", count));
	}
}
