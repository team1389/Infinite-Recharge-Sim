using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody projectile;
    public float shootSpeed;
    public float angle;

    void FirePowerCell()
    {
        Vector3 powerCellStartPosition =  transform.forward.normalized + transform.position;

        Rigidbody powerCellClone = (Rigidbody)Instantiate(projectile, powerCellStartPosition, transform.rotation);
        powerCellClone.velocity = (transform.forward * (float) Math.Cos((Math.PI / 180) * angle) + (transform.up * (float)Math.Sin((Math.PI / 180) * angle))).normalized * shootSpeed;
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
