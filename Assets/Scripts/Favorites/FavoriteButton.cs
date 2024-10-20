using UnityEngine;

public class FavoriteButton : MonoBehaviour
{
    public string bookTitle;

    public void AddToFavorites()
    {
        //access favorites manager and add book
        FavoritesManager.Instance.AddToFavorites(bookTitle);
    }
}


