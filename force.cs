using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class force : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        SceneManager.UnloadScene("Level2");
    }

    // Update is called once per frame
    void Update()
    {
        var snelheid = 4f;
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(new Vector3(0, 1000 * Time.deltaTime, 0), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(5, 0, 0) * snelheid * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey("q"))
        {
            transform.Rotate(new Vector3(-5, 0, 0) * snelheid * Time.deltaTime);
        }
    }

    
}
