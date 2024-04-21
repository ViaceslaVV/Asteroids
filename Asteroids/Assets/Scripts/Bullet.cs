using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public float lifetime = 3;
    public int damage = 10;

    

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.forward * speed;
        Destroy(gameObject, lifetime);
    }

    
    
}