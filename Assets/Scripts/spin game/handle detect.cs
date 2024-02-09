using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handledetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FindAnyObjectByType<spin>().spin_isstop == true)
        {

            if (collision.gameObject.CompareTag("10x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 1000 * 10;
                print("20");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[0];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("10x");
            }
            if (collision.gameObject.CompareTag("8x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 800 * 10;
                print("5");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[1];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("8x");
            }
            if (collision.gameObject.CompareTag("12x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 1200 * 10;
                print("50");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[2];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("12x");
            }
            if (collision.gameObject.CompareTag("15x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 1500 * 10;
                print("7");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[3];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("15x");
            }
            if (collision.gameObject.CompareTag("3x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 300 * 10;
                print("15");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[4];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("3x");
            }
            if (collision.gameObject.CompareTag("30x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 3000 * 10;
                print("12");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[5];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("30x");
            }
            if (collision.gameObject.CompareTag("5x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 500 * 10;
                print("3");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[6];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("5x");
            }
            if (collision.gameObject.CompareTag("2x"))
            {
                FindAnyObjectByType<gamemanager>().add_credit = 200 * 10;
                print("8");
                FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().sprite = FindAnyObjectByType<spin>().sprites[7];
                FindAnyObjectByType<spin>().SP.gameObject.SetActive(true);
                FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("SP");
                FindAnyObjectByType<spin>().ani.Play("2x");
            }

        }
        FindAnyObjectByType<spin>().ani.Play("idle");
        FindAnyObjectByType<spin>().SP.GetComponent<Animator>().Play("idle");
        FindAnyObjectByType<spin>().SP.GetComponent<SpriteRenderer>().enabled = false;
        FindAnyObjectByType<gamemanager>().credit += FindAnyObjectByType<gamemanager>().add_credit;
        // FindAnyObjectByType<spin>().balance.text = FindAnyObjectByType<gamemanager>().credit.ToString();
        FindAnyObjectByType<gamemanager>().convert(FindAnyObjectByType<gamemanager>().credit, FindAnyObjectByType<spin>().balance);
    }

}
