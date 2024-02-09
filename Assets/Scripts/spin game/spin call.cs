using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class spincall : MonoBehaviour
{
    public GameObject spinObject, slotObject;
    public GameObject logo_spin;
    public GameObject spin_collider;
    public GameObject slot_component;
    public GameObject spin_component, s,l;

    public void spin_calling()
    {
        FindAnyObjectByType<gamemanager>().sources[5].Play();
        FindAnyObjectByType<spin>().spin_isstop = false;
        FindAnyObjectByType<spin>().isspin = false;

        FindAnyObjectByType<spin>().ani.Play("idle");
        logo_spin.SetActive(false);
        spinObject.SetActive(true);
        slotObject.SetActive(false);
        spin_collider.SetActive(true);
        spin_component.SetActive(true);
        slot_component.SetActive(false);
        s.SetActive(true);
        l.SetActive(true);
    }
    

}
