using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawn : MonoBehaviour {
    public Text textbox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //makes a textbox output the location of the ragdoll using raycast
        int layermask = 1 << 8;

        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,Mathf.Infinity,layermask))
        {
            Debug.Log(hit.transform.position);
            textbox.text = hit.transform.position.ToString();
        }
		
	}
}
