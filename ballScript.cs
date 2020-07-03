using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// シーンを読み込む際に使う


public class ballScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f,15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f,0f,-1 * speed*Time.deltaTime);
        if (transform.position.z < -13.0f)
        {
            SceneManager.LoadScene("gameoversean");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            Destroy(gameObject);
            
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f,1.0f),0f,0f);
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
            }
        }
    }
}
