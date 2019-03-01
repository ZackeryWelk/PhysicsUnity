using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent (typeof(CharacterController))]
[RequireComponent(typeof(Animator))]


public class characterCon : MonoBehaviour {
    CharacterController controller = null;
    Animator animator = null;


    public float speed;
    public float pushPower;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");


        controller.SimpleMove(transform.up * Time.deltaTime);
        //transform.Rotate(transform.up, horizontal * speed * Time.deltaTime);
        //animator.SetFloat("speed", vertical * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.up, horizontal * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up, horizontal * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("speed", vertical * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("speed", vertical * speed * Time.deltaTime);
        }
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if(body == null || body.isKinematic)
        { return; }
        if(hit.moveDirection.y < -0.3f)
        { return; }

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
    }
}
