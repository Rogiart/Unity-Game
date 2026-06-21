using UnityEngine;

public class SideGenerator : MonoBehaviour
{
    public GameObject Meating;
    public GameObject box;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 4f)
        {
            timer = 0;

            float y =
                Random.Range(-3f, -1f);

            Vector3 pos =
                new Vector3(
                    20f,
                    y,
                    0
                );

            int r =
                Random.Range(0, 2);

            if (r == 0)
            {
                Instantiate(
                    Meating,
                    pos,
                    Quaternion.identity
                );
            }

            if (r == 1)
            {
                Instantiate(
                    box,
                    pos,
                    Quaternion.identity
                );
            }
        }
    }
}