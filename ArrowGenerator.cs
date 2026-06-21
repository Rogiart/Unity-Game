using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject proposal;
    public GameObject mail;
    public GameObject deadline;
    public GameObject complaint;

    float timer = 0;
    float spawnTime = 2f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTime)
        {
            timer = 0;

            float x =
                Random.Range(-7f, 7f);

            Vector3 pos =
                new Vector3(x, 6, 0);

            int r =
                Random.Range(0, 4);

            if (r == 0)
                Instantiate(
                    proposal,
                    pos,
                    Quaternion.identity);

            if (r == 1)
                Instantiate(
                    mail,
                    pos,
                    Quaternion.identity);

            if (r == 2)
                Instantiate(
                    deadline,
                    pos,
                    Quaternion.identity);

            if (r == 3)
                Instantiate(
                    complaint,
                    pos,
                    Quaternion.identity);
        }
    }
}