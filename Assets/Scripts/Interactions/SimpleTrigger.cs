using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{
    public bool DestroyOnTrigger;
    public string tagFilter;    

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagFilter))
        {
            onTriggerEnter.Invoke();


            
        }
    }
    void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(tagFilter))
            {
                onTriggerExit.Invoke();

                if (DestroyOnTrigger)
                    Destroy(gameObject);
            }
            

        }

    
}