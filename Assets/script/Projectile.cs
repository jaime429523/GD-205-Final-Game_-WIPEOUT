using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f; // Time until the projectile is deleted

    private float timer;

    private void Start()
    {
        timer = lifetime;
    }

    private void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Update the timer
        timer -= Time.deltaTime;

        // Check if the projectile should be deleted
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}


