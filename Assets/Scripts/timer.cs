using UnityEngine;

public class Timer : MonoBehaviour
{

    private float duration= 0 ;
    private float elapsedTime = 0;
    private bool started = false;
    private bool running = false;

    public float Duration { set { if (!running) duration = value; }}
    public bool Finished { get {return started && !running ;}}
    public bool IsRunning { get { return running; }}
    

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            elapsedTime += Time.deltaTime;
            if ( elapsedTime >= duration)
            {
                running = false;
                elapsedTime = 0;
            }
        }
    }


    public void run()
    {
        if (duration > 0 )
        {
            started = true;
            running =true;
            elapsedTime = 0;

        }
    }



}
