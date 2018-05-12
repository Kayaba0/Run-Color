using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackers : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
   /* void Update() {
        Vector3 p = transform.position;
        p.x = p.x + 0.065f; //Velocità giusta della telecamera, controllare quando il player va a sbattere "di fronte" alla linea
        transform.position = p;
    }

    void Awake()
    {
        transform.position = new Vector3(0,0, -10);
        
    }
    */
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}
