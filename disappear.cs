using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int counter = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            counter++;
            text.text = $"{counter}";
            Destroy(gameObject);
        }
    }
}
