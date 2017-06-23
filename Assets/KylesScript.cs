using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KylesScript : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space was Pressed.");
            if (rb != null)
            {
                rb.AddForce(new Vector3(1000, 1000, 1000) * Time.deltaTime);
            }
        }
    }
}
