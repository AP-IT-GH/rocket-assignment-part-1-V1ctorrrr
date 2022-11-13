using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject gamefinish;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            gamefinish.SetActive(true);
        }
    }
}
