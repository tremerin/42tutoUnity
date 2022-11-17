using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    /* "public" se puede ver en el inspector */
    public float speedMovement = 5;

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.position += Vector3.forward * z * speedMovement * Time.deltaTime;
        transform.position += Vector3.right * x * speedMovement * Time.deltaTime; 
    }
}
