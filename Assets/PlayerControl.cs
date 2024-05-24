using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float Speed;
    public float xDirection;
    public float yDirection;
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + Speed * xDirection * Time.deltaTime, _compTransform.position.y + Speed * yDirection * Time.deltaTime);
        if (_compTransform.position.x >= 4.65)
        {
            xDirection = -1;
            _compSpriteRenderer.flipX = true;
        }
        if (_compTransform.position.x <= -4.65)
        {
            xDirection = 1;
            _compSpriteRenderer.flipX = false;
        }
        if (_compTransform.position.y >= 3.42)
        {
            yDirection = -1;
            _compSpriteRenderer.flipY = true;
        }
        if (_compTransform.position.y <= -3.42)
        {
            yDirection = 1;
            _compSpriteRenderer.flipY = false;
        }
    }
}
