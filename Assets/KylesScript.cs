using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KylesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A was Pressed.");
        }
    }
}
