using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public Transform spawnPoint; // The point where the projectile will be spawned
    public float shootInterval = 1f; // Interval between each shot

    private void Start()
    {
        // Start shooting projectiles
        StartCoroutine(ShootProjectiles());
    }

    private IEnumerator ShootProjectiles()
    {
        while (true)
        {
            // Instantiate the projectile prefab at the spawn point's position and rotation
            Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);

            yield return new WaitForSeconds(shootInterval);
        }
    }
}

    
