using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    public AudioSource backgroundMusic, click;
    private void Start()
    {
        backgroundMusic.Play();
    }
    public void goto_playe_scene()
    {
        click.Play();
        SceneManager.LoadScene("Slot Game Player");
    }
    public void quit()
    {
        click.Play();
        Application.Quit();
    }
}
