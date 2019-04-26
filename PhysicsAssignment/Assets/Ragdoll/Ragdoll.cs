using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class Ragdoll : MonoBehaviour {

    public List<Rigidbody> rigidbodies = new List<Rigidbody>();

    private Animator animator = null;

    public bool ragdollOn
    {
        get { return !animator.enabled;}
        set
        {//makes the ragdoll enter ragdoll and stop running the animation
            animator.enabled = !value;
            foreach(Rigidbody r in rigidbodies)
                r.isKinematic = !value;
        }
    }
	// Use this for initialization
	void Start () {
        //makes all the parts of the ragdoll kinematic
        animator = GetComponent<Animator>();
        foreach(Rigidbody r in rigidbodies)
            r.isKinematic = true;
        
	}
	
	// Update is called once per frame
	void Update () {
	}
}
