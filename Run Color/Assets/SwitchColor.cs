using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour {

    public Sprite Blue;
    public Sprite Green;
    public Sprite Orange;
    public Sprite Red;

    public float minSwipeDistY;
    public float minSwipeDistX;

    private Vector2 startPos;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.touchCount > 0)

        {

            Touch touch = Input.touches[0];



            switch (touch.phase)

            {

                case TouchPhase.Began:

                    startPos = touch.position;

                    break;



                case TouchPhase.Ended:

                    float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

                    if (swipeDistVertical > minSwipeDistY)

                    {

                        float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                        if (swipeValue > 0) //up swipe

                            print("SU");
                        //Jump ();

                        else if (swipeValue < 0)//down swipe

                            print("GIU");
                        //Shrink ();

                    }

                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

                    if (swipeDistHorizontal > minSwipeDistX)

                    {

                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                        if (swipeValue > 0)//right swipe
                            print("DESTRA");
                        //MoveRight ();

                        else if (swipeValue < 0)//left swipe
                            print("SINISTRA");
                        //MoveLeft ();

                    }
                    break;
            }
        }


            if (Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<SpriteRenderer>().sprite = Blue;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                GetComponent<SpriteRenderer>().sprite = Green;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                GetComponent<SpriteRenderer>().sprite = Orange;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                GetComponent<SpriteRenderer>().sprite = Red;
            }
        }
    }

