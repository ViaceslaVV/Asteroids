using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] states;
    public int hits = 1;
    public int points = 100;

    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hits--;
        if (hits > 0)
            sr.sprite = states[hits - 1];

        if (hits <= 0)
        {
            GameManager.score += points;
            Destroy(gameObject);
        }
    }
}
