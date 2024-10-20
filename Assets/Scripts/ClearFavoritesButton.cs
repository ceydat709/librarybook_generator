using UnityEngine;
using UnityEngine.UI;

public class ClearFavoritesButton : MonoBehaviour
{
    private Button clearButton;
    public FavoritesUI favoritesUI; // Reference to the FavoritesUI script

    private void Start()
    {
        // Get the Button component
        clearButton = GetComponent<Button>();

        // Add listener for button click
        clearButton.onClick.AddListener(ClearFavorites);
    }

    private void ClearFavorites()
    {
        // Call the ClearFavorites method directly on the referenced FavoritesUI script
        if (favoritesUI != null)
        {
            favoritesUI.ClearFavorites();
        }
        else
        {
            Debug.LogError("FavoritesUI reference not set on ClearFavoritesButton.");
        }
    }
}
