using UnityEngine;

public class UISprites : MonoBehaviour
{
    private static UISprites instance;

    [SerializeField]
    private Sprite[] Numbers = null;

    [SerializeField]
    private Sprite[] LargeNumbers = null;

    private void Awake()
    {
        instance = this;
    }

    public static Sprite GetNumberSprite(int number)
    {
        if (instance?.Numbers == null)
            return null;

        number = Mathf.Clamp(number, 0, 9);

        return instance.Numbers[number];
    }

    public static Sprite GetLargeNumberSprite(int number)
    {
        if (instance?.LargeNumbers == null)
            return null;

        number = Mathf.Clamp(number, 0, 9);

        return instance.LargeNumbers[number];
    }
}
