using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public GameObject impactPrefab;

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(impactPrefab, transform.position, transform.rotation);
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);

    }
}
