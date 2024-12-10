using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionLauncher : MonoBehaviour
{
    public GameObject ballPrefab;       // Ball prefab to spawn
    public Transform spawnPoint;       // Location where the ball spawns
    public float launchForce = 20f;    // Force applied to the ball
    public float fireRate = 2f;        // Time between pitches
    public Transform player;
    private float nextFireTime;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            LaunchBall();
            nextFireTime = Time.time + fireRate;
        }
    }

    void LaunchBall()
    {
        // Instantiate the ball at the spawn point
        GameObject ball = Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);

        // Apply a force to the ball's Rigidbody
        Vector3 directionToPlayer = (player.position - spawnPoint.position).normalized;
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(directionToPlayer * launchForce, ForceMode.Impulse);
        }

        // Optional: Destroy the ball after some time
        Destroy(ball, 5f);
    }
}
