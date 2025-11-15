using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    [SerializeField, Min(0)] int spawnedCount = 1000;
    [SerializeField] GameObject gameObjectPrefab;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnedCount; i++)
        {
            Vector2 pos = GetRandomPointInView();
            GameObject gob = Instantiate(gameObjectPrefab, pos, Quaternion.identity);
        }
    }

    private Vector2 GetRandomPointInView()
    {
        Vector2 randomViewPoint = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f));
        Vector2 worldPoint = Camera.main.ViewportToWorldPoint(randomViewPoint);
        return worldPoint;
    }
}
