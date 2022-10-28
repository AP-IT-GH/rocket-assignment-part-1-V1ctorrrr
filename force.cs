using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class force : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var snelheid = 4f;
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10f), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, snelheid, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0,0, -snelheid,ForceMode.Force);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "pickup")
        {
            rb.AddForce(new Vector3(0, 0), ForceMode.Force);
        }
    }
}
