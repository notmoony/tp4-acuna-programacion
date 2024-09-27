using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

public class Daga : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
    }
}