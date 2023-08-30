using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private bool istime , stop_buttonIstrue, isON = true;
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
    [SerializeField] List<GameObject> compared_result_lines;
    int total_bets;
    int credit = 1899780;
    [SerializeField] Text credit_txt, total_txt;


    // Start is called before the first frame update
    void Start()
    {
        convert(credit, credit_txt);
        speed += Random.Range(1, 3);
        foreach (GameObject gameObject in nodes_group)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (stop_buttonIstrue.Equals(false)&& isON==false)
        {
            speed = Random.Range(1f, 5f);
            rspeed1 = Random.Range(1.5f, 2.5f);
            rspeed2 = Random.Range(1.5f, 2.5f);
            rspeed3 = Random.Range(1.5f, 2.5f);
            rspeed4 = Random.Range(1.5f, 2.5f);
            rspeed5 = Random.Range(1.5f, 2.5f);
            game_update();
        }
    }

    // spin button
    public void spinbutton()
    {
        spin_button[1].SetActive(true);
        spin_button[0].SetActive(false);
        isON = false;
        stop_buttonIstrue = false;
        for(int i = 0; i<detect_get_result_rule1.Count; i++)
        {
            detect_get_result_rule1[i].SetActive(false);
            detect_get_result_rule2[i].SetActive(false);
            detect_get_result_rule3[i].SetActive(false);
            detect_get_result_rule4[i].SetActive(false);
            detect_get_result_rule5[i].SetActive(false);
        }
        for(int j = 0; j<rule1_nodes.Count; j++)
        {
            rule1_nodes[j] = 0;
            rule2_nodes[j] = 0;
            rule3_nodes[j] = 0;
            rule4_nodes[j] = 0;
            rule5_nodes[j] = 0;
        }
        for(int k =0; k<roads.Count; k++)
        {
            roads[k].SetActive(false);
        }
        foreach (GameObject gameObject in nodes_group)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        foreach (GameObject detects in detects_buttom)
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
        detects_buttom[0].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 0; i<9; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[0].SetActive(true);
        for (int node = 0; node < detect_get_result_rule1.Count; node++)
            detect_get_result_rule1[node].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed1);

        detects_buttom[1].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 8; i<18; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[1].SetActive(true);
        for (int node = 0; node < detect_get_result_rule2.Count; node++)
            detect_get_result_rule2[node].SetActive(true);
        yield return new WaitForSecondsRealtime(rspeed2);

        detects_buttom[2].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 17; i<27; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[2].SetActive(true);
        for (int node = 0; node < detect_get_result_rule3.Count; node++)
            detect_get_result_rule3[node].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed3);

        detects_buttom[3].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 26; i<36; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[3].SetActive(true);
        for (int node = 0; node < detect_get_result_rule4.Count; node++)
            detect_get_result_rule4[node].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed4);

        detects_buttom[4].GetComponent<BoxCollider2D>().isTrigger = false;
        for (int i = 35; i<45; i++)
        {
            nodes_group[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        roads[4].SetActive(true);
        for (int node = 0; node < detect_get_result_rule5.Count; node++)
            detect_get_result_rule5[node].SetActive(true);

        yield return new WaitForSecondsRealtime(rspeed5);

        calculate_checkResults(rule1_nodes, rule2_nodes, rule3_nodes, rule4_nodes, rule5_nodes);

       // StartCoroutine(clear_lines());

        spin_buttonActive.enabled = true;
        spin_buttonActive.image.color = new Color(255, 255, 255, 255);

        //for(int i = 0; i<rule1_nodes.Count; i++)
        //{
        //    print("result rule1[" + i + "]: " + rule1_nodes[i]);
        //    print("result rule2[" + i + "]: " + rule2_nodes[i]);
        //    print("result rule3[" + i + "]: " + rule3_nodes[i]);
        //    print("result rule4[" + i + "]: " + rule4_nodes[i]);
        //    print("result rule5[" + i + "]: " + rule5_nodes[i]);
        //}

    }

    // game update
    void game_update()
    {
        if (istime)
        {
            timerofgame -= Time.deltaTime;
        }
        if(timerofgame <=0 && istime)
        {
            stopbuttonAction();
        }

    }

    IEnumerator clear_lines()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        for (int i = 0; i < compared_result_lines.Count; i++)
            compared_result_lines[i].SetActive(false);
    }

    // calculate function
    void calculate_checkResults(List<int>rule1, List<int>rule2, List<int>rule3,List<int>rule4, List<int>rule5)
    {
        // case1:
        if(rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[1]))
        {
            compared_result_lines[0].SetActive(true);
            credit += total_bets * 2;
        }        // case2:
        if(rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[0]))
        {
            compared_result_lines[1].SetActive(true);
            credit += total_bets * 2;
        }        // case3:
        if(rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])&& rule4[2].Equals(rule5[2]))
        {
            compared_result_lines[2].SetActive(true);
            credit += total_bets * 2;
        }        // case4:
        if(rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1])&& rule4[1].Equals(rule5[0]))
        {
            compared_result_lines[3].SetActive(true);
            credit += total_bets * 2;
        }        // case5:
        if(rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1])&& rule4[1].Equals(rule5[2]))
        {
            compared_result_lines[4].SetActive(true);
            credit += total_bets * 2;
        }        // case6:
        if(rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0])&& rule4[0].Equals(rule5[1]))
        {
            compared_result_lines[5].SetActive(true);
            credit += total_bets * 2;
        }        // case7:
        if(rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])&& rule4[2].Equals(rule5[1]))
        {
            compared_result_lines[6].SetActive(true);
            credit += total_bets * 2;
        }        // case8:
        if(rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2])&& rule4[2].Equals(rule5[2]))
        {
            compared_result_lines[7].SetActive(true);
            credit += total_bets * 2;
        }        // case9:
        if(rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0])&& rule4[0].Equals(rule5[0]))
        {
            compared_result_lines[8].SetActive(true);
            credit += total_bets * 2;
        }        // case10:
        if(rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1])&& rule4[1].Equals(rule5[0]))
        {
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 2;
        }        // case11:
        if(rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1])&& rule4[1].Equals(rule5[2]))
        {
            compared_result_lines[10].SetActive(true);
            credit += total_bets * 2;
        }        // case12:
        if(rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[2]) && rule3[2].Equals(rule4[2])&& rule4[2].Equals(rule5[1]))
        {
            compared_result_lines[11].SetActive(true);
            credit += total_bets * 2;
        }        // case13:
        if(rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0])&& rule4[0].Equals(rule5[1]))
        {
            compared_result_lines[12].SetActive(true);
            credit += total_bets * 2;
        }         // case14:
        if(rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1])&& rule4[1].Equals(rule5[0]))
        {
            compared_result_lines[13].SetActive(true);
            credit += total_bets * 2;
        }         // case15:
        if(rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1])&& rule4[1].Equals(rule5[2]))
        {
            compared_result_lines[14].SetActive(true);
            credit += total_bets * 2;
        }         // case16:
        if(rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1])&& rule4[1].Equals(rule5[1]))
        {
            compared_result_lines[15].SetActive(true);
            credit += total_bets * 2;
        }          // case17:
        if(rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1])&& rule4[1].Equals(rule5[1]))
        {
            compared_result_lines[16].SetActive(true);
            credit += total_bets * 2;
        }          // case18:
        if(rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[2]) && rule3[2].Equals(rule4[0])&& rule4[0].Equals(rule5[0]))
        {
            compared_result_lines[17].SetActive(true);
            credit += total_bets * 2;
        }          // case19:
        if(rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[0]) && rule3[0].Equals(rule4[2])&& rule4[2].Equals(rule5[2]))
        {
            compared_result_lines[18].SetActive(true);
            credit += total_bets * 2;
        }          // case20:
        if(rule1[0].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])&& rule4[2].Equals(rule5[0]))
        {
            compared_result_lines[19].SetActive(true);
            credit += total_bets * 2;
        }   
    }

    public void convert(int value, Text text)
    {
        var convert = string.Format("{0:#,#}", value);
        text.text = convert.ToString();
    }
}

