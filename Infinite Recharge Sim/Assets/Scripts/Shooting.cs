using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float shootSpeed;
    public double angle = 60;

    void FirePowerCell()
    {
        Vector3 powerCellStartPosition = transform.forward.normalized + transform.position;
        Rigidbody powerCellClone = (Rigidbody)Instantiate(projectile, powerCellStartPosition, transform.rotation);

        powerCellClone.velocity = ((transform.forward * (float)Math.Cos(angle * (Math.PI/180))) + 
            (transform.up * (float)Math.Sin(angle * (Math.PI/180)))).normalized * shootSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FirePowerCell();
        }
    }
}
