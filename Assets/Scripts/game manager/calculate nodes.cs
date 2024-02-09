using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class calculatenodes : MonoBehaviour
{

    int credit, total_bets;
    static private List<GameObject> compared_result_lines;
    public List<GameObject> win_border;
    public List<Animator> animators;

    public Transform particles;
    private void Start()
    {
        for (int i = 0; i < particles.childCount; i++)
        {
            particles.GetChild(i).gameObject.SetActive(false);
        }
    }
    void PlayParticle()
    {
        for (int i = 0; i < particles.childCount; i++)
        {
            particles.GetChild(i).gameObject.SetActive(true);
            particles.GetChild(i).GetComponent<ParticleSystem>().Play();
        }
    }

    // calculate function
    public void calculate_checkResults(List<int> rule1, List<int> rule2, List<int> rule3, List<int> rule4, List<int> rule5)
    {
        credit = FindAnyObjectByType<gamemanager>().credit;
        total_bets = FindAnyObjectByType<gamemanager>().total_bets;
        compared_result_lines = FindAnyObjectByType<gamemanager>().compared_result_lines;

        // case1:
        if (rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[1]))
        {
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            win_border[1].SetActive(true); animators[1].Play("ract2");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[13].SetActive(true); animators[13].Play("ract14");
            compared_result_lines[0].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1])) || (rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[1])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[1].SetActive(true); animators[1].Play("ract2");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            else if (rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[13].SetActive(true); animators[13].Play("ract14");
            }

            compared_result_lines[0].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1])) || (rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1])) || (rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[1])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[1].SetActive(true); animators[1].Play("ract2");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[7].SetActive(true); animators[7].Play("ract8");
            }
            if (rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[13].SetActive(true); animators[13].Play("ract14");
            }

            compared_result_lines[0].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case2:
        if (rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[0]))
        {
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            win_border[0].SetActive(true); animators[0].Play("ract1");
            win_border[3].SetActive(true); animators[3].Play("ract3");
            win_border[6].SetActive(true); animators[6].Play("ract7");
            win_border[9].SetActive(true); animators[9].Play("ract10");
            win_border[12].SetActive(true); animators[12].Play("ract13");

            compared_result_lines[1].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0])) || (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[3].SetActive(true); animators[3].Play("ract3");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
            }
            if (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[3].SetActive(true); animators[3].Play("ract3");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }

            compared_result_lines[1].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[0])) || (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0])) || (rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[3].SetActive(true); animators[3].Play("ract3");
                win_border[6].SetActive(true); animators[6].Play("ract7");
            }
            if (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[3].SetActive(true); animators[3].Play("ract3");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
            }
            if (rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }

            compared_result_lines[1].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }
        else if (rule1[0].Equals(rule2[0]) || rule2[0].Equals(rule3[0]) || rule3[0].Equals(rule4[0]) || rule4[0].Equals(rule5[0]))

            // case3:
            if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                FindAnyObjectByType<gamemanager>().sources[3].Play();
                win_border[2].SetActive(true); animators[2].Play("ract3");
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[11].SetActive(true); animators[11].Play("ract12");
                win_border[14].SetActive(true); animators[14].Play("ract15");

                compared_result_lines[2].SetActive(true);
                credit += total_bets * 500;
                PlayParticle();
                print("5:5");
            }
            else if ((rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])) || (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[2])))
            {
                FindAnyObjectByType<gamemanager>().sources[3].Play();
                if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]))
                {
                    FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                    win_border[2].SetActive(true); animators[2].Play("ract3");
                    win_border[5].SetActive(true); animators[5].Play("ract6");
                    win_border[8].SetActive(true); animators[8].Play("ract9");
                    win_border[11].SetActive(true); animators[11].Play("ract12");
                }
                if (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[2]))
                {
                    FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                    win_border[5].SetActive(true); animators[5].Play("ract6");
                    win_border[8].SetActive(true); animators[8].Play("ract9");
                    win_border[11].SetActive(true); animators[11].Play("ract12");
                    win_border[14].SetActive(true); animators[14].Play("ract15");
                }

                compared_result_lines[2].SetActive(true);
                credit += total_bets * 250;
                PlayParticle();
                print("4:4");
            }
            else if ((rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2])) || (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])) || (rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[2])))
            {
                FindAnyObjectByType<gamemanager>().sources[3].Play();
                if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2]))
                {
                    FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                    win_border[2].SetActive(true); animators[2].Play("ract3");
                    win_border[5].SetActive(true); animators[5].Play("ract6");
                    win_border[8].SetActive(true); animators[8].Play("ract9");
                }
                if (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]))
                {
                    FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                    win_border[5].SetActive(true); animators[5].Play("ract6");
                    win_border[8].SetActive(true); animators[8].Play("ract9");
                    win_border[11].SetActive(true); animators[11].Play("ract12");
                }
                if (rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[2]))
                {
                    FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                    win_border[8].SetActive(true); animators[8].Play("ract9");
                    win_border[11].SetActive(true); animators[11].Play("ract12");
                    win_border[14].SetActive(true); animators[14].Play("ract15");
                }

                compared_result_lines[2].SetActive(true);
                credit += total_bets * 100;
                PlayParticle();
                print("3:3");
            }

        // case4:
        if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[0]))
        {
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            win_border[0].SetActive(true); animators[0].Play("ract1");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[8].SetActive(true); animators[8].Play("ract9");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[12].SetActive(true); animators[12].Play("ract13");

            compared_result_lines[3].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1])) || (rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }
            compared_result_lines[3].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[1])) || (rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1])) || (rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[8].SetActive(true); animators[7].Play("ract8");
            }
            if (rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }
            compared_result_lines[3].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case5:
        if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[2]))
        {
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[6].SetActive(true); animators[6].Play("ract7");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[14].SetActive(true); animators[14].Play("ract15");

            compared_result_lines[4].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1])) || (rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[2])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[2].SetActive(true); animators[2].Play("ract3");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[14].SetActive(true); animators[14].Play("ract15");
            }
            compared_result_lines[4].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[0])) || (rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1])) || (rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[2])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[2].SetActive(true); animators[2].Play("ract3");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[6].SetActive(true); animators[6].Play("ract7");
            }
            if (rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[14].SetActive(true); animators[14].Play("ract15");
            }

            compared_result_lines[4].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case6:
        if (rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[1]))
        {
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            win_border[1].SetActive(true); animators[1].Play("ract2");
            win_border[3].SetActive(true); animators[3].Play("ract4");
            win_border[6].SetActive(true); animators[6].Play("ract7");
            win_border[9].SetActive(true); animators[9].Play("ract10");
            win_border[13].SetActive(true); animators[13].Play("ract14");
            compared_result_lines[5].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0])) || (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[1])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[1].SetActive(true); animators[1].Play("ract2");
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
            }
            if (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
                win_border[13].SetActive(true); animators[13].Play("ract14");
            }

            compared_result_lines[5].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[0])) || (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0])) || (rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[1])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[1].Equals(rule2[0]) && rule2[0].Equals(rule3[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[1].SetActive(true); animators[1].Play("ract2");
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[6].SetActive(true); animators[6].Play("ract7");
            }
            if (rule2[0].Equals(rule3[0]) && rule3[0].Equals(rule4[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
            }
            if (rule3[0].Equals(rule4[0]) && rule4[0].Equals(rule5[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[9].SetActive(true); animators[9].Play("ract10");
                win_border[13].SetActive(true); animators[13].Play("ract14");
            }
            compared_result_lines[5].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case7:
        if (rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[1])) // 2-3-3-3-2
        {
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            win_border[1].SetActive(true); animators[1].Play("ract2");
            win_border[5].SetActive(true); animators[5].Play("ract6");
            win_border[8].SetActive(true); animators[8].Play("ract9");
            win_border[11].SetActive(true); animators[11].Play("ract12");
            win_border[13].SetActive(true); animators[13].Play("ract14");
            compared_result_lines[6].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])) || (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[1])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[1].SetActive(true); animators[1].Play("ract2");
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[11].SetActive(true); animators[11].Play("ract12");
            }
            if (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[11].SetActive(true); animators[11].Play("ract12");
                win_border[13].SetActive(true); animators[13].Play("ract14");
            }
            compared_result_lines[6].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[2])) || (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2])) || (rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[1])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[1].Equals(rule2[2]) && rule2[2].Equals(rule3[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[1].SetActive(true); animators[1].Play("ract2");
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[8].SetActive(true); animators[8].Play("ract9");
            }
            if (rule2[2].Equals(rule3[2]) && rule3[2].Equals(rule4[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[11].SetActive(true); animators[11].Play("ract12");
            }
            if (rule3[2].Equals(rule4[2]) && rule4[2].Equals(rule5[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[11].SetActive(true); animators[11].Play("ract12");
                win_border[13].SetActive(true); animators[13].Play("ract14");
            }
            compared_result_lines[6].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case8:
        if (rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2]) && rule4[2].Equals(rule5[2])) // 1-1-2-3-3
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[0].SetActive(true); animators[0].Play("ract1");
            win_border[3].SetActive(true); animators[3].Play("ract4");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[11].SetActive(true); animators[11].Play("ract12");
            win_border[14].SetActive(true); animators[14].Play("ract15");
            compared_result_lines[7].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2])) || (rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2]) && rule4[2].Equals(rule5[2])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0] == rule2[0] && rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[11].SetActive(true); animators[11].Play("ract12");
            }
            if (rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2]) && rule4[2].Equals(rule5[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[11].SetActive(true); animators[11].Play("ract12");
                win_border[14].SetActive(true); animators[14].Play("ract15");
            }
            compared_result_lines[7].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[1])) || (rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2])) || (rule3[1].Equals(rule4[2]) && rule4[2].Equals(rule5[2])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0].Equals(rule2[0]) && rule2[0].Equals(rule3[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[7].SetActive(true); animators[7].Play("ract8");
            }
            if (rule2[0].Equals(rule3[1]) && rule3[1].Equals(rule4[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[3].SetActive(true); animators[3].Play("ract4");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[11].SetActive(true); animators[11].Play("ract12");
            }
            if (rule3[1].Equals(rule4[2]) && rule4[2].Equals(rule5[2]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[11].SetActive(true); animators[11].Play("ract12");
                win_border[14].SetActive(true); animators[14].Play("ract15");
            }
            compared_result_lines[7].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case9:
        if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0]) && rule4[0].Equals(rule5[0])) // 3-3-2-1-1
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[5].SetActive(true); animators[5].Play("ract6");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[9].SetActive(true); animators[9].Play("ract10");
            win_border[12].SetActive(true); animators[12].Play("ract13");
            compared_result_lines[8].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0])) || (rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0]) && rule4[0].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[2].SetActive(true); animators[2].Play("ract3");
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[9].SetActive(true); animators[9].Play("ract10");
            }
            if (rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0]) && rule4[0].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[9].SetActive(true); animators[9].Play("ract10");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }

            compared_result_lines[8].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }
        else if ((rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[1])) || (rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0])) || (rule3[1].Equals(rule4[0]) && rule4[0].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[2].SetActive(true); animators[2].Play("ract3");
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[7].SetActive(true); animators[7].Play("ract8");

            }
            if (rule2[2].Equals(rule3[1]) && rule3[1].Equals(rule4[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[5].SetActive(true); animators[5].Play("ract6");
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[9].SetActive(true); animators[9].Play("ract10");
            }
            if (rule3[1].Equals(rule4[0]) && rule4[0].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[7].SetActive(true); animators[7].Play("ract8");
                win_border[9].SetActive(true); animators[9].Play("ract10");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }
            compared_result_lines[8].SetActive(true);
            credit += total_bets * 100;
            PlayParticle();
            print("3:3");
        }

        // case10:
        if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[0])) //1-2-1-2-1
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[0].SetActive(true); animators[0].Play("ract1");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[6].SetActive(true); animators[6].Play("ract7");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[12].SetActive(true); animators[12].Play("ract13");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1])) || (rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[0])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[0].SetActive(true); animators[0].Play("ract1");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[0]))
            {
                FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[6].SetActive(true); animators[6].Play("ract7");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[12].SetActive(true); animators[12].Play("ract13");
            }
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }

        // case11:
        if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[2])) // 3-2-3-2-3
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[8].SetActive(true); animators[8].Play("ract9");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[14].SetActive(true); animators[14].Play("ract15");
            compared_result_lines[10].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        else if ((rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1])) || (rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[2])))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]))
            {
                win_border[2].SetActive(true); animators[2].Play("ract3");
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[10].SetActive(true); animators[10].Play("ract11");
            }
            if (rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[2]))
            {
                win_border[4].SetActive(true); animators[4].Play("ract5");
                win_border[8].SetActive(true); animators[8].Play("ract9");
                win_border[10].SetActive(true); animators[10].Play("ract11");
                win_border[14].SetActive(true); animators[14].Play("ract15");
            }
            compared_result_lines[10].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("4:4");
        }

        if (rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[0]) && rule3[0].Equals(rule4[1]) && rule4[1].Equals(rule5[1])) // 2-2-1-2-2
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[1].SetActive(true); animators[1].Play("ract2");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[6].SetActive(true); animators[6].Play("ract7");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[13].SetActive(true); animators[13].Play("ract14");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }

        if (rule1[1].Equals(rule2[1]) && rule2[1].Equals(rule3[2]) && rule3[2].Equals(rule4[1]) && rule4[1].Equals(rule5[1])) // 2-2-3-2-2
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[1].SetActive(true); animators[1].Play("ract2");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[8].SetActive(true); animators[8].Play("ract9");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[13].SetActive(true); animators[13].Play("ract14");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }

        if (rule1[2].Equals(rule2[2]) && rule2[2].Equals(rule3[2]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[5].SetActive(true); animators[5].Play("ract6");
            win_border[8].SetActive(true); animators[8].Play("ract9");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 250;
            PlayParticle();
            print("3:3");
        }


        if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[0])) // 1-2-2-2-1
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[0].SetActive(true); animators[1].Play("ract1");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[12].SetActive(true); animators[12].Play("ract13");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[0].SetActive(true); animators[1].Play("ract1");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("4:4");
        }
        if (rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[0]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[12].SetActive(true); animators[12].Play("ract13");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("4:4");
        }
        if (rule1[0].Equals(rule2[1]) && rule2[1].Equals(rule3[1]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[0].SetActive(true); animators[1].Play("ract1");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("3:3");
        }
        if (rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[0]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[12].SetActive(true); animators[12].Play("ract13");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("3:3");
        }


if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[2])) // 3-2-2-2-3
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[14].SetActive(true); animators[14].Play("ract15");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 500;
            PlayParticle();
            print("5:5");
        }
        if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("4:4");
        }
        if (rule2[1].Equals(rule3[1]) && rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[2]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[12].SetActive(true); animators[12].Play("ract13");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[14].SetActive(true); animators[14].Play("ract15");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("4:4");
        }
        if (rule1[2].Equals(rule2[1]) && rule2[1].Equals(rule3[1]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[2].SetActive(true); animators[2].Play("ract3");
            win_border[4].SetActive(true); animators[4].Play("ract5");
            win_border[7].SetActive(true); animators[7].Play("ract8");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("3:3");
        }
        if (rule3[1].Equals(rule4[1]) && rule4[1].Equals(rule5[2]))
        {
            FindAnyObjectByType<gamemanager>().sources[3].Play();
            FindAnyObjectByType<spincall>().logo_spin.SetActive(true);
            win_border[7].SetActive(true); animators[7].Play("ract8");
            win_border[10].SetActive(true); animators[10].Play("ract11");
            win_border[14].SetActive(true); animators[14].Play("ract15");
            compared_result_lines[9].SetActive(true);
            credit += total_bets * 400;
            PlayParticle();
            print("3:3");
        }

        FindAnyObjectByType<gamemanager>().credit = credit;
        FindAnyObjectByType<gamemanager>().total_bets = total_bets;

        FindAnyObjectByType<gamemanager>().convert(FindAnyObjectByType<gamemanager>().credit, FindAnyObjectByType<gamemanager>().credit_txt);
        FindAnyObjectByType<gamemanager>().convert(total_bets, FindAnyObjectByType<gamemanager>().total_txt);
    }
}
