using UnityEngine;

public class gibontrigger : MonoBehaviour
{
    public GameObject gib;

    void OnTriggerEnter()
    {
        Instantiate(gib, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
