using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public Transform deathAnchor;
    private float numberOfHitsLeft = 3f;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfHitsLeft <= 0) 
        {
            player.position = deathAnchor.position;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Potion"))
        {
            Debug.Log("Collided with a Potion!");
            numberOfHitsLeft--;
        }
    }
}
