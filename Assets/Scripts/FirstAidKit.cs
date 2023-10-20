using UnityEngine;

public class FirstAidKit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerHealth>(out PlayerHealth player))
        {
            if (player.CurrentHealth < player.MaxHealth)
            {
                player.PlusHealth();

                Destroy(gameObject);
            }
        }
    }
}
