using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paddleScript : MonoBehaviour
{
    public float speed;
    public Text context;
    public int score_num　=0;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed,0f,0f);
        // Debug.Log(transform.position.x);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball")){
        score_num += 1;
        // Debug.Log(score_num);
        context.text=score_num.ToString();
        }
    }
}
