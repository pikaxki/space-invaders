using System.Threading;
using UnityEngine;

public class invander : MonoBehaviour
{
    public Sprite[] animationSprites;
    public float animationTime = 1.0f;
    private SpriteRenderer spriteRenderer;
    private int animationFrame;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();

        InvokeRepeating(nameof(Animation), 0f, animationTime);
        
    }

    private void Animation()
    {
        int n = animationSprites.Length;

     
        
        animationFrame = animationFrame +1;

        if(animationFrame >= this.animationSprites.Length)
            {
                animationFrame = 0;
            }
    
        spriteRenderer.sprite = this.animationSprites[animationFrame];
    
    }
}