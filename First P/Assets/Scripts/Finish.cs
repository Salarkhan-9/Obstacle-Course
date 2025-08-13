using UnityEngine;

public class Finish : MonoBehaviour
{
    public string playerTag="Player";
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            Debug.Log("Finish");
        }
    }
    
}
