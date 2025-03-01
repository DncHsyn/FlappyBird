using UnityEngine;

public class boru : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float rast = Random.Range(-2.368884f, -1.365697f);
        transform.position = new Vector3(1f, rast, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x <= -0.5f){
            Destroy(gameObject);
        }

        transform.Translate(-0.2f * Time.deltaTime, 0, 0);
    }
}
