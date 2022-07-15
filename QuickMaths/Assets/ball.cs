using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public AudioSource HitWall;
    public float Speed = 1f;
    Vector3 velocity = new Vector3(2, 3, 0);
    public GameObject BallsSpawn;
    public Transform BallSpawner;
    public int maxEnemy = 10;
    bool Speeding = false;
    bool MaxedOut = false;

    private void Update()
    {
        transform.position += velocity * Speed * Time.deltaTime;
        if (transform.position.y > 5)
        {
            HitWall.Play();
            velocity.y = -Mathf.Abs(velocity.y);
            maxEnemy += 1;
            if(maxEnemy > 0 && MaxedOut == false)
            {
                GameObject Pingas = Instantiate(BallsSpawn, BallSpawner.transform.position, Quaternion.identity);
                Pingas.GetComponent<ball>().Speed = 1f;
            }
            else if(maxEnemy > 10)
            {
                Debug.Log("You have in total " + maxEnemy + " Balls in the area");
                MaxedOut = true;
            }
            

            if (Speed == 50)
            {
                Speeding = true;
                Speed -= 1;
                if (Speed < 49 && Speeding == true)
                {
                    Speed -= 1;
                }
                else if (Speed == 1 && Speeding == true)
                {
                    Speeding = false;
                    Speed += 1;
                }
            }
            else if (Speed < 49 && Speeding == false)
            {
                Speed += 1;
            }


        }
        else if (transform.position.x > 11)
        {
            HitWall.Play();
            velocity.x = -Mathf.Abs(velocity.x);
            maxEnemy += 1;
            if (maxEnemy > 0 && MaxedOut == false)
            {
                GameObject Pingas = Instantiate(BallsSpawn, BallSpawner.transform.position, Quaternion.identity);
                Pingas.GetComponent<ball>().Speed = 1f;
            }
            else if (maxEnemy > 10)
            {
                Debug.Log("You have in total " + maxEnemy + " Balls in the area");
                MaxedOut = true;
            }
            

            if (Speed == 50)
            {
                Speeding = true;
                Speed -= 1;
                if (Speed < 49 && Speeding == true)
                {
                    Speed -= 1;
                    
                }
                else if (Speed == 1 && Speeding == true)
                {
                    Speeding = false;
                    Speed += 1;
                }
            }
            else if (Speed < 49 && Speeding == false)
            {
                Speed += 1;
            }

        }
        else if (transform.position.y < -5)
        {
            HitWall.Play();
            velocity.y = Mathf.Abs(velocity.y);
            maxEnemy += 1;
            if (maxEnemy > 0 && MaxedOut == false)
            {
                GameObject Pingas = Instantiate(BallsSpawn, BallSpawner.transform.position, Quaternion.identity);
                Pingas.GetComponent<ball>().Speed = 1f;
            }
            else if (maxEnemy > 10)
            {
                Debug.Log("You have in total " + maxEnemy + " Balls in the area");
                MaxedOut = true;
            }
            

            if (Speed == 50)
            {
                Speeding = true;
                Speed -= 1;
                if (Speed < 49 && Speeding == true)
                {
                    Speed -= 1;

                }
                else if (Speed == 1 && Speeding == true)
                {
                    Speeding = false;
                    Speed += 1;
                }
            }
            else if (Speed < 49 && Speeding == false)
            {
                Speed += 1;
            }

        }
        else if (transform.position.x < -11)
        {
            HitWall.Play();
            velocity.x = Mathf.Abs(velocity.x);
            maxEnemy += 1;
            if (maxEnemy > 0 && MaxedOut == false)
            {
                GameObject Pingas = Instantiate(BallsSpawn, BallSpawner.transform.position, Quaternion.identity);
                Pingas.GetComponent<ball>().Speed = 1f;
            }
            else if (maxEnemy > 10)
            {
                Debug.Log("You have in total " + maxEnemy + " Balls in the area");
                MaxedOut = true;
            }
            

            if (Speed == 50)
            {
                Speeding = true;
                Speed -= 1;
                if (Speed < 49 && Speeding == true)
                {
                    Speed -= 1;
                }
                else if (Speed == 1 && Speeding == true)
                {
                    Speeding = false;
                    Speed += 1;
                }
            }
            else if (Speed < 49 && Speeding == false)
            {
                Speed += 1;
            }


        }
    }


}
