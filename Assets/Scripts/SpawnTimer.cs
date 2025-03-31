using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    [SerializeField] GameObject ball;
    Timer spawnTimer;
    private const float SPAWN_MIN_TIME = 2f;
    private const float SPAWN_MAX_TIME = 4f;
    private const float SPAWN_MIN_X = -8F;
    private const float SPAWN_MAX_X = 8F;
    private const float SPAWN_MIN_Y = -5F;
    private const float SPAWN_MAX_Y = 5F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(SPAWN_MIN_TIME, SPAWN_MAX_TIME);
        spawnTimer.run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished)
        {
            Instantiate(ball, new Vector3(  Random.Range(SPAWN_MIN_X, SPAWN_MAX_X), 
                                            Random.Range(SPAWN_MIN_Y, SPAWN_MAX_Y),
                                            0),
                                            Quaternion.identity);
            spawnTimer.run();
        }
    }
}
