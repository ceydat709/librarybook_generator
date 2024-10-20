using UnityEngine;

public class FavoritesManager : MonoBehaviour
{
    public static FavoritesManager Instance;

    public FavoritesData favoritesData;

    private void Awake()
    {
        Debug.Log("FavoritesManager Awake");
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

    private void OnEnable()
    {
        //reset favorites data when script is enabled
        ResetFavoritesData();
    }

    public void AddToFavorites(string bookTitle)
    {
        //check book title
        if (!favoritesData.favoritesList.Contains(bookTitle))
        {
            //add title to list 
            favoritesData.favoritesList += bookTitle + ",";
        }
        else
        {
            Debug.LogWarning("Book '" + bookTitle + "' is already in favorites.");
        }
    }


    public void ClearFavorites()
    {
        Debug.Log("Clearing favorites");
        //clear list
        ResetFavoritesData();
    }

    private void ResetFavoritesData()
    {
        //reset favorites data
        favoritesData.favoritesList = "";
    }
}
