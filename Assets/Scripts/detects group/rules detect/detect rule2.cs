using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectrule2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[0].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[1].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_3"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[2].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[3].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_5"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[4].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[5].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_7"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[6].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[7].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule3[8].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[2].position;
        }
    }
}
