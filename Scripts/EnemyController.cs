using UnityEngine;

public class EnemyController
    : MonoBehaviour
{
    public float speed = 5f;

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