using UnityEngine;

public class MagicGem : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = spriteRenderer.color;
        }
    }
}
