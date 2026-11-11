using UnityEngine;
using UnityEngine.Assertions.Must;

public class Target : MonoBehaviour
{
    [SerializeField] private int health = 80;

    public void TakeDamage(int amount)
    {
        health -= amount;
        
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Objeyi X ekseninde 90 derece geriye döndürerek devir
        transform.Rotate(90f, 0f, 0f);

        this.enabled = false;
    }


}
