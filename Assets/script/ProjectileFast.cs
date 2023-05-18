using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFast : MonoBehaviour

{
    public float speed = 15f;
    public float lifetime = 2f; // Time until the projectile is deleted

    private float timer;

    private void Start()
    {
        timer = lifetime;
    }

    private void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Update the timer
        timer -= Time.deltaTime;

        // Check if the projectile should be deleted
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}




