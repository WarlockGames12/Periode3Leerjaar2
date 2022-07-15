using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [Header("A & B")]
    public GameObject A;
    public GameObject B;

    [Header("C & D")]
    public GameObject C;
    public GameObject D;

    [Header("Balls")]
    public GameObject Ball1;
    public GameObject Ball2;

    [Header("Speed for A to B")]
    public float n = 0f;
    public float speed = 0.01f;

    [Header("Speed for C to D")]
    public float f = 0f;
    public float speeding = 0.04f;


    // Start is called before the first frame update
    void Start()
    {
        A = GameObject.Find("Begin");
        B = GameObject.Find("End");
        C = GameObject.Find("Began");
        D = GameObject.Find("Ended");
    }

    // Update is called once per frame
    void Update()
    {
        Ball1.transform.position = n * (A.transform.position-B.transform.position) + B.transform.position;
        n += speed;

        Ball2.transform.position = f * (C.transform.position - D.transform.position) + D.transform.position;
        f += speeding;

        if (n > 1)
        {
            speed = -Mathf.Abs(speed);
        }
        if (n < 0)
        {
            speed = Mathf.Abs(speed);
        }

        if (f > 1)
        {
            speeding = -Mathf.Abs(speeding);
        }
        if (f < 0)
        {
            speeding = Mathf.Abs(speeding);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball2")
        {
            Ball1.GetComponent<Renderer>().material.color = Color.red;
        }
        if (collision.gameObject.tag == "Ball1")
        {
            Ball2.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball2")
        {
            Ball1.GetComponent<Renderer>().material.color = Color.white;
        }
        if (collision.gameObject.tag == "Ball1")
        {
            Ball2.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
