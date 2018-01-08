using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	private Vector3 mouse_position,save_position;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown(){
		mouse_position =  Camera.main.WorldToScreenPoint(this.transform.position);
		save_position = this.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
		save_position.z = this.transform.position.z;
	}

	void OnMouseDrag(){
		Vector3 current_point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouse_position.z);
		Vector3 current_position = Camera.main.ScreenToWorldPoint(current_point) + save_position;
		current_position.z = this.transform.position.z;
		this.transform.position = current_position;
	}
}
