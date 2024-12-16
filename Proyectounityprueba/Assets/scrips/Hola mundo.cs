using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    private void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
        Debug.LogError("Hola desde Start usando logError");
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Hola desde Update usando logWarning");
    }


    private void FixedUpdate()
    {
        Debug.Log("Hola mundo desde Fixed Update");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola mundo desde LateUpdate");
    }
}
