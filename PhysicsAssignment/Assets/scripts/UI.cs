using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {
    public GameObject body;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Ragdoll()
    {
        Ragdoll ragdoll = body.GetComponent<Ragdoll>();
        ragdoll.ragdollOn = true;
        ParticleSystem particleSystem = body.GetComponentInChildren<ParticleSystem>();
        particleSystem.Play();
    }

    public void Stop()//stops walking 
    {
        Animator anim = body.GetComponent<Animator>();
        anim.SetBool("stop", true);
    }
    public void startWalking()
    {
        Animator anim = body.GetComponent<Animator>();
        anim.SetBool("stop", false);
    }
}
