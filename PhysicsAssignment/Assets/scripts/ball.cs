using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public float thrust;

    public Rigidbody m_rigidBody;


    // Use this for initialization
    void Start () {
        m_rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
        {
            m_rigidBody.rotation = Quaternion.Euler(m_rigidBody.rotation.x, m_rigidBody.rotation.y, m_rigidBody.rotation.z + 1.5f);
         //   transform.Rotate(0f, 0f, 1.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0f, 0f, -1.5f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(1.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-1.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_rigidBody.AddForce(-transform.right * thrust * Time.deltaTime);
        }


    }
}
