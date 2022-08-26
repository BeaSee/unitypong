using UnityEngine;

public class Destroy : MonoBehaviour
{
    float hp = 1f;
    public GameObject go;

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Ball")
        {
            hp--;
            if(hp <= 0)
            {
                Destroy(go);
            }
        }
        if (collision.collider.name == "Table")
        {
            Destroy(go);
        }
        
    }
}
