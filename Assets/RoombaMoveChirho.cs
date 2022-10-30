// For God so loved the world, that He gave His only begotten Son, that all who believe in Him should not perish but have everlasting life

using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaMoveChirho : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 45f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("MainCamera").transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime * Input.GetAxis("Vertical")));
        transform.Rotate(0f, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed, 0f);
    }
}
