using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    [SerializeField] GameObject log;
    [SerializeField] float speed;
    [SerializeField] float timeBetweenLogs;
    [SerializeField] Log.FlowDirection flow;


    float time = 0;
    void Start()
    {
        if (flow == Log.FlowDirection.RIGHT)
            transform.localScale = new Vector2(-1, 1); // flip if oriented right
    }

    void FixedUpdate()
    {
        if (time >= timeBetweenLogs)
        {
            GameObject current = Instantiate<GameObject>(log, transform.position, Quaternion.identity, transform.parent);
            current.GetComponent<Log>().SetSpeedAndDirection(speed, flow);
            time = 0;
        }
        time += Time.fixedDeltaTime;

    }
}
