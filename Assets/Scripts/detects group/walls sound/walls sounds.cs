using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallssounds : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1") || collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().sources[1].Play();
        }
        if (collision.gameObject.CompareTag("node_3") || collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().sources[1].Play();
        }
        if (collision.gameObject.CompareTag("node_5") || collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().sources[1].Play();
        }
        if (collision.gameObject.CompareTag("node_7") || collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().sources[1].Play();
        }
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().sources[1].Play();
        }
    }
}
