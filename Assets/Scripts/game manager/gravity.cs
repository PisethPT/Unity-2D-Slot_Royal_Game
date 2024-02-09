using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, -25);
    }

}
