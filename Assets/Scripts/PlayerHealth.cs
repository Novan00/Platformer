using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _currentHealth = 3;
    private int _maxHealth = 3;

    public int CurrentHealth => _currentHealth;
    public int MaxHealth => _maxHealth;

    public void TakeHeal()
    {
        _currentHealth++;
    }

    public void TakeDamage()
    {
        _currentHealth--;
    }
}
