﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstShotPatternController : MonoBehaviour {

    Rigidbody2D shotrb;
    public GameObject shotType;
    public float speed;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;



    // Use this for initialization
    void Start () {
        shotrb = shotType.GetComponent<Rigidbody2D>();
        shotrb.GetComponent<ForwardMover>().speed = speed;
        //shotrb.velocity = -transform.up * speed;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            for(int i = 0; i < 12; i++)
            {
                Instantiate(shotType, transform.position, Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + (30.0f * i))) );
            }

        }
    }
}
