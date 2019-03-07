using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour {

    public ConfigurableJoint configJoint = null;
  //  ConfigurableJoint configJoints2 = null;


    // Use this for initialization
    void Start () {
       // Component[] configJoints;
       //
       // configJoints = GetComponents(typeof(ConfigurableJoint));
       //
       // foreach(ConfigurableJoint joint in configJoints)
       //     joint.targetRotation = Quaternion.Euler(0, 100, 0);
       //
       // configJoints1 = configJoints[0].GetComponent<ConfigurableJoint>();
       // configJoints2 = configJoints[1].GetComponent<ConfigurableJoint>();



    }

    // Update is called once per frame
    void Update () {

        
//        Quaternion right = Quaternion.Euler(0, gameObject.transform.rotation.y + 50, 0);
//        Quaternion left = Quaternion.Euler(0, gameObject.transform.rotation.y - 50, 0);


       if (Input.GetKey(KeyCode.Q))
       {
           
           configJoint.targetRotation = Quaternion.Euler(0, -100, 0);
           //configJoints2.targetRotation = Quaternion.Euler(0, -100, 0);
       
       }
       else if (Input.GetKey(KeyCode.E))
       {
           configJoint.targetRotation = Quaternion.Euler(0, 100, 0);
           //configJoints2.targetRotation = Quaternion.Euler(0, 100, 0);
       
       }
       else
       {
           configJoint.targetRotation = Quaternion.Euler(0, 0, 0);
           //configJoints2.targetRotation = Quaternion.Euler(0, 0, 0);
       
       }



    }
}
