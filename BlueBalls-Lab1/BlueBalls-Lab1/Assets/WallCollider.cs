using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    public GameObject prototype;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject spawned = Instantiate(prototype, Vector3.Zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        //GameObject spawned = Instantiate(prototype, new Vector3(1.5f, 0.15f, 3.0f));
    }
}
