﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   //easy move script to move the animals and the projectiles
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
