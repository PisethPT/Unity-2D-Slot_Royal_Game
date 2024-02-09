using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectrule4: MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node_1"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[0].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_2"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[1].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_3"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[2].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_4"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[3].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_5"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[4].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_6"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[5].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_7"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[6].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_8"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[7].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
        if (collision.gameObject.CompareTag("node_9"))
        {
            FindAnyObjectByType<gamemanager>().nodes_rule5[8].node_s.transform.position = FindAnyObjectByType<gamemanager>().tranPosRule[4].position;
        }
    }
}
