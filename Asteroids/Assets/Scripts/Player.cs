using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public class Player : MonoBehaviour
{
    public float speed = 10;
    public float RtSpeed = 10;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireRate = 0.5f;


    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(Fire), fireRate, fireRate);

    }

    void FixedUpdate()
    {
        var direction = new Vector3();
        
        direction.y = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime;



        var worldPos = Camera.main.ScreenToWorldPoint(direction);




        var target = Vector3.MoveTowards(transform.position, direction, speed * Time.fixedDeltaTime);

        
    }

    

    void Fire()
    {
        Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
    }

}

