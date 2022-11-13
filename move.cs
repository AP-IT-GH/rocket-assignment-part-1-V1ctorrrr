using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static float speed = 0.5f;
    float maxValue = 15; 
    float minValue = 2; 
    float currentValue = 5; 
    int direction = 2;
    void Update()
    {
        
        /*
        transform.position = new Vector3(transform.position.x,speed,transform.position.z);
        if (transform.position.y>16 || transform.position.y<=2)
        {
            speed *= -1f;
        }
        */
        currentValue += Time.deltaTime * direction; 
        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }
        transform.position = new Vector3(transform.position.x, currentValue, transform.position.z);
    }
}
