using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rule4_node2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 1;
        }
        if (collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 2;
        }
        if (collision.gameObject.CompareTag("node_3"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 3;
        }
        if (collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 4;
        }
        if (collision.gameObject.CompareTag("node_5"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 5;
        }
        if (collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 6;
        }
        if (collision.gameObject.CompareTag("node_7"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 7;
        }
        if (collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 8;
        }
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().rule4_nodes[1] = 9;
        }
    }
}
