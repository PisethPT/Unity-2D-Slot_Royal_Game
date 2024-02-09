using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rule1_node3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 1;
        }
        else
        if (collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 2;
        }
        else
        if (collision.gameObject.CompareTag("node_3"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 3;
        }
        else
        if (collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 4;
        }
        else
        if (collision.gameObject.CompareTag("node_5"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 5;
        }
        else
        if (collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 6;
        }
        else
        if (collision.gameObject.CompareTag("node_7"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 7;
        }
        else
        if (collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 8;
        }
        else
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[2] = 9;
        }
    }
}
