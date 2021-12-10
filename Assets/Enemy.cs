using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    float state;
    float walktimer;
    float idletimer;

    Vector2 rotation = Vector2.zero;
    public float speed = 3;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 0)
        {
            idle();
        }
        if (state == 1)
        {
            walk();
        }



    }

    void idle()
    {
        walktimer = 10;
        if (idletimer < 0)
        { 
            state = 1;
        }

        idletimer -= Time.deltaTime;
    }

    void walk()
    {
        idletimer = 5;
        walktimer -= Time.deltaTime;

        if (walktimer < 0)
        {
            state = 0;
        }

        Vector3 v3Force = 1 * transform.forward;
        GetComponent<Rigidbody>().AddForce(v3Force.normalized, ForceMode.Impulse);


    }
}
