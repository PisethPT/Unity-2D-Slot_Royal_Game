using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class spin : MonoBehaviour
{
    public Transform spinner;
    [SerializeField] float spinner_speed;
    private float set_spinner_speed, speed_rand;
    [SerializeField] float subtra;
    public bool isspin;
    public bool spin_isstop;
    [SerializeField] GameObject collide;
    [SerializeField] public TextMeshProUGUI balance;
    [SerializeField] public Animator ani;
    public int maxof_spin = 0;
    public Transform spin_back_position, SP;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        ani.Play("idle");
        SP.GetComponent<Animator>().Play("idle");
        SP.gameObject.SetActive(false);
        collide.SetActive(false);
        isspin = false;
        speed_rand = Random.Range(10, 50);
        spinner_speed += speed_rand;
        set_spinner_speed = spinner_speed;
    }

    void Update()
    {
        FindAnyObjectByType<gamemanager>().convert(FindAnyObjectByType<gamemanager>().credit, balance);
        update_spin();
        check_maxof_spin();
    }

    void update_spin()
    {
        if (isspin)
        {
            spinner.Rotate(0f, 0f, spinner_speed * Time.deltaTime);
            spinner_speed -= subtra * Time.deltaTime;
            if (spinner_speed <= 0)
            {
                isspin = false;
                spin_isstop = true;
                collide.SetActive(true);
                
                collide.GetComponent<CapsuleCollider2D>().enabled = true;
                spinner_speed = set_spinner_speed + Random.Range(10, 50);
                FindAnyObjectByType<gamemanager>().sources[3].Play();
                maxof_spin++;
            }
        }
    }

    public void start_spinner()
    {
        FindAnyObjectByType<gamemanager>().sources[0].Play();
        ani.Play("idle");
        SP.GetComponent<Animator>().Play("idle");
        SP.gameObject.SetActive(false);
        collide.SetActive(false);
        collide.GetComponent<CapsuleCollider2D>().enabled = false;
        isspin = true;
        spin_isstop = false;
    }
    void check_maxof_spin()
    {
        if (maxof_spin>=2)
        {
            ani.Play("idle");
            SP.GetComponent<Animator>().Play("idle");
            SP.gameObject.SetActive(false);
            StartCoroutine(wait());
            for (int i = 0; i < FindAnyObjectByType<calculatenodes>().win_border.Count; i++)
            {
                FindAnyObjectByType<calculatenodes>().win_border[i].SetActive(false);
            }
            FindAnyObjectByType<gamemanager>().StartCoroutine(FindAnyObjectByType<gamemanager>().clear_lines());
            IEnumerator wait()
            {
                ani.Play("idle");
                SP.GetComponent<Animator>().Play("idle");
                SP.gameObject.SetActive(false);
                yield return new WaitForSecondsRealtime(1f);
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                FindAnyObjectByType<spincall>().slotObject.SetActive(true);
                FindAnyObjectByType<spincall>().slot_component.SetActive(true);

                FindAnyObjectByType<spincall>().spinObject.SetActive(false);
                FindAnyObjectByType<spincall>().spin_collider.SetActive(false);
                FindAnyObjectByType<spincall>().spin_component.SetActive(false); 
                FindAnyObjectByType<spincall>().s.SetActive(false); 
                FindAnyObjectByType<spincall>().l.SetActive(false); 

                maxof_spin = 0;
                FindAnyObjectByType<spincall>().spinObject.transform.position = spin_back_position.position;
                FindAnyObjectByType<spincall>().logo_spin.SetActive(false);
                collide.SetActive(false);
                collide.GetComponent<CapsuleCollider2D>().enabled= false;
            }

        }
        
    }

}
