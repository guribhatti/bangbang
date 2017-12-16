using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour {
    public float MovementSpeed = 1;
    public float MovementSpeed1 = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (transform.position.x >= -4.17 && transform.position.x <= 4.17) ;
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * MovementSpeed;
        float vertical = Input.GetAxisRaw("Vertical");
        if (transform.position.x >= -4.17 && transform.position.x <= 4.17) ;
        transform.position += new Vector3(0,vertical, 0) * Time.deltaTime * MovementSpeed1;

    }
}
