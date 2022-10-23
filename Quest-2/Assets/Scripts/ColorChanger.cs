// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorSelect
{
    Red,
    Yellow,
    Blue
}

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private ColorSelect colors;

    private SpriteRenderer mySpriteRenderer;

    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        AssignColor();
    }

    private void AssignColor()
    {
        switch (colors)
        {
            case ColorSelect.Red:
                mySpriteRenderer.color = Color.red;
                break;

            case ColorSelect.Yellow:
                mySpriteRenderer.color = Color.yellow;
                break;

            case ColorSelect.Blue:
                mySpriteRenderer.color = Color.blue;
                break;
        }
    }
}
