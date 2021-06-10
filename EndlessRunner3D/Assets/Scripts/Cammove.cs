using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	// used to move character in forward way constantly
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
