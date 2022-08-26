using UnityEngine;
using System.Collections;

public class PushDown : MonoBehaviour
{
    GameObject bls;
    BlockSpawner bs;
    float limit = 1f;
    public Transform tf;



    public void Awake()
    {
        bls = GameObject.Find("BlockSpawner");
        bs = bls.GetComponent<BlockSpawner>();
        tf = this.gameObject.GetComponent<Transform>();
    }
    
    void Update()
    {
        if (bs.spawnCount > limit)
        {
            StartCoroutine(wait());
            limit++;
            Debug.Log(tf.position.y);

        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        this.tf.position = new Vector2 (this.tf.position.x, this.tf.position.y - 1);

    }
}