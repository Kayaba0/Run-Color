using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColorProperty : MonoBehaviour {

    private string color;
    public Sprite Blue;
    public Sprite Green;
    public Sprite Orange;
    public Sprite Red;


    public string getColor()
    {
        return color;
    }

    public void setColor(string NewColor)
    {
        color = NewColor;
    }

    public LineColorProperty()
    {
       
    }

    /*public LineColorProperty(string c)
    {
        color = c;
    }*/


    // Use this for initialization
    void Start () {
      /*  if(color.Equals("Red"))
           GetComponent<SpriteRenderer>().sprite = Red;

        if (color.Equals("Green"))
            GetComponent<SpriteRenderer>().sprite = Green;

        if (color.Equals("Blue"))
            GetComponent<SpriteRenderer>().sprite = Blue;

        if (color.Equals("Orange"))
            GetComponent<SpriteRenderer>().sprite = Orange;*/
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
