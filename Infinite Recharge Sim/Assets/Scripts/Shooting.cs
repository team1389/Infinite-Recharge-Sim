using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float shootSpeed;
    public double angle = 60;
    private float powerCells = 3;
    public Text powerCellText;

    void FirePowerCell()
    {
        if (powerCells > 0)
        {
            Vector3 powerCellStartPosition = transform.forward.normalized + transform.position;
            Rigidbody powerCellClone = (Rigidbody)Instantiate(projectile, powerCellStartPosition, transform.rotation);

            powerCellClone.velocity = ((transform.forward * (float)Math.Cos(angle * (Math.PI / 180))) +
                (transform.up * (float)Math.Sin(angle * (Math.PI / 180)))).normalized * shootSpeed;

            powerCells += -1;
            powerCellText.text = "Power Cells: " + powerCells;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FirePowerCell();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Power Cell" && powerCells < 5)
        {
            powerCells += 1;
            powerCellText.text = "Power Cells: " + powerCells;

            other.gameObject.SetActive(false);
        }
    }
}
