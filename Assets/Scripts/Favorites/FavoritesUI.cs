using UnityEngine;
using TMPro;

public class FavoritesUI : MonoBehaviour
{
    public TextMeshProUGUI favoritesText;

    private void Update()
    {
        Debug.Log("FavoritesUI Update");
        //update UI with favorites
        favoritesText.text = "Favorited Books:\n" + FavoritesManager.Instance.favoritesData.favoritesList.Replace(",", "\n");
    }

    public void ClearFavorites()
    {
        Debug.Log("Clear favorites button clicked");
        //clear list 
        FavoritesManager.Instance.ClearFavorites();

        //update UI
        Update();
    }
}
