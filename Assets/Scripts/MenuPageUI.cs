using UnityEngine;
using TMPro;

public class MenuPageUI : MonoBehaviour
{
    public static MenuPageUI Instance;

    public TextMeshProUGUI favoritesText; //reference favorites text

    void Awake()
    {
        favoritesText = GameObject.Find("Favoritedisplay").GetComponent<TextMeshProUGUI>();
        //one instance exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
    void Start()
    {
        //update UI 
        UpdateFavoritesUI();
    }

    //update UI elements with data
    public void UpdateFavoritesUI()
    {
        string favorites = PlayerPrefs.GetString("FavoritedBooks", "");
        favoritesText.text = "Favorited Books:\n" + favorites.Replace(",", "\n");
    }
}
