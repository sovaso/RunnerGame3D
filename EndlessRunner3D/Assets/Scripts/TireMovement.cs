using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(2,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > 0.55f)
  	    //this.transform.position = new Vector3(0.55f, this.transform.position.y, this.transform.position.z);
	    GetComponent<Rigidbody>().velocity = new Vector3(-1,0,0);
 
	if(this.transform.position.x < -0.55f)
  	    //this.transform.position = new Vector3(-0.55f, this.transform.position.y, this.transform.position.z);
	    GetComponent<Rigidbody>().velocity = new Vector3(1,0,0);
    }
}
