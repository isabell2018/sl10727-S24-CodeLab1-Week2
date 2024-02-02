using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public static WASDController Instance;
    public float velocity = 10;

    private Rigidbody2D rb;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(velocity * Vector2.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(velocity * Vector2.down);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(velocity * Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(velocity * Vector2.right);
        }

        rb.velocity *= 0.999f;
    }
}