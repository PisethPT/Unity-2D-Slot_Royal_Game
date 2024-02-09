using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPref : MonoBehaviour
{
    static int balance = 100000;

    public static void SaveBalance(){
        balance = FindAnyObjectByType<gamemanager>().credit;
        PlayerPrefs.SetInt("balance", balance);
        Debug.Log("Balance: "+PlayerPrefs.GetInt("balance"));
    }
}
