using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int CurrentHealth => _currentHealth;
    public int MaxHealth => _maxHealth;

    private int _currentHealth = 3;
    private int _maxHealth = 3;

    public void PlusHealth()
    {
        _currentHealth++;
    }

    public void MinusHealth()
    {
        _currentHealth--;
    }
}
