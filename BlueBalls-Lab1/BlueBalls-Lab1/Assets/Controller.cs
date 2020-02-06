using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Rigidbody r = GetComponent<Rigidbody>();
        r.velocity = new Vector3(horizontalMovement * speed, -10f, verticalMovement * speed);// -10f added in 06/02 22:00
    }

}
