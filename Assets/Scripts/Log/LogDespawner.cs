using UnityEngine;

public class LogDespawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Log") && (collision.transform.parent == transform.parent))
        {
            Destroy(collision.gameObject);
        }
    }
}
