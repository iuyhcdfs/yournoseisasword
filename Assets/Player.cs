using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.UpArrow) == true)
			transform.position = transform.position + new Vector3(0, 0, 5 * Time.deltaTime); 
				
		if (Input.GetKey(KeyCode.DownArrow) == true)
			transform.position = transform.position - new Vector3(0, 0, 5 * Time.deltaTime);
		
		
	}
}
