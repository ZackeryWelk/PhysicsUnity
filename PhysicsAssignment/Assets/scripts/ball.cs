using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    private float thrust = 2;

    public Rigidbody m_rigidBody;


    // Use this for initialization
    void Start () {
        m_rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //controls for the flying prism
		if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(1.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-1.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -1.5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, 1.5f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_rigidBody.AddForce(transform.forward * thrust, ForceMode.Impulse);
        }


    }
}
