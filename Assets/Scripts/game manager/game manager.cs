using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public Transform[] tranPosRule;
    public List<nodes> nodes_rule1;
    public List<nodes> nodes_rule2;
    public List<nodes> nodes_rule3;
    public List<nodes> nodes_rule4;
    public List<nodes> nodes_rule5;
    [SerializeField] List<GameObject> nodes_group;
    [SerializeField] Sprite[] change_buttons;
    [SerializeField] GameObject[] spin_button;
    [SerializeField] List<GameObject> detects_buttom;
    [SerializeField] Button spin_buttonActive;
    [SerializeField] float speed, rspeed1, rspeed2, rspeed3, rspeed4, rspeed5;
    float timerofgame;
    private bool istime, stop_buttonIstrue, isON = true;
    [SerializeField] List<GameObject> detect_get_result_rule1;
    [SerializeField] List<GameObject> detect_get_result_rule2;
    [SerializeField] List<GameObject> detect_get_result_rule3;
    [SerializeField] List<GameObject> detect_get_result_rule4;
    [SerializeField] List<GameObject> detect_get_result_rule5;
    [SerializeField] List<GameObject> roads;
    public List<int> rule1_nodes;
    public List<int> rule2_nodes;
    public List<int> rule3_nodes;
    public List<int> rule4_nodes;
    public List<int> rule5_nodes;
    [SerializeField] public  List<GameObject> compared_result_lines;
    public int total_bets;
    public int credit = 100000;
    int one = 10, max = 1000;
    public int add_credit, balanecs;
    [SerializeField] public TextMeshProUGUI credit_txt, total_txt, txt;
    [SerializeField] List<Button> max_one;
    [SerializeField] public List<AudioSource> sources;
    public AudioSource backgroundAudio;
    public Button spin_load;

    // Start is called before the first frame update
    void Start()
    {

        credit = PlayerPrefs.GetInt("balance");
        if(credit<=0){
            credit = 195800;
        }
        backgroundAudio.Play();
        convert(credit, credit_txt);
        speed += Random.Range(1f, 3f);
        foreach (GameObject gameObject in nodes_group)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        convert(credit, credit_txt);
        if (stop_buttonIstrue.Equals(false) && isON == false)
        {
            speed = Random.Range(1f, 3f);
            rspeed1 = Random.Range(0.5f, 1.5f);
            rspeed2 = Random.Range(0.4f, 1f);
            rspeed3 = Random.Range(0.5f, 1.5f);
            rspeed4 = Random.Range(1.5f, 2.5f);
            rspeed5 = Random.Range(0.4f, 1f);
            game_update();
        }
    }

    // spin button
    public void spinbutton()
    {
        spin_load.enabled = false;
        sources[0].Play();
       for(int i =0; i<max_one.Count; i++)
        {
            max_one[i].enabled = false;
            max_one[i].image.color = Color.gray;
        }
        for(int i =0; i<FindAnyObjectByType<calculatenodes>().win_border.Count; i++)
        {
            FindAnyObjectByType<calculatenodes>().win_border[i].SetActive(false);
        }

        StartCoroutine(clear_lines());
        spin_button[1].SetActive(true);
        spin_button[0].SetActive(false);
        isON = false;
        stop_buttonIstrue = false;
        for (int i = 0; i < detect_get_result_rule1.Count; i++)
        {
            detect_get_result_rule1[i].SetActive(false);
            detect_get_result_rule2[i].SetActive(false);
            detect_get_result_rule3[i].SetActive(false);
            detect_get_result_rule4[i].SetActive(false);
            detect_get_result_rule5[i].SetActive(false);
        }
        for (int j = 0; j < rule1_nodes.Count; j++)
        {
            rule1_nodes[j] = 0;
            rule2_nodes[j] = 0;
            rule3_nodes[j] = 0;
            rule4_nodes[j] = 0;
            rule5_nodes[j] = 0;
        }
        for (int k = 0; k < roads.Count; k++)
        {
            roads[k].SetActive(false);
        }
        foreach (GameObject gameObject in nodes_group)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        foreach (GameObject detects in roads)
        {
            detects.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        timerofgame = 1f + speed;
        istime = true;

        if (stop_buttonIstrue.Equals(true))
        {
            timerofgame = 0f;
            istime = false;
        }
    }

    // stop button
    public void stopspinbutton()
    {
        stop_buttonIstrue = true;
        stopbuttonAction();
    }

    // stop button action
    private void stopbuttonAction()
    {
        isON = true;
        spin_button[1].SetActive(false);
        spin_button[0].SetActive(true);
        spin_buttonActive.enabled = false;
        spin_buttonActive.image.color = Color.gray;

        StartCoroutine(step_of_rules());
    }

    // controll rules spin step
    IEnumerator step_of_rules()
    {
        roads[0].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 0; i < 9; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[0].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed1);

        roads[1].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 8; i < 18; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[1].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed2);

        detects_buttom[2].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 17; i < 27; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[2].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed3);

        roads[3].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 26; i < 36; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[3].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed4);

        roads[4].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 35; i < 45; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[4].SetActive(true);

        yield return new WaitForSecondsRealtime(0.5f);

        for (int node = 0; node < detect_get_result_rule1.Count; node++)
            detect_get_result_rule1[node].SetActive(true);

        for (int node = 0; node < detect_get_result_rule2.Count; node++)
            detect_get_result_rule2[node].SetActive(true);

        for (int node = 0; node < detect_get_result_rule3.Count; node++)
            detect_get_result_rule3[node].SetActive(true);

        for (int node = 0; node < detect_get_result_rule4.Count; node++)
            detect_get_result_rule4[node].SetActive(true);

        for (int node = 0; node < detect_get_result_rule5.Count; node++)
            detect_get_result_rule5[node].SetActive(true);


        yield return new WaitForSecondsRealtime(0.5f);
        for (int i = 0; i < rule1_nodes.Count; i++)
        {
            print("rule1: " + rule1_nodes[i]);
        }

        FindAnyObjectByType<calculatenodes>().calculate_checkResults(rule1_nodes, rule2_nodes, rule3_nodes, rule4_nodes, rule5_nodes);
        spin_load.enabled = true;
        spin_buttonActive.enabled = true;
        spin_buttonActive.image.color = new Color(255, 255, 255, 255);
        total_bets = 0;
        convert(total_bets, total_txt);
        convert(total_bets, txt);

        for (int i = 0; i < max_one.Count; i++)
        {
            max_one[i].enabled = true;
            max_one[i].image.color = new Color(255, 255, 255, 255);
        }
    }

    // game update
    void game_update()
    {
        if (istime)
        {
            timerofgame -= Time.deltaTime;
        }
        if (timerofgame <= 0 && istime)
        {
            stopbuttonAction();
        }

    }

    public IEnumerator clear_lines()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        for (int i = 0; i < compared_result_lines.Count; i++)
            compared_result_lines[i].SetActive(false);

    }

    public void bet_one()
    {
        sources[2].Play();
        for (int i = 0; i < FindAnyObjectByType<calculatenodes>().win_border.Count; i++)
        {
            FindAnyObjectByType<calculatenodes>().win_border[i].SetActive(false);
        }

        StartCoroutine(clear_lines());
        if (credit >= one)
        {
            credit -= one;
            total_bets += one;
            convert(total_bets, total_txt);
            convert(total_bets, txt);
        }
        else
        {

        }
    }

    public void sub_one()
    {
        sources[2].Play();
        for (int i = 0; i < FindAnyObjectByType<calculatenodes>().win_border.Count; i++)
        {
            FindAnyObjectByType<calculatenodes>().win_border[i].SetActive(false);
        }

        StartCoroutine(clear_lines());
        if (total_bets > 0)
        {
            credit += one;
            total_bets -= one;
            convert(total_bets, total_txt);
            convert(total_bets, txt);
        }
        else
        {

        }
    }

    public void bets_max()
    {
        sources[2].Play();
        for (int i = 0; i < FindAnyObjectByType<calculatenodes>().win_border.Count; i++)
        {
            FindAnyObjectByType<calculatenodes>().win_border[i].SetActive(false);
        }

        StartCoroutine(clear_lines());
        if (credit >= max)
        {
            credit -= max;
            total_bets += max;
            convert(total_bets, total_txt);
            convert(total_bets, txt);
        }
        else
        {

        }
    }

    public void convert(int value, TextMeshProUGUI text)
    {
        var convert = string.Format("{0:#,#0.0}", value);
        text.text = convert.ToString();
    }

    public void goto_home_scene()
    {
        SavePlayerPref.SaveBalance();
        sources[4].Play();
        SceneManager.LoadScene("Home Game");
    }

    // if credit <=10;

    void check_credit(int credits_amount)
    {
        if(credits_amount <= 10)
        {
            FindAnyObjectByType<spincall>().spin_calling();
        }
    }
}

