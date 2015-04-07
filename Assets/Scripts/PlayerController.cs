using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb = null;
	public float Speed = 0.0f;
	private int count = 0;
	public Text countText = null;
	public Text winText = null;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		if(countText != null) countText.text = BuildCountText ();
		if(winText != null) winText.enabled = false;
	}

	void Update () {
	
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (move * Speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Pickup") {
			other.gameObject.SetActive (false);
			count++;
			if(countText != null) countText.text = BuildCountText();
			if(count >= 6)
			{
				if(winText != null) winText.enabled = true;
			}
		}
	}

	private string BuildCountText()
	{
		return(string.Format("Count: {0}", count));
	}
}
