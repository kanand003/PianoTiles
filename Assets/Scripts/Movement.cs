using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed;
    public Rigidbody rb;
    private Touch touch;
    private float touchspeed;
    private float Ani;
    
    private void Start()
    {
        touchspeed = 0.01f;
        speed = 7f;
    }
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.deltaTime;
        //Vector3 upmove=transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        rb.MovePosition(rb.position + forwardMove);
        //transform.Translate(0, 2.5f, 6f);
        //Ani += Time.deltaTime;
        //Ani = Ani % 5f;

        //transform.position = MathParabola.Parabola(Vector3.zero, Vector3.forward * 10f, 5f, Ani);
    }
    private void Update()
    {
        if(Input.touchCount>0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved)
            {
                transform.position = new Vector3(
               transform.position.x + touch.deltaPosition.x * touchspeed,
               transform.position.y,
               transform.position.z);
            }
        }
    }
}
