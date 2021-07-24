using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    void Die()
    {
        Destroy(player);
    }
}
