using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 50f;

    public GameObject explosion;

    public Transform explosionTransform;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }


   public void Die()
    {
        Score.instance.AddPoint();
        Destroy(gameObject);
        GameObject explodeGO = Instantiate(explosion, explosionTransform.position, explosionTransform.rotation);
        Destroy(explodeGO, 0.1f);
    }
}
