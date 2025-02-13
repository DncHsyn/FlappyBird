using UnityEngine;

public class yonetici : MonoBehaviour
{
    public GameObject boru;
    void Start()
    {
        InvokeRepeating("boru_ekle", 0.0f, 3.0f);
    }

    // Update is called once per frame
    void boru_ekle()
    {
        GameObject yeni_boru = Instantiate(boru);
    }
}
