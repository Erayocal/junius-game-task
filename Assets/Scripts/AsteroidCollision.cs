
using UnityEngine;

public class AsteroidCollision : ICollisionHan
{
    private int hitCount = 0;
    private readonly int maxHits;

    public AsteroidCollision(int maxHits)
    {
        this.maxHits = maxHits;
    }

    public void HandleCollision(GameObject gameObject, Collider2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            hitCount++;
            if (hitCount >= maxHits)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
