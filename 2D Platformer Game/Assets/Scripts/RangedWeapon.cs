using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;
    private bool isFacingRight = true;
    private float moveInput;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectile,firePoint.position,firePoint.rotation);
    }

    void FixedUpdate()
    {
        if(!isFacingRight && moveInput >0)
        {
            FlipPlayer();
        }
        else if(isFacingRight && moveInput <0)
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
