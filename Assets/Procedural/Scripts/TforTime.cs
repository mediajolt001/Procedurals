using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TforTime : MonoBehaviour
{
    protected float T; //protected 
    
    public void Start()
    {
        T = 0.0f;
    }

    public void Update()
    {
        T += Time.deltaTime;
        if (T >= 1.0f)
        {
            T = 1.0f;
        }
    }

}
