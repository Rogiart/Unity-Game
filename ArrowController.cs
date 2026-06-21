using UnityEngine;

public class EnemyController
    : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        transform.Translate(
            0,
            -speed * Time.deltaTime,
            0
        );

        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}