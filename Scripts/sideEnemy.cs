using UnityEngine;

public class SideEnemy : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        transform.Translate(
            -speed * Time.deltaTime,
            0,
            0
        );

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}