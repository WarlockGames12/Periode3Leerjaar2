using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public GameObject A;
    public GameObject B;
    public Vector3 AB;

    public float n = 0f;
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        A = GameObject.Find("Begin");
        B = GameObject.Find("End");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
