using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Blueprint : MonoBehaviour
{
    private float speed;
    public float Speed
    {
        get { return speed; }

        set
        {
            if (value < 0)
            {
                Debug.Log("speed not allowed");
            }
            else if(value > 0)
            {
                speed = value;
            }
        }
    }

    private float force;
    public float Force
    {
        get { return force; }
        set
        {
            if (value < 0)
            {
                Debug.Log("Force is not allowed");
            }

            else if(value > 0)
            {
                force = value;
            }
        }
    }

    public abstract void Move();
    
}
