using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackers : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        Vector3 p = transform.position;
        p.x = p.x + 0.05f;
        transform.position = p;
    }

    void Awake()
    {
        transform.position = new Vector3(0,0, -10);
        
    }

}
