
using UnityEngine;


public class Player_controller : MonoBehaviour
{
    [SerializeField] private float speed;
    private IMovmnet_interface movementStrategy;
    private ICollisionHan collisionHandler;

    private void Awake()
    {
        
        movementStrategy = new Movment();
        collisionHandler = new AsteroidCollision(4);
    }

    void Update()
    {
        
        movementStrategy.Move(transform, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        collisionHandler.HandleCollision(gameObject, collision);
    }
}

