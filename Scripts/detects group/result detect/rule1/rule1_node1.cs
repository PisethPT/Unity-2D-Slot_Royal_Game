using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rule1_node1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[0].vaule;
        }
        else
        if (collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[1].vaule;
        }
        else
        if (collision.gameObject.CompareTag("node_3"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[2].vaule;
        }
        else
        if (collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[3].vaule;
        }
        else
        if (collision.gameObject.CompareTag("node_5"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[4].vaule;
        }
        else
        if (collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[5].vaule;
        }else
        if (collision.gameObject.CompareTag("node_7"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[6].vaule;
        }else
        if (collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[7].vaule;
        }else
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().rule1_nodes[0] = FindAnyObjectByType<gamemanager>().nodes_rule1[8].vaule;
        }
    }
}
