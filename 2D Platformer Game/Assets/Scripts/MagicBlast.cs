using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlast : MonoBehaviour
{
    public float speed =30.0f;
    public int damage = 1;
    
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>(); //ref to rigidbody2D component
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed * Time.deltaTime; //this line of code adds celocity and makes the gameobject move forward
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage); //Run the TakeDamage function and apply damage to enemy
        }

        Destroy(gameObject);//destroy projectile
    }
}
