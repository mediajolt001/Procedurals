using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TforTime : MonoBehaviour
{
    //a calculation made every frame
    //start at 0 and end at 1.
    //For every frame, the value between 0 and 1 changes until it reaches 1
    //specify the rate at which those changes happen from frame to frame.
    //private float start = 0;
    private float end = 1;
    private float interval = 0;
    private float speed = 90; //this is the number of frames that this will take to transition between 0 and 1

    public void Start()
    {

    }

    public void Timer()
    {

    }

    public void Update()
    {
        while (interval < end)//interval is used to track the changes from its starting value (0) to end
                              //as long as it is less than the end value, this loop will run
        {
            //this loop needs to iterate interval from start by a certain amount
            //every frame for 90 frames without going over end

        }
    }

}
