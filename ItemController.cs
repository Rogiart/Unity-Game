using UnityEngine;

public class ItemController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float dropSpeed = -0.03f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,this.dropSpeed,0);
        if(transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
