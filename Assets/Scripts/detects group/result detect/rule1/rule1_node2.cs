using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rule1_node2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 1;
        }else
        if (collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 2;
        }else
        if (collision.gameObject.CompareTag("node_3"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 3;
        }else
        if (collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 4;
        }else
        if (collision.gameObject.CompareTag("node_5"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 5;
        }else
        if (collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 6;
        }else
        if (collision.gameObject.CompareTag("node_7"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 7;
        }else
        if (collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 8;
        }else
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[1] = 9;
        }
    }
}
