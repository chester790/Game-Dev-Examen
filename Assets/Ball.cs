using System.Collections;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rg;
    public float speed;
    private int lPunt, rPunt;
    public TextMeshProUGUI textR, textL;
    void Start()
    {
        Launch();
    }

    void Launch()
    {
        transform.position = Vector2.zero;
        float x = Random.Range(-1f, 2f);
        float y = Random.Range(-1f, 2f);
        rg.velocity = new Vector2(x * speed, y * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Links")
        {
            rPunt++;
            textR.text = rPunt.ToString();
            Launch();
        }
        else if (collision.gameObject.tag == "Rechts")
        {
            lPunt++;
            textL.text = lPunt.ToString();
            Launch();
        }
    }
}
