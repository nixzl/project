using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject platformPrefab;
    public int plaformCount = 300;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < plaformCount; i++)
        {
            spawnPosition.y += Random.Range( 2f, 2f);
            spawnPosition.x = Random.Range(-5, 5f);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
