using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    public int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }
}
