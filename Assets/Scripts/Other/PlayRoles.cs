using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRoles : MonoBehaviour
{
    [SerializeField] private GameObject playRoles;
   // [SerializeField] private Animator panelAnimation;

    public void ShowPlayRoles(){
        playRoles.SetActive(true);
       // panelAnimation.Play("Show");
    }
    public void ClosePlayRoles(){
        playRoles.SetActive(false);
       // panelAnimation.Play("Reverse");
    }
}
