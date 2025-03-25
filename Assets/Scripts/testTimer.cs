using UnityEngine;

public class testTimer : MonoBehaviour
{
   Timer timer;
   float startTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 5.0f;
        timer.run();
        startTime= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Finished)
        {
            float elapsedTime = Time.time - startTime;
            Debug.Log($"Timer ran :{elapsedTime}  seconds");
            timer.run();
            startTime = Time.time;

        }
    }
}
