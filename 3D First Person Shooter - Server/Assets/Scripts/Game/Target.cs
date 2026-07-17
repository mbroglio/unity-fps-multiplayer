using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 70f;

    public void TakaDamage (float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }
}
